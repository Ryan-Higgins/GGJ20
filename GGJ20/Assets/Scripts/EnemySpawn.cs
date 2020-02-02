using System;
using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Transactions;
using UnityEngine;
using Random = UnityEngine.Random;


public class EnemySpawn : MonoBehaviour
{

    public List<GameObject> enemies;
    private int dayCount;
    public static int sideChoice;
    private int ranNum;
    public static int enemyCount;
    public List<GameObject> spawners;
    
    // Start is called before the first frame update
    void Start()
    {
        dayCount = GameManager.CurrentDay;
        ranNum = Random.Range(0, 2);
        sideChoice = Random.Range(0, 2);
    }

    // Update is called once per frame
    void Update()
    {
        if (enemyCount < dayCount)
        {
            if (sideChoice == 0)
            {
                Spawn(spawners[0].transform);
            } else if (sideChoice == 1)
            {
                Spawn(spawners[1].transform);
            }
        }
    }

    void Spawn(Transform spawner)
    {
        if (ranNum == 0)
        {
            Instantiate(enemies[0], spawner);
            enemyCount++;
            sideChoice = Random.Range(0, 2);
        }
        else if (ranNum == 1)
        {
            Instantiate(enemies[1], spawner);
            enemyCount++;
            sideChoice = Random.Range(0, 2);
        }
    }
}
