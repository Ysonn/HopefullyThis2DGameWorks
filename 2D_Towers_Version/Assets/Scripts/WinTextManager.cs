using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WinTextManager : MonoBehaviour
{
    public GameObject blueWinText;
    public GameObject redWinText;
    private bool redWinTextSpawned = false; 
    private bool blueWinTextSpawned = false; //var to track if redWinText has been spawned

    // Update is called once per frame
    void Update()
    {
        //if blue has lost, and no text has been spawned already 
        if (BlueKingManager.blueLost == true && !redWinTextSpawned)
        {
            Instantiate(redWinText, transform.position, transform.rotation);
            redWinTextSpawned = true;  //let the script know that a  to true to prevent further spawning 
        }

        if (RedKingManager.redLost == true && !blueWinTextSpawned)
        {
            Instantiate(blueWinText, transform.position, transform.rotation);
            blueWinTextSpawned = true;  // Set the flag to true to prevent further spawning
        }
    }
}
