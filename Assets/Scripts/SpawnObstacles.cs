using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnObstacles : MonoBehaviour
{
    public GameObject obstacle; //that we want to spawn
    public float maxX;
    public float minX;
    public float maxY;
    public float minY;
    public float timeBetweenSpawn; // how much time is taken till the next obstacle appear
    private float spawnTime;

    // Update is called once per frame
    void Update()
    {
        if(Time.time>spawnTime)
        {
            Spawn();
            spawnTime = Time.time + timeBetweenSpawn;
        }
    }

    void Spawn()
    {
        float randomX = Random.Range(minX, maxX);
        float randomY = Random.Range(minY, maxY);

        Instantiate(obstacle, transform.position + new Vector3(randomX, randomY, 0), transform.rotation);
    }
}
