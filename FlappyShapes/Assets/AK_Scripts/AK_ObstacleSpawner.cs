using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AK_ObstacleSpawner : MonoBehaviour
{

    public float spawnTimer;
    float timerHolder;

    public GameObject objectToSpawn;

    public Transform spawnPosition;


    private void Start()
    {
        timerHolder = spawnTimer;
        spawnTimer = 0;
    }

    private void Update()
    {
        if(spawnTimer <= 0)
        {
            SpawnObstacle();
            spawnTimer = timerHolder;
        }

        if(spawnTimer > 0)
        {
            spawnTimer -= Time.deltaTime;
        }

        
    }

    public void SpawnObstacle()
    {
        Instantiate(objectToSpawn,spawnPosition.position,Quaternion.identity,transform);

    }
}
