using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TilingSkyBackground : MonoBehaviour
{
    private Vector2 startPosition;
    private float repeatWidth;

    // Start is called before the first frame update
    void Start()
    {
        startPosition = transform.position;
        // Use the sprite renderer's bounds to calculate repeatWidth
        repeatWidth = GetComponent<SpriteRenderer>().bounds.size.x / 2;
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector2.left * Time.deltaTime * 0.75f);

        if (transform.position.x < startPosition.x - repeatWidth)
        {
            // Move the background forward by repeatWidth to ensure smooth looping
            transform.position = new Vector2(startPosition.x, transform.position.y);
        }
    }
}