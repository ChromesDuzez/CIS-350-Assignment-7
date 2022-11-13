/* 
 * Zach Wilson
 * Assignment 7
 * This script manages the game over text object
*/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

//attach this script to the game over text gameObject
public class GameOverTextManager : MonoBehaviour
{
    // Start is called once on start
    void Start()
    {
        gameObject.GetComponent<Text>().text = "";
    }

    // Update is called once per frame
    void Update()
    {
        if (GameManager.gameOver && GameManager.winCondition)
        {
            gameObject.GetComponent<Text>().text = "You Win!\nScore: " + (SpawnManagerX.waveCount + GameObject.FindGameObjectsWithTag("Powerup").Length) + "\nPress R to Restart!";
        }
        else if (GameManager.gameOver)
        {
            gameObject.GetComponent<Text>().text = "You Lose!\nScore: " + (SpawnManagerX.waveCount + GameObject.FindGameObjectsWithTag("Powerup").Length) + "\nPress R to Restart!";
        }
        else if (!GameManager.gameOver)
        {
            gameObject.GetComponent<Text>().text = "";
        }
    }
}