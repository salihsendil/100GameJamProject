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
    LevelLoader levelLoader;

    private void Awake()
    {
        pathfinder = GetComponentInParent<Pathfinder>();
        characterController = GetComponentInParent<CharacterController>();
        animator = GetComponentInParent<Animator>();
        levelLoader = FindObjectOfType<LevelLoader>();
    }

    void Start()
    {

    }

    void Update()
    {
        if (pathfinder) {
            if (!pathfinder.IsStopped) {
                float angle = Mathf.Atan2(characterController.velocity.y, characterController.velocity.x) * Mathf.Rad2Deg;
                angle = (angle + 360) % 360;
                if (angle >= 45 && angle < 135) {
                    //Debug.Log("yukar�");
                    transform.rotation = Quaternion.Euler(0, 0, 180);
                }
                else if (angle >= 135 && angle < 225) {
                    transform.rotation = Quaternion.Euler(0, 0, 270);
                    //Debug.Log("sol");
                }
                else if (angle >= 225 && angle < 315) {
                    //Debug.Log("a�a��");
                    transform.rotation = Quaternion.Euler(0, 0, 0);
                }
                else if (angle >= 315 || angle < 45) {
                    //Debug.Log("sa�");
                    transform.rotation = Quaternion.Euler(0, 0, 90);
                }
            }
            else {
                transform.rotation = currentRot;
            }
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        playerTransform = collision.transform;
        if (collision.gameObject.tag == "Player") {
            //shoot animation add
            //TODO death scene load
            animator.speed = 0f;
            currentRot = transform.rotation;
            pathfinder.IsStopped = true;
            characterController.Move(Vector3.zero);
            levelLoader.LoadGameOverScene();
        }

    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        animator.speed = 1f;

        pathfinder.IsStopped = false;

    }
}
