using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveCannonBall : MonoBehaviour
{
    private Rigidbody2D rb;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        Vector2 force = transform.right * 10.0f;
        rb.AddForce(force, ForceMode2D.Impulse);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
