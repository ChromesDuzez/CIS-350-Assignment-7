/* 
 * Zach Wilson
 * Assignment 7
 * This script manages the game over variables
*/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    //public variables
    public static bool gameOver;
    public static bool winCondition;
    public static bool StartOfGame;

    void Start()
    {
        StartOfGame = true;
        gameOver = false;
        winCondition = false;
    }

    // Update gets called once per frame
    void Update()
    {
        if (gameOver && Input.GetKeyDown(KeyCode.R))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
    }
}
