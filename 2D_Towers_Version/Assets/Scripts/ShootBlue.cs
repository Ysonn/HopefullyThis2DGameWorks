using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootBlue : MonoBehaviour
{
    public AimBarrel AimBarrel;
    public GameObject cannonBall;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && (AimBarrel.personShooting % 2 == 0))
        {
            Instantiate(cannonBall,transform.position, transform.rotation);
        }
    }
}
