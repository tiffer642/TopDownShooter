using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] enemies;
    public GameObject[] spawnPoints;
    GameObject selectedSpawnPoint;
    GameObject selectedEnemy;
    public GameObject spawnedEnemy;
    int enemyIndex;
    int spawnIndex;

    // Start is called before the first frame update
    void Start()
    {
        spawnPoints = GameObject.FindGameObjectsWithTag("SpawnPoint");
        enemyIndex = Random.Range(0, enemies.Length);
        spawnIndex = Random.Range(0, spawnPoints.Length);
        selectedEnemy = enemies[enemyIndex];
        selectedSpawnPoint = spawnPoints[spawnIndex];
        print(selectedEnemy.name);
        print(selectedSpawnPoint.name);
        Debug.Log(enemyIndex + ", " + spawnIndex);
        spawnedEnemy = Instantiate(selectedEnemy, selectedSpawnPoint.transform);
        Debug.Log(spawnedEnemy.transform.position);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
