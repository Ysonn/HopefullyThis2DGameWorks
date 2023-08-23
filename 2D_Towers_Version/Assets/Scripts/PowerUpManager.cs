using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUpManager : MonoBehaviour
{
    public static whoHasPowerUp = 0;
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
        Destroy(gameObject);

        if (collision.gameObject.CompareTag("BlueCannonBall"))
        {
`           whoHasPowerUp = 2;
        }

        if (collision.gameObject.CompareTag("RedCannonBall"))
        {
            whoHasPowerUp = 1;
        }
    }
}
