using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUpManager : MonoBehaviour
{
    public GameObject PowerUp;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnPowerUp", 7f, 7f);
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

        Instantiate(PowerUp, spawnPosition, Quaternion.identity);
    }
}
