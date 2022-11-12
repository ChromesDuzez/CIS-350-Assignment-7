/* 
 * Zach Wilson
 * Assignment 7
 * This script manages the movement of the enemy AI
*/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAI : MonoBehaviour
{
    private Rigidbody enemyRb;
    public GameObject player;
    public float speed;

    // Start is called before the first frame update
    void Start()
    {
        enemyRb = GetComponent<Rigidbody>();
        player = GameObject.FindGameObjectWithTag("Player");
    }

    private void FixedUpdate()
    {
        //Add force toward the direction from the player to the enemy

        //vector for direction from enemy to player (normalized so that we get the direction and not the distance)
        Vector3 lookDirection = (player.transform.position - transform.position).normalized;

        //add force toward the player
        enemyRb.AddForce(lookDirection * speed);

        if(transform.position.y < -20)
        {
            Destroy(gameObject);
        }
    }
}
