using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUpSpawner : MonoBehaviour
{
    public GameObject PowerUp;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnPowerUp", 7f, 11f);
    }

    // Update is called once per frame
    void Update()
    {
    
    }

    void SpawnPowerUp()
    {
        float randomX = Random.Range(-0.5f, 1.0f);
        float randomY = Random.Range(-4.0f, 5.0f);
        Vector3 spawnPosition = new Vector3(randomX, randomY, 0f);

        
        GameObject newPowerUp = Instantiate(PowerUp, spawnPosition, Quaternion.identity);
        Destroy(newPowerUp, 5.0f);
    }
}
