using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlueKingManager : MonoBehaviour
{
    public Sprite DeadBlueKing;
    public AudioClip KingDying;
    public Transform circleCenter;
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
        if (collision.gameObject.CompareTag("Grass"))
        {
            audioSource.PlayOneShot(KingDying);
            spriteRenderer.sprite = DeadBlueKing;
            Destroy(gameObject, 3.0f);

        }
        
    } 
}

