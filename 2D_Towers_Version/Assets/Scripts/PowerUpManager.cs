using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUpManager : MonoBehaviour
{
    public static int whoHasPowerUp = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        

        if (collision.gameObject.CompareTag("BlueCannonBall"))
        {
            whoHasPowerUp = 1;
            Debug.log("Blue has powerUp")
            Destroy(gameObject);
        }

        if (collision.gameObject.CompareTag("RedCannonBall"))
        {
            whoHasPowerUp = 2;
            Debug.log("Red has powerUp")
            Destroy(gameObject);
        }
    }
}
