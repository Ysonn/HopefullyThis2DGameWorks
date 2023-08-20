using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TNTManager : MonoBehaviour
{
    
    public AudioClip FuseHissing;
    public AudioClip ExplosionAudio;
    public GameObject ExplosionVisual;
    private AudioSource audioSource;
    private Rigidbody2D TntRigidBody;
    private bool hasExploded = false;

    // Start is called before the first frame update
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
        audioSource.volume = 1f;
        audioSource.clip = FuseHissing;
        audioSource.Play();
        TntRigidBody = GetComponent<Rigidbody2D>();
        Vector2 force = transform.right * 5f;
        TntRigidBody.AddForce(force, ForceMode2D.Impulse);
        TntRigidBody.AddTorque(5.0f, ForceMode2D.Impulse);
    }

    // Update is called once per frame
    void Update()
    {
        if (hasExploded == true)
        {
            Instantiate(ExplosionVisual, transform.position, transform.rotation);
            Destroy(gameObject);
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        audioSource.Stop();
        if (hasExploded == false)
        {
            audioSource.volume = 1f;
            audioSource.PlayOneShot(ExplosionAudio);
            //StartCoroutine(ExplosionDelay());
            hasExploded = true;

        }
        
        
    }

    IEnumerator ExplosionDelay()
    {
        yield return new WaitForSeconds(0.2f);
        hasExploded = true;
    }
}
