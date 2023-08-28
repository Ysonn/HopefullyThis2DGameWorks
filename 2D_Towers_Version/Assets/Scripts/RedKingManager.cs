using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RedKingManager : MonoBehaviour
{
    public Sprite DeadRedKing;
<<<<<<< HEAD
    public AudioClip kingDying;
    public AudioClip blueWins;
=======
    public AudioClip KingDying;
>>>>>>> parent of 5e97a28 (adfsghg)
    public static bool redLost = false;
    private AudioSource audioSource;
    private SpriteRenderer spriteRenderer;
    // Start is called before the first frame update
    void Start()
    {
        //being static, a re-declare is needed that redLost is reset when the scene is reloaded
        redLost = false;
        //fetch the audiosource and spriterenderer components to be used later
        audioSource = GetComponent<AudioSource>();
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    //when the king collides with something, execute the following code
    private void OnCollisionEnter2D(Collision2D collision)
    {
        //if the collided object is either an explosion or cannonball, then the king will die.
        if (collision.gameObject.CompareTag("Explosion") || collision.gameObject.CompareTag("BlueCannonBall") || collision.gameObject.CompareTag("RedCannonBall"))
        {
            Die();
        }
        
    } 
    //when the king dies, execute the following code 
    private void Die()
    {
<<<<<<< HEAD
        //play the win and king dying sounds
        audioSource.PlayOneShot(kingDying);
        audioSource.PlayOneShot(blueWins);
        //change the king to look dead 
=======
        audioSource.PlayOneShot(KingDying);
>>>>>>> parent of 5e97a28 (adfsghg)
        spriteRenderer.sprite = DeadRedKing;
        //let the game know that red has lost and then change to the menu scene.
        redLost = true;
<<<<<<< HEAD
        StartCoroutine(DelayedChangeScene());
    }
    //to reset the game
    IEnumerator DelayedChangeScene()
    {
        // Wait for 3 seconds
        yield return new WaitForSeconds(4.0f);

        // Change to the "MainMenu" scene
        SceneManager.LoadScene("MainMenu");
    }
=======
        Destroy(gameObject, 3.0f);
    }
>>>>>>> parent of 5e97a28 (adfsghg)
}
