using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] enemies;
    public GameObject[] spawnPoints;
    GameObject selectedSpawnPoint;
    GameObject selectedEnemy;
    GameObject currentEnemy;
    int enemyIndex;
    int spawnIndex;

    // Start is called before the first frame update
    void Start()
    {
        spawnPoints = GameObject.FindGameObjectsWithTag("SpawnPoint");
        spawnIndex = Random.Range(0, spawnPoints.Length);
        enemyIndex = Random.Range(0, enemies.Length);
        selectedSpawnPoint = spawnPoints[spawnIndex];
        selectedEnemy = enemies[enemyIndex];
        print(selectedSpawnPoint.name);
        currentEnemy = Instantiate(selectedEnemy, selectedSpawnPoint.transform);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
