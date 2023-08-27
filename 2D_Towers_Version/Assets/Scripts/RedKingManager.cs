using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RedKingManager : MonoBehaviour
{
    public Sprite DeadRedKing;
    public AudioClip KingDying;
    public AudioClip blueWins;
    public static bool redLost = false;
    private AudioSource audioSource;
    private SpriteRenderer spriteRenderer;
    // Start is called before the first frame update
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        
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
        audioSource.PlayOneShot(blueWins);
        spriteRenderer.sprite = DeadRedKing;
        redLost = true;
        StartCoroutine(DelayedChangeScene());
        Destroy(gameObject, 3.0f);
    }

    IEnumerator DelayedChangeScene()
    {
        // Wait for 5 seconds
        yield return new WaitForSeconds(5.0f);

        // Change to the "MainMenu" scene
        SceneManager.LoadScene("MainMenu");
    }
}
