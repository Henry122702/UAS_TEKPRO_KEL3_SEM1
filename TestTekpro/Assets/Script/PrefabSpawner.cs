using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PrefabSpawner : MonoBehaviour
{
    private float nextSpawnTime;

  
    public Transform[] spawnPoints;
    public GameObject[] customers;
    int randomSpawnPoint, randomCustomer;

    [SerializeField]
    private float spawnDelay = 10;


    public int itemCount = 0;
    int maxItem = 4;


    private void Update()
    {
        if(ShouldSpawn())
        {
            Spawn();
        }
    }

    

    private void Spawn()
    {
        if (itemCount >= maxItem) return;
        randomSpawnPoint = Random.Range(0, spawnPoints.Length);
        randomCustomer = Random.Range(0, customers.Length);
        nextSpawnTime = Time.time + spawnDelay;
        Instantiate(customers [randomCustomer], spawnPoints [randomSpawnPoint].position, transform.rotation, GameObject.FindGameObjectWithTag("Spawner").transform);
        itemCount++;
    }

    private bool ShouldSpawn()
    {
        return Time.time >= nextSpawnTime;
        
    }
}
