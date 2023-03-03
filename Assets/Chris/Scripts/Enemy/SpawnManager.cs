using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] enemies;
    public GameObject[] spawnPoints;
    GameObject selectedSpawnPoint;
    GameObject selectedEnemy;
    int enemyIndex;
    int spawnIndex;
    int numberOfEnemies = 0;

    // Start is called before the first frame update
    void Start()
    {
        spawnPoints = GameObject.FindGameObjectsWithTag("SpawnPoint");
        spawnIndex = Random.Range(0, spawnPoints.Length);
        enemyIndex = Random.Range(0, enemies.Length);
        selectedSpawnPoint = spawnPoints[spawnIndex];
        selectedEnemy = enemies[enemyIndex];
        print(selectedSpawnPoint.name);
        StartCoroutine(SpawnEnemy());
    }

    // Update is called once per frame
    void Update()
    {
        spawnIndex = Random.Range(0, spawnPoints.Length);
        selectedSpawnPoint = spawnPoints[spawnIndex];
    }

    IEnumerator SpawnEnemy()
    {
        yield return new WaitForSeconds(1);
        if(numberOfEnemies < spawnPoints.Length + 1)
        {
            Instantiate(selectedEnemy, selectedSpawnPoint.transform);
            numberOfEnemies++;
            StartCoroutine(SpawnEnemy());
        }
    }
}
