using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAI : MonoBehaviour
{
    Transform playerTransform;
    Pathfinder pathfinder;
    CharacterController characterController;
    Animator animator;
    int animIsWalking;
    bool isStopped;
    Quaternion currentRot;

    private void Awake()
    {
        pathfinder = GetComponentInParent<Pathfinder>();
        characterController = GetComponentInParent<CharacterController>();
        animator = GetComponentInParent<Animator>();
    }

    void Start()
    {
        //rb = transform.parent.GetComponent<Rigidbody2D>();

        //animIsWalking = Animator.StringToHash("isWalking");
    }

    void Update()
    {
        if (!pathfinder.IsStopped) {
            float angle = Mathf.Atan2(characterController.velocity.y, characterController.velocity.x) * Mathf.Rad2Deg;
            angle = (angle + 360) % 360;
            if (angle >= 45 && angle < 135) {
                //Debug.Log("yukarý");
                transform.rotation = Quaternion.Euler(0, 0, 180);
            }
            else if (angle >= 135 && angle < 225) {
                transform.rotation = Quaternion.Euler(0, 0, 270);
                //Debug.Log("sol");
            }
            else if (angle >= 225 && angle < 315) {
                //Debug.Log("aþaðý");
                transform.rotation = Quaternion.Euler(0, 0, 0);
            }
            else if (angle >= 315 || angle < 45) {
                //Debug.Log("sað");
                transform.rotation = Quaternion.Euler(0, 0, 90);
            }
        }
        else {
            transform.rotation = currentRot;
        }
    }
    
    private void OnTriggerEnter2D(Collider2D collision)
    {
        playerTransform = collision.transform;
        if (collision.gameObject.tag == "Player") {
            //shoot animation add
            //TODO death scene load            
            currentRot = transform.rotation;
            pathfinder.IsStopped = true;
            characterController.Move(Vector3.zero);
        }

    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        pathfinder.IsStopped = false;
        
    }
}
