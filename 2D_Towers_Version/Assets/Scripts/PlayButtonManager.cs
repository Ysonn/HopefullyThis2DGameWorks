using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using TMPro;


public class PlayButtonManager : MonoBehaviour
{
    public TextMeshProUGUI buttonText; 
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (LanguageManager.isSwedish == true)
        {
            ChangeText("Spela");
        }
    }

    public void LoadGameScene()
    {
        SceneManager.LoadScene("Game");  
    }

    public void ChangeText(string newText)
    {
        buttonText.text = "Spela"; 
    }
}


   
