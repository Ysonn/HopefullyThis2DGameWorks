using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RedCannonRotation : MonoBehaviour
{
    public float speed = 1;
    public float RotAngleY = 45;
    public AimBarrel AimBarrel; // Reference to the AimBarrel script

    // Update is called once per frame
    void Update()
    {
        if (AimBarrel.personShooting % 2 == 1)
        {
            float rotationZ = Mathf.SmoothStep(-45, RotAngleY, Mathf.PingPong(Time.time * speed, 1));
            transform.rotation = Quaternion.Euler(0, 0, rotationZ);
        }
    }  
}
