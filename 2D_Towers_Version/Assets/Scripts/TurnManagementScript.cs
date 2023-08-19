using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurnManagementScript : MonoBehaviour
{
    public static int turnNumber;
    // Start is called before the first frame update
    void Start()
    {
        turnNumber = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            turnNumber += 1;
            Debug.Log (turnNumber);
        }
    }
}
