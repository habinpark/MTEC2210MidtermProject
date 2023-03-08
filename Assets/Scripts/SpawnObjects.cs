using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnObjects : MonoBehaviour
{
    public GameObject UnityPrefab;
    public GameObject UnrealPrefab;
    public GameObject BlenderPrefab;
    public GameObject LeftSpawnPoint;
    public GameObject RightSpawnPoint;

    private float timePassed;
    private float spawnTime;

    public float minSpawnTime = 1f;
    public float maxSpawnTime = 3f;

    // Start is called before the first frame update
    void Start()
    {
        //set spawnTime to a random number between 1 and 3
        spawnTime = Random.Range(minSpawnTime, maxSpawnTime);
    }

    // Update is called once per frame
    void Update()
    {
        timePassed += Time.deltaTime;
        //if timePassed is greater than spawnTime, spawn a random UnityPrefab, UnrealPrefab, or BlenderPrefab at a random x axis between the left and right spawn points
        if (timePassed >= spawnTime)
        {
            int randomPrefab = Random.Range(0, 3);
            int randomX = Random.Range((int)LeftSpawnPoint.transform.position.x, (int)RightSpawnPoint.transform.position.x);
            if (randomPrefab == 0)
            {
                Instantiate(UnityPrefab, new Vector3(randomX, transform.position.y, 0), Quaternion.identity);
            }
            else if (randomPrefab == 1)
            {
                Instantiate(UnrealPrefab, new Vector3(randomX, transform.position.y, 0), Quaternion.identity);
            }
            else if (randomPrefab == 2)
            {
                Instantiate(BlenderPrefab, new Vector3(randomX, transform.position.y, 0), Quaternion.identity);
            }
            //reset timePassed and spawnTime
            timePassed = 0f;
            spawnTime = Random.Range(minSpawnTime, maxSpawnTime);
        }
    }
}
