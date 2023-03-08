using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnCoin : MonoBehaviour
{
    public GameObject coinPrefab;
    public float randomRange = 8f;
    private float timePassed = 0f;
    // Start is called before the first frame update
    void Start()
    {
        //spawn coin on start only once at the y axix of the player and a random x axis

        Instantiate(coinPrefab, new Vector3(Random.Range(randomRange * -1, randomRange), transform.position.y, 0), Quaternion.identity);

    }

    // Update is called once per frame
    void Update()
    {
        // spawn a coin every 2 seconds using a counter timePassed, on a random x axis at the y axis of the player
        timePassed += Time.deltaTime;
        if (timePassed >= 2f)
        {
            Instantiate(coinPrefab, new Vector3(Random.Range(randomRange * -1, randomRange), transform.position.y, 0), Quaternion.identity);
            timePassed = 0f;
        }

    }
}
