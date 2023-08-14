using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RedCannonManager : MonoBehaviour
{
    public GameObject cannonBall;
    public GameObject redBarrelEnd;
    public float speed = 1;
    public float RotAngleY = 45;
    public SHOOTTHECANNON SHOOTTHECANNON; // Reference to the AimBarrel script

    // Update is called once per frame
    void Update()
    {
        if (SHOOTTHECANNON.personShooting % 2 == 1)
        {
            float rotationZ = Mathf.SmoothStep(-45, RotAngleY, Mathf.PingPong(Time.time * speed, 1));
            transform.rotation = Quaternion.Euler(0, 0, rotationZ);
        }

        if (Input.GetKeyDown(KeyCode.Space) && (SHOOTTHECANNON.personShooting % 2 == 1))
        {
            Instantiate(cannonBall, redBarrelEnd.transform.position, transform.rotation);
            Debug.Log("Red shot first!");
            SHOOTTHECANNON.personShooting += 1;
        
        }
    }  
}
