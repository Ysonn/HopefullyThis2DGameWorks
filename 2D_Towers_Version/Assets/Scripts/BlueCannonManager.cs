using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlueCannonManager: MonoBehaviour
{
    public GameObject cannonBall;
    public GameObject blueBarrelEnd;
    public float speed = 1;
    public float RotAngleY = 45;

    
    // Update is called once per frame
    void Update()
    {
        
        if (TurnManagementScript.turnNumber % 2 == 0)
        {
            float rotationZ = Mathf.SmoothStep(-45, RotAngleY, Mathf.PingPong(Time.time * speed, 1));
            transform.rotation = Quaternion.Euler(0, 180, rotationZ);
        }

        if (TurnManagementScript.turnNumber % 2 == 0)
        {
            Instantiate(cannonBall, blueBarrelEnd.transform.position, transform.rotation);
            Debug.Log("Blue shot first!");
            TurnManagementScript.turnNumber += 1;
        }
    }
}
