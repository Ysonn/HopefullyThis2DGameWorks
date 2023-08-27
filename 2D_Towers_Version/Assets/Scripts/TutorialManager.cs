using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class TutorialManager : MonoBehaviour
{
    //sets an array for all the tutorial images 
    public GameObject[] tutorialImages; 
    private int currentImage= 0; 
    // Start is called before the first frame update
    void Start()
    {
        // Hide all images except the first one
        for (int i = 1; i < tutorialImages.Length; i++)
        {
            tutorialImages[i].gameObject.SetActive(false);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    //unhides the next image in the array and hides the previous one, cycling to the next image.
    public void ShowNextImage()
    {
        //if the image isn't the last image
        if (currentImage < tutorialImages.Length - 1)
        {
            tutorialImages[currentImage].gameObject.SetActive(false);
            currentImage++;
            tutorialImages[currentImage].gameObject.SetActive(true);
        }
    }
    //same as previous function, but in reverse
    public void ShowPreviousImage()
    {
        //if the image isn't the first image 
        if (currentImage> 0)
        {
            tutorialImages[currentImage].gameObject.SetActive(false);
            currentImage--;
            tutorialImages[currentImage].gameObject.SetActive(true);
        }
    }
    //changes to the menu scene 
    public void LoadMenuScene()
    {
        SceneManager.LoadScene("MainMenu");
    }
}
