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
        if (Input.GetKeyDown(KeyCode.Space) && (personShooting % 2 == 1))
        {
            Instantiate(cannonBall, redBarrelEnd.transform.position, Quaternion.identity);
            Debug.Log("Red shot first!");
            personShooting += 1;
            moveCannonBall("red");
        }

        if (Input.GetKeyDown(KeyCode.Space) && (personShooting % 2 == 0))
        {
            Instantiate(cannonBall, blueBarrelEnd.transform.position, transform.rotation);
            Debug.Log("Blue shot first!");
            personShooting += 1;
            moveCannonBall("blue");
        }
    }

    void moveCannonBall(string colour)
    {
        if (colour == "red")
        {
            cannonBallRigidBody = GetComponent<Rigidbody2D>();
            Vector2 force = transform.right * 7.0f;
            cannonBallRigidBody.AddForce(force, ForceMode2D.Impulse);
        }
        else
        {
            cannonBallRigidBody = GetComponent<Rigidbody2D>();
            Vector2 force = -transform.right * 7.0f;
            cannonBallRigidBody.AddForce(force, ForceMode2D.Impulse);
        }
    }
}
