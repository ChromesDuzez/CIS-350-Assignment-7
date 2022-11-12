/* 
 * Zach Wilson
 * Assignment 7
 * This script manages the spawning of the enemies and the powerups throughout the game
*/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    //prefabs
    public GameObject enemyPrefab;
    public GameObject powerupPrefab;

    //settings
    private float spawnRange = 9;

    //waveManager variables
    public int enemyCount;
    public static int waveNumber;

    // Start is called before the first frame update
    void Start()
    {
        waveNumber = 1;
        SpawnPrefab(enemyPrefab, waveNumber);
        SpawnPrefab(powerupPrefab, 1);
    }

    private void SpawnPrefab(GameObject prefab, int numToSpawn = 1, Quaternion rotation = new Quaternion())
    {
        if (rotation == new Quaternion()) { rotation = prefab.transform.rotation; }

        for (int i = 0; i < numToSpawn; i++)
        {
            //instantiate the enemy in the random position
            Instantiate(prefab, GenerateSpawnPosition(), rotation);
        }
    }

    private Vector3 GenerateSpawnPosition()
    {
        //generating a random position on the platform
        float spawnPosX = Random.Range(-spawnRange, spawnRange);
        float spawnPosZ = Random.Range(-spawnRange, spawnRange);
        return new Vector3(spawnPosX, 0, spawnPosZ);
    }

    // Update is called once per frame
    void Update()
    {
        enemyCount = GameObject.FindGameObjectsWithTag("Enemy").Length;

        if(enemyCount == 0 && !GameManager.gameOver)
        {
            waveNumber++;
            if(waveNumber > 10)
            {
                GameManager.gameOver = true;
                GameManager.winCondition = true;
            }
            SpawnPrefab(enemyPrefab, waveNumber);
            SpawnPrefab(powerupPrefab, 1);
        }
    }
}
