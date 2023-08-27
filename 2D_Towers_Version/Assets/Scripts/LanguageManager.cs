using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;

public class LanguageManager : MonoBehaviour
{
    public Button swedishButton;  // Reference to the Swedish language button
    public Button englishButton;  // Reference to the English language button

    public static bool isSwedish = false;  // Public static variable for language

    private void Start()
    {
        // Add listeners to the buttons to handle button clicks
        swedishButton.onClick.AddListener(SetSwedish);
        englishButton.onClick.AddListener(SetEnglish);
    }

    private void SetSwedish()
    {
        isSwedish = true;
    }

    private void SetEnglish()
    {
        isSwedish = false;
    }
}




