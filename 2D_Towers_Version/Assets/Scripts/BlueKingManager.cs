using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlueKingManager : MonoBehaviour
{
    public Sprite DeadBlueKing;
    public AudioClip KingDying;
    public Transform ExplosionHitBoxCenter;
    public float ExplosionHitBoxRadius;
    public static bool blueLost = false;
    private AudioSource audioSource;
    private SpriteRenderer spriteRenderer;
    // Start is called before the first frame update
    void Start()
    {
        blueLost = false;
        audioSource = GetComponent<AudioSource>();
        spriteRenderer = GetComponent<SpriteRenderer>();
    }
    
    // Update is called once per frame
    void Update()
    {
        float distance = Vector2.Distance(transform.position, ExplosionHitBoxCenter.position);

        if (distance <= ExplosionHitBoxRadius)
        {
            Die();
        }


    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Explosion") || collision.gameObject.CompareTag("BlueCannonBall") || collision.gameObject.CompareTag("RedCannonBall"))
        {
            Die();
        }
        
    } 

    private void Die()
    {
        audioSource.PlayOneShot(KingDying);
        spriteRenderer.sprite = DeadBlueKing;
        blueLost = true;
<<<<<<< HEAD
        StartCoroutine(DelayedChangeScene());
    }

    IEnumerator DelayedChangeScene()
    {
        // Wait for 5 seconds
        yield return new WaitForSeconds(4.0f);

        // Change to the "MainMenu" scene
        SceneManager.LoadScene("MainMenu");
    }
=======
        Destroy(gameObject, 3.0f);
    }
>>>>>>> parent of 5e97a28 (adfsghg)
}

