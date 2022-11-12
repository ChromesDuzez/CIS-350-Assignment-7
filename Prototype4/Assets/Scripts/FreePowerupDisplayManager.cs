/* 
 * Zach Wilson
 * Assignment 7
 * This script manages the hits until free powerup text object
*/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FreePowerupDisplayManager : MonoBehaviour
{
    // Start is called once on start
    void Start()
    {
        gameObject.GetComponent<Text>().text = "Hits until Free Powerup: " + (PlayerController.powerupAtHitNum - PlayerController.numBumps);
    }

    // Update is called once per frame
    void Update()
    {
        if (!GameManager.gameOver)
        {
            gameObject.GetComponent<Text>().text = "Hits until Free Powerup: " + (PlayerController.powerupAtHitNum - PlayerController.numBumps);
        }
    }
}
