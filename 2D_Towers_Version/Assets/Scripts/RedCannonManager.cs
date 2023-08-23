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
    private Rigidbody2D rb;

    void Start()
    {
        audioSource = GetComponent<AudioSource>();
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
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

        if (Input.GetKeyDown(KeyCode.LeftShift) && canShoot && (PowerUpManager.whoHasPowerUp == 1))
        {
            GameObject spawnedCannonBall = Instantiate(TNT, redBarrelEnd.transform.position, transform.rotation);
            rb.AddForce( -transform.right * 4.0f , ForceMode2D.Impulse);
            PowerUpManager.whoHasPowerUp = 0;
            audioSource.Play();
            StartCoroutine(FireDelay());
        }       
    }  

    IEnumerator FireDelay()
    {
        canShoot = false;
        yield return new WaitForSeconds(0.2f);
        canShoot = true;
    }
}
