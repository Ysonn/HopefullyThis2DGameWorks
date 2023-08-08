using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AimBarrel : MonoBehaviour
{
    public int personShooting;

    // Start is called before the first frame update
    void Start()
    {
        // randomly selects a player to start
        personShooting = Random.Range(0, 2);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            personShooting += 1;
        }
    }
}