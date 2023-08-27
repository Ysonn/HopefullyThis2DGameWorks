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
        //play the win and king dying sounds
        audioSource.PlayOneShot(KingDying);
        audioSource.PlayOneShot(blueWins);
        //change the king to look dead 
        spriteRenderer.sprite = DeadRedKing;
        //let the game know that red has lost and then change to the menu scene.
        redLost = true;
        StartCoroutine(DelayedChangeScene());
    }
    //to reset the game
    IEnumerator DelayedChangeScene()
    {
        // Wait for 3 seconds
        yield return new WaitForSeconds(3.0f);

        // Change to the "MainMenu" scene
        SceneManager.LoadScene("MainMenu");
    }
}
