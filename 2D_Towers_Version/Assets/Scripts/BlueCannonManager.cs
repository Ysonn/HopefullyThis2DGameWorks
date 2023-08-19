using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlueCannonManager: MonoBehaviour
{
    public GameObject cannonBall;
    public GameObject blueBarrelEnd;
    public float speed = 1;
    public float RotAngleY = 45;
    private bool canShoot = true;

    
    // Update is called once per frame
    void Update()
    {
        float rotationZ = Mathf.SmoothStep(-45, RotAngleY, Mathf.PingPong(Time.time * speed, 1));
        transform.rotation = Quaternion.Euler(0, 180, rotationZ);

        if (Input.GetKeyDown(KeyCode.RightShift) && canShoot)
        {
            Instantiate(cannonBall, blueBarrelEnd.transform.position, transform.rotation);
            StartCoroutine(FireDelay());
        }        
    }

    IEnumerator FireDelay()
    {
        canShoot = false;
        yield return new WaitForSeconds(1f);
        canShoot = true;
    }
}
