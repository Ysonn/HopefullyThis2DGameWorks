using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WinTextManager : MonoBehaviour
{
    public GameObject blueWinText;
    public GameObject redWinText;
    private bool redWinTextSpawned = false; 
    private bool blueWinTextSpawned = false; // Flag to track if redWinText has been spawned

    // Update is called once per frame
    void Update()
    {
        if (BlueKingManager.blueLost == true && !blueWinTextSpawned)
        {
            Instantiate(redWinText, transform.position, transform.rotation);
            redWinTextSpawned = true;  // Set the flag to true to prevent further spawning 
        }

        if (RedKingManager.redLost == true && !redWinTextSpawned)
        {
            Instantiate(blueWinText, transform.position, transform.rotation);
            blueWinTextSpawned = true;  // Set the flag to true to prevent further spawning
        }
    }
}
