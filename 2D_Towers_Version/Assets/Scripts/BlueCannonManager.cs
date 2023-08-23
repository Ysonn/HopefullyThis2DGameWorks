using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlueCannonManager: MonoBehaviour
{
    public GameObject cannonBall;
    public GameObject TNT;
    public GameObject blueBarrelEnd;
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
        transform.rotation = Quaternion.Euler(0, 180, rotationZ);

        if (Input.GetKeyDown(KeyCode.RightShift) && canShoot)
        {
            GameObject spawnedCannonBall = Instantiate(cannonBall, blueBarrelEnd.transform.position, transform.rotation);
            rb.AddForce(transform.right * -4.0f , ForceMode2D.Impulse);
            spawnedCannonBall.tag = "BlueCannonBall";
            audioSource.Play();
            StartCoroutine(FireDelay());
        }        

        if (Input.GetKeyDown(KeyCode.RightShift) && canShoot && (PowerUpManager.whoHasPowerUp == 1))
        {
            GameObject spawnedCannonBall = Instantiate(TNT, blueBarrelEnd.transform.position, transform.rotation);
            rb.AddForce(transform.right * 4.0f , ForceMode2D.Impulse);
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
