using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RedCannonManager : MonoBehaviour
{
    public GameObject cannonBall;
    public GameObject redBarrelEnd;
    public float speed = 1;
    public float RotAngleY = 45;
    private bool canShoot = true;
    private AudioSource audioSource;

    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        float rotationZ = Mathf.SmoothStep(-45, RotAngleY, Mathf.PingPong(Time.time * speed, 1));
        transform.rotation = Quaternion.Euler(0, 0, rotationZ);

        if (Input.GetKeyDown(KeyCode.LeftShift) && canShoot)
        {
            Instantiate(cannonBall, redBarrelEnd.transform.position, transform.rotation);
            audioSource.Play();
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
