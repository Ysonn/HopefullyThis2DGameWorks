using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveCannonBall : MonoBehaviour
{
    public AudioClip WoodImpact;
    public AudioClip Whistle;
    private Rigidbody2D cannonBallRigidBody2D;
    private AudioSource audioSource;
    private bool hasCollided = false; 
    // Start is called before the first frame update
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
        audioSource.clip = Whistle;
        audioSource.Play();
        cannonBallRigidBody2D = GetComponent<Rigidbody2D>();
        Vector2 force = transform.right * 1.5f;
        cannonBallRigidBody2D.AddForce(force, ForceMode2D.Impulse);
    }

    // Update is called once per frame
    void Update()
    {
       
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Wood") && !hasCollided)
        {
            hasCollided = true;
            audioSource.Stop();
            audioSource.PlayOneShot(WoodImpact);
        }
    }
}