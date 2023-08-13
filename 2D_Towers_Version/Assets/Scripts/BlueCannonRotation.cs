using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlueCannonRotation : MonoBehaviour
{
    public float speed = 1;
    public float RotAngleY = 45;
    public SHOOTTHECANNON SHOOTTHECANNON; // Reference to the AimBarrel script

    // Update is called once per frame
    void Update()
    {
        if (SHOOTTHECANNON.personShooting % 2 == 0)
        {
            float rotationZ = Mathf.SmoothStep(-45, RotAngleY, Mathf.PingPong(Time.time * speed, 1));
            transform.rotation = Quaternion.Euler(0, 180, rotationZ);
        }
    }
}
