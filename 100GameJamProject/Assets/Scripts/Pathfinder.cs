using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pathfinder : MonoBehaviour
{
    [SerializeField] GameObject path;
    List<Transform> waypoints;
    int waypointIndex = 0;
    float moveSpeed = 2f;
    Animator animator;
    int animHorizontalHash;
    int animVerticalHash;
    int animIsWalking;
    bool isStopped;
    CharacterController characterController;
    float tolarance = 0.1f;

    //getters
    public List<Transform> Waypoints { get => waypoints; }
    public int WaypointIndex { get => waypointIndex; }
    public bool IsStopped { get => isStopped; set => isStopped = value; }

    void Start()
    {
        characterController = GetComponent<CharacterController>();
        animator = GetComponent<Animator>();
        animHorizontalHash = Animator.StringToHash("Horizontal");
        animVerticalHash = Animator.StringToHash("Vertical");
        animIsWalking = Animator.StringToHash("isWalking");

        waypoints = new List<Transform>();
        for (int i = 0; i < path.transform.childCount; i++) {
            waypoints.Add(path.transform.GetChild(i).transform);
        }
        transform.position = waypoints[0].transform.position;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        //Debug.Log("index num: " + waypointIndex);
        //Debug.Log("next pos: " + waypoints[waypointIndex].position);
        /*transform.position == waypoints[waypointIndex].position */
        if (Vector3.Distance(transform.position, waypoints[waypointIndex].position) < tolarance) {
            waypointIndex++;
        }
        if (waypointIndex == waypoints.Count - 1) {
            waypoints.Reverse();
            waypointIndex = 0;
        }

        if (!isStopped) {
            characterController.Move((waypoints[waypointIndex].position - transform.position).normalized * moveSpeed * Time.deltaTime);
            animator.SetFloat(animHorizontalHash, characterController.velocity.y);
            animator.SetFloat(animVerticalHash, characterController.velocity.x);
            //Debug.Log(characterController.velocity);

        }
        animator.SetBool(animIsWalking, characterController.velocity != Vector3.zero);

        //Debug.Log(rb.velocity.normalized);
        //transform.position = Vector2.MoveTowards(transform.position, waypoints[waypointIndex].position, moveSpeed * Time.deltaTime);
        //rb.velocity = (waypoints[waypointIndex].position - transform.position).normalized * Time.deltaTime * moveSpeed * 50f;
        //animator.SetFloat(animHorizontalHash, rb.velocity.y);
        //animator.SetFloat(animVerticalHash, rb.velocity.x);
    }
}


//enemy will turn to the player when he detected