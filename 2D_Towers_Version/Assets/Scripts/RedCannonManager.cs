using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RedCannonManager : MonoBehaviour
{
    public GameObject cannonBall;
    public GameObject redBarrelEnd;
    public float speed = 1;
    public float RotAngleY = 45;
  

    // Update is called once per frame
    void Update()
    {
        if (TurnManagementScript.turnNumber % 2 == 1)
        {
            float rotationZ = Mathf.SmoothStep(-45, RotAngleY, Mathf.PingPong(Time.time * speed, 1));
            transform.rotation = Quaternion.Euler(0, 0, rotationZ);
        }

        if (TurnManagementScript.turnNumber % 2 == 1)
        {
            Instantiate(cannonBall, redBarrelEnd.transform.position, transform.rotation);
            Debug.Log("Red shot first!");
            TurnManagementScript.turnNumber += 1;
        }
    }  
}
