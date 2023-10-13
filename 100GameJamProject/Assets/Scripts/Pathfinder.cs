using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pathfinder : MonoBehaviour
{
    [SerializeField] GameObject path;
    List<Transform> waypoints;
    int waypointIndex = 0;
    float moveSpeed = 3f;
    Rigidbody2D rb;
    Animator animator;
    int animHorizontalHash;
    int animVerticalHash;
    int animIsWalking;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
        animHorizontalHash = Animator.StringToHash("Horizontal");
        animVerticalHash = Animator.StringToHash("Vertical");
        animIsWalking = Animator.StringToHash("isWalking");

        waypoints = new List<Transform>();
        Debug.Log(path.transform.childCount);
        for (int i = 0; i < path.transform.childCount; i++) {
            waypoints.Add(path.transform.GetChild(i).transform);
        }

        transform.position = waypoints[0].transform.position;

        Debug.Log(waypoints);
        for (int i = 0; i < waypoints.Count; i++) {
            Debug.Log(waypoints[i].position);
        }
        Debug.Log(waypoints.Capacity);
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 previousPos = transform.position;
        if (transform.position == waypoints[waypointIndex].position) {
            if (waypoints.Capacity - 1 == waypointIndex) {
                waypoints.Reverse();
                waypointIndex = 0;
            }
            waypointIndex++;
        }
        transform.position = Vector2.MoveTowards(transform.position, waypoints[waypointIndex].position, moveSpeed * Time.deltaTime);
        Vector2 currentPos = transform.position;
        rb.velocity = previousPos - currentPos;
        animator.SetFloat(animHorizontalHash, rb.velocity.y);
        animator.SetFloat(animVerticalHash, rb.velocity.x);
        animator.SetBool(animIsWalking, rb.velocity != Vector2.zero);
        Debug.Log(rb.velocity);

        //rb.MovePosition(waypoints[waypointIndex].position);

        //transform.position = Vector2.MoveTowards(transform.position, waypoints[waypointIndex].position, moveSpeed * Time.deltaTime);
        //Vector3 pos = new Vector3(0, 0, waypoints[waypointIndex].position.x);
        //transform.rotation = Quaternion.Euler(pos);
        //transform.rotation = Quaternion.LookRotation(waypoints[waypointIndex].position, Vector2.up);
    }
}
