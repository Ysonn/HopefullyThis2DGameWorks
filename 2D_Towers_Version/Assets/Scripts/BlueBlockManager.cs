using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlueBlockManager : MonoBehaviour
{
    private AudioSource audioSource;
    private SpriteRenderer spriteRenderer;
    public Sprite CrackedBlueBlock;
    public AudioClip WoodCracking;
    public AudioClip WoodBreaking;
    private int blockHealth = 2;
    // Start is called before the first frame update
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        if (blockHealth == 0)
        {
            audioSource.PlayOneShot(WoodBreaking);
            Destroy(gameObject);
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("CannonBall") || collision.gameObject.CompareTag("Explosion"))
        {
            blockHealth -= 1;
            spriteRenderer.sprite = CrackedBlueBlock;
            audioSource.PlayOneShot(WoodCracking);

        }
    }
}
