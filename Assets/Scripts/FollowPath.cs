using System;
using System.Linq;
using System.Runtime.CompilerServices;
using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;

public class FollowPath : MonoBehaviour
{
    [SerializeField]
    private Transform[] waypoints;
    [SerializeField]
    private float moveSpeed = 2f;
    private int waypointIndex = 0;
    [SerializeField]
    private bool isLoop = true;
    private Transform player;
    private float dist;
    public float howclose;
    private Animator skeleAnim;
    public Transform hitbox;
    private bool attack;
    private void Start()
    {
        player = GameObject.FindGameObjectWithTag("PlayerWaypoint").transform;
        hitbox = GameObject.FindGameObjectWithTag("hitbox").transform;
        skeleAnim = GetComponent<Animator>();
        attack = true;
    }
    private async Task Update()
    {
        dist = Vector3.Distance(player.position, transform.position);
        if (dist <= 1.5)
        {
            if(skeleAnim != null)
            {
                    skeleAnim.SetTrigger("attackTrig");
                    moveSpeed = 0;
                    await Task.Delay(1000);
                    if(attack){
                        attack = false;
                        Instantiate(hitbox, transform.position, Quaternion.identity);
                        resetAttack();
                    }
                        
                    await Task.Delay(500);
                    
                    moveSpeed = 2f;
                   
            }
        }
        else if (dist <= howclose)
        {
            transform.LookAt(player);
            GetComponent<Rigidbody>().AddForce(transform.forward * 3);
            Vector3 destination = player.transform.position;
            Vector3 newPos = Vector3.MoveTowards(transform.position, destination, moveSpeed * Time.deltaTime);
            transform.position = newPos;
        }
        else
        {
            Vector3 destination = waypoints[waypointIndex].transform.position;
            Vector3 newPos = Vector3.MoveTowards(transform.position, destination, moveSpeed * Time.deltaTime);
            transform.LookAt(waypoints[waypointIndex]);
            transform.position = newPos;

            float distance = Vector3.Distance(transform.position, destination);
            
            if (distance <= 0.1)
            {
                if (waypointIndex < waypoints.Length - 1)
                {
                    waypointIndex++;
                    print("Going to waypoint " + waypointIndex);
                }
                else
                {
                    if (isLoop)
                    {
                        print("Looping...");
                        waypointIndex = 0;
                    }
                }
            }
            else
            {
                print(distance);
            }
        }
        }
    private async void resetAttack()
    {
        await Task.Delay(500);
        attack = true;
    }
}