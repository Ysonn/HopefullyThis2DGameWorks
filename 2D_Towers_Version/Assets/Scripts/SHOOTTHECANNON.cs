using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SHOOTTHECANNON : MonoBehaviour
{
    public int personShooting;
    public Rigidbody2D cannonBallRigidBody;
    public GameObject cannonBall;
    public GameObject blueBarrelEnd;
    public GameObject redBarrelEnd; 

    // Start is called before the first frame update
    void Start()
    {
        personShooting = Random.Range(0, 2);
    }

    // Update is called once per frame
    void Update()
    {
        
    }


}
