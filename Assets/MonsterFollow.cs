using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MonsterFollow : MonoBehaviour
{

    public Transform player; // Reference to the player object
    public float followSpeed = 3f; // Speed at which the monster follows
    public float followDistance = 3f; // Distance to maintain from the player
    public float maxFollow = 20f;
    public float speedStationary = 0f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // Get the direction to the player
        //Vector3 directionToPlayer = player.position - transform.position;

        // Normalize the direction vector
        //directionToPlayer.Normalize();

        // Move the monster towards the player at the specified speed
        //transform.position += directionToPlayer * followSpeed * Time.deltaTime;
        
        // Stop if the monster gets too close
        if (Vector3.Distance(transform.position, player.position) < followDistance || (Vector3.Distance(transform.position, player.position) > maxFollow))
        {
            followSpeed = speedStationary;
        }
        else
        {
            followSpeed = 3f;
            Vector3 directionToPlayer = player.position - transform.position;
            directionToPlayer.Normalize();
            transform.position += directionToPlayer * followSpeed * Time.deltaTime;
        }
        // Rotate the monster to face the player
        transform.LookAt(player.position);
    }
}