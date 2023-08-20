using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CannonBallManager : MonoBehaviour
{
    public GameObject GrassParticles;
    public AudioClip WoodImpact;
    public AudioClip Whistle;
    public AudioClip MetalImpact;
    public AudioClip GrassImpact;
    private Rigidbody2D cannonBallRigidBody2D;
    private AudioSource audioSource;
    private bool hasCollided = false; 
    // Start is called before the first frame update
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
        audioSource.volume = 0.1f; 
        audioSource.clip = Whistle;
        audioSource.Play();
        cannonBallRigidBody2D = GetComponent<Rigidbody2D>();
        Vector2 force = transform.right * 5f;
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
            audioSource.volume = 0.6f;
            audioSource.PlayOneShot(WoodImpact);
        }

        else if (collision.gameObject.CompareTag("Metal") && !hasCollided)
        {
            hasCollided = true;
            audioSource.Stop();
            audioSource.volume = 0.8f;
            audioSource.PlayOneShot(MetalImpact);
        }

        else if (collision.gameObject.CompareTag("Grass") && !hasCollided)
        {
            hasCollided = true;
            audioSource.Stop();
            audioSource.volume = 0.5f;
            audioSource.PlayOneShot(GrassImpact);
            Instantiate(GrassParticles, transform.position, transform.rotation);
            
        }
    }
}