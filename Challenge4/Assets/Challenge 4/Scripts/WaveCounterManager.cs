/* 
 * Zach Wilson
 * Assignment 7
 * This script manages the wave display text object
*/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

//attach this script to the wave display text gameObject
public class WaveCounterManager : MonoBehaviour
{
    // Start is called once on start
    void Start()
    {
        gameObject.GetComponent<Text>().text = "Wave: 1";
    }

    // Update is called once per frame
    void Update()
    {
        if (!GameManager.gameOver)
        {
            gameObject.GetComponent<Text>().text = "Wave: " + SpawnManagerX.waveCount;
        }
    }
}
