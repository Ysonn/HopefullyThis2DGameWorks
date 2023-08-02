using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootCannonBall : MonoBehaviour
{
    public GameObject cannonBall;
    // Start is called before the first frame update
    void Start()
    {
        Instantiate(cannonBall,transform.position, transform.rotation);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
