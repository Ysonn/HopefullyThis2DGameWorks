using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using TMPro;

public class MenuButtonManager : MonoBehaviour
{
    public TextMeshProUGUI playButtonText; 
    public TextMeshProUGUI exitButtonText; 
    public TextMeshProUGUI tutorialButtonText; 
    public Button swedishButton; 
    public Button englishButton;
    public Button playButton;
    public Button tutorialButton;
    public Button exitButton;
    public static bool isSwedish = false;
    // Start is called before the first frame update
    void Start()
    {
        swedishButton.onClick.AddListener(SetSwedish);
        englishButton.onClick.AddListener(SetEnglish);
        playButton.onClick.AddListener(LoadGameScene);
        tutorialButton.onClick.AddListener(LoadTutorialScene);
        exitButton.onClick.AddListener(ExitGame);
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    public void LoadGameScene()
    {
        SceneManager.LoadScene("Game");  
    }

    public void LoadTutorialScene()
    {
        SceneManager.LoadScene("Tutorial");
    }

    private void SetSwedish()
    {
        MakeTextSwedish();
    }

    private void SetEnglish()
    {
        MakeTextEnglish();
    }

    private void ExitGame()
    {
        Application.Quit();
    }

    public void MakeTextSwedish()
    {
        playButtonText.text = "Spela"; 
        exitButtonText.text = "Avsluta";
        tutorialButtonText.text = "Instruktioner";
        isSwedish = true;

    }
    public void MakeTextEnglish()
    {
        playButtonText.text = "Play"; 
        exitButtonText.text = "Exit";
        tutorialButtonText.text = "Tutorial";
        isSwedish = false;
    }


}
