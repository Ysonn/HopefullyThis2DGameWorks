using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class TutorialManager : MonoBehaviour
{
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

    public void ShowNextImage()
    {
        if (currentImage < tutorialImages.Length - 1)
        {
            tutorialImages[currentImage].gameObject.SetActive(false);
            currentImage++;
            tutorialImages[currentImage].gameObject.SetActive(true);
        }
    }

    public void ShowPreviousImage()
    {
        if (currentImage> 0)
        {
            tutorialImages[currentImage].gameObject.SetActive(false);
            currentImage--;
            tutorialImages[currentImage].gameObject.SetActive(true);
        }
    }

    private void LoadMenuScene()
    {
        SceneManager.LoadScene("MainMenu");
    }
}
