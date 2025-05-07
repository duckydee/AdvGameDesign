using System;
using System.Linq;
using System.Runtime.CompilerServices;
using UnityEngine;

public class FollowPath : MonoBehaviour
{
    [SerializeField]
    private Transform[] waypoints;
    [SerializeField]
    private float moveSpeed = 2f;
    private int waypointIndex = 0;
    [SerializeField]
    private bool isLoop = true;

    private void Start()
    {
 
    }
    private void Update()
    {
        Vector3 destination = waypoints[waypointIndex].transform.position;
        Vector3 newPos = Vector3.MoveTowards(transform.position, destination, moveSpeed * Time.deltaTime);
        transform.position = newPos;

        float distance = Vector3.Distance(transform.position, destination);

        if (distance <= 0.1)
        {
            if (waypointIndex < waypoints.Length - 1)
            {
                waypointIndex++;
            }
            else
            {
                if (isLoop)
                {
                    waypointIndex = 0;
                }
            }
        }
    }
}