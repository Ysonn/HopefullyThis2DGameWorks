using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UISoundManager : MonoBehaviour
{
    public AudioClip buttonSound;  // Reference to your audio clip
    private Button button;          // Reference to the button component
    private AudioSource audioSource;
    // Start is called before the first frame update
    void Start()
    {
        button = GetComponent<Button>();
        audioSource = GetComponent<AudioSource>();
        button.onClick.AddListener(PlayButtonSound);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void PlayButtonSound()
    {
        audioSource.Play();  // Play the sound when the button is clicked
    }
}
