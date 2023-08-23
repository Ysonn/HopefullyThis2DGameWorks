using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RedCannonManager : MonoBehaviour
{
    public GameObject cannonBall;
    public GameObject TNT;
    public GameObject redBarrelEnd;
    public float speed = 1.0f;
    public float RotAngleY = 10;
    private bool canShoot = true;
    private bool hasPowerUp = false;
    private AudioSource audioSource;
    private Rigidbody2D rb;

    void Start()
    {
        audioSource = GetComponent<AudioSource>();
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (PowerUpManager.whoHasPowerUp == 1)
        {
            hasPowerUp = true;
        }

        float rotationZ = Mathf.SmoothStep(-45, RotAngleY, Mathf.PingPong(Time.time * speed, 1));
        transform.rotation = Quaternion.Euler(0, 0, rotationZ);

        if (Input.GetKeyDown(KeyCode.LeftShift) && canShoot)
        {
            GameObject spawnedCannonBall = Instantiate(cannonBall, redBarrelEnd.transform.position, transform.rotation);
            rb.AddForce( -transform.right * 4.0f , ForceMode2D.Impulse);
            spawnedCannonBall.tag = "RedCannonBall";
            audioSource.Play();
            StartCoroutine(FireDelay());
        }     

        if (Input.GetKeyDown(KeyCode.LeftShift) && canShoot && (hasPowerUp == true))
        {
            GameObject spawnedCannonBall = Instantiate(TNT, redBarrelEnd.transform.position, transform.rotation);
            rb.AddForce( -transform.right * 4.0f , ForceMode2D.Impulse);
            audioSource.Play();
            StartCoroutine(FireDelay());
        }       
    }  

    IEnumerator FireDelay()
    {
        canShoot = false;
        yield return new WaitForSeconds(0.2f);
        PowerUpManager.whoHasPowerUp = 0;
        canShoot = true;
    }
}
