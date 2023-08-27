using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TutorialManager : MonoBehaviour
{
    public GameObject[] tutorialImagesEnglish; 
    public GameObject[] tutorialImagesSwedish; 
    private int currentImageEnglish = 0; 
    private int currentImageSwedish = 0; 
    // Start is called before the first frame update
    void Start()
    {
        // Hide all images except the first one
        for (int i = 1; i < tutorialImagesEnglish.Length; i++)
        {
            tutorialImagesEnglish[i].gameObject.SetActive(false);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ShowNextImage()
    {
        if (currentImageEnglish < tutorialImagesEnglish.Length - 1)
        {
            tutorialImagesEnglish[currentImageEnglish].gameObject.SetActive(false);
            currentImageEnglish++;
            tutorialImagesEnglish[currentImageEnglish].gameObject.SetActive(true);
        }
    }

    public void ShowPreviousImage()
    {
        if (currentImageEnglish> 0)
        {
            tutorialImagesEnglish[currentImageEnglish].gameObject.SetActive(false);
            currentImageEnglish--;
            tutorialImagesEnglish[currentImageEnglish].gameObject.SetActive(true);
        }
    }
}
