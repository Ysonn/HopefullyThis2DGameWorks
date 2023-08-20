using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KingManager : MonoBehaviour
{
    public AudioClip KingDying;
    public Rigidbody2D BlueKingRigidbody;
    public Rigidbody2D RedKingRigidbody;
    private AudioSource audioSource;
    
    // Start is called before the first frame update
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.x > -0.13f || transform.position.x < -7.06f)
        {
            audioSource.PlayOneShot(KingDying);
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Grass"))
        {
            audioSource.PlayOneShot(KingDying);
        }
        
    } 
}
