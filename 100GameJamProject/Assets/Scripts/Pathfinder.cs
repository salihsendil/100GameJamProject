using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pathfinder : MonoBehaviour
{
    [SerializeField] GameObject path;
    List<Transform> waypoints;
    int waypointIndex = 0;
    float moveSpeed = 5f;

    // Start is called before the first frame update
    void Start()
    {
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
        if (transform.position == waypoints[waypointIndex].position) {
            if (waypoints.Capacity - 1 == waypointIndex) {
                waypoints.Reverse();
                waypointIndex = 0;
            }
            waypointIndex++;
        }
        transform.position = Vector2.MoveTowards(transform.position, waypoints[waypointIndex].position, moveSpeed * Time.deltaTime);
        //transform.LookAt(Vector3.forward, transform.right);
        //transform.rotation = Quaternion.LookRotation(waypoints[waypointIndex].position, Vector2.up);
    }
}
