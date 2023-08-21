using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TNTManager : MonoBehaviour
{
    
    public AudioClip FuseHissing;
    public AudioClip ExplosionAudio;
    public GameObject ExplosionVisual;
    public GameObject ExplosionHitBox;
    public float explosionForce = 5.0f;
    public float fieldOfImpact = 5.0f;
    private AudioSource audioSource;
    private Rigidbody2D TntRigidBody;
    private bool hasExploded = false;

    // Start is called before the first frame update
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
        audioSource.clip = FuseHissing;
        audioSource.Play();
        TntRigidBody = GetComponent<Rigidbody2D>();
        Vector2 force = transform.right * 5f;
        TntRigidBody.AddForce(force, ForceMode2D.Impulse);
        TntRigidBody.AddTorque(20.0f, ForceMode2D.Impulse);
    }

    // Update is called once per frame
    void Update()
    {
        if (hasExploded == true)
        {
            Instantiate(ExplosionVisual, transform.position, transform.rotation);
            Instantiate(ExplosionVisual, transform.position, transform.rotation);
            Destroy(gameObject);
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        audioSource.Stop();
        Explosion();
        hasExploded = true;
    }

    private void Explosion()
    {
        Collider2D[] colliders = Physics2D.OverlapCircleAll(transform.position, fieldOfImpact);
        foreach (Collider2D target in colliders)
        {
            Rigidbody2D rb = target.GetComponent<Rigidbody2D>(); 
            if (rb != null)
            {
                Vector2 explosionDirection = rb.transform.position - transform.position;
                float distance = explosionDirection.magnitude;

                // Calculate explosion force based on distance
                float explosionForceMagnitude = explosionForce / (distance + 1); // Adding 1 to prevent division by zero

                // Apply the explosion force
                rb.AddForce(explosionDirection.normalized * explosionForceMagnitude, ForceMode2D.Impulse);
            }
        }   
    
    }
}
