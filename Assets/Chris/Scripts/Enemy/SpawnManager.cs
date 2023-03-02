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

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        enemyIndex = Random.Range(0, enemies.Length);
        selectedEnemy = enemies[enemyIndex];
    }
}
