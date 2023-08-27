using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RedKingManager : MonoBehaviour
{
    public Sprite DeadRedKing;
    public AudioClip KingDying;
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
            audioSource.PlayOneShot(KingDying);
            spriteRenderer.sprite = DeadRedKing;
            redLost = true;
            Destroy(gameObject, 3.0f);
        }
        
    } 
}
