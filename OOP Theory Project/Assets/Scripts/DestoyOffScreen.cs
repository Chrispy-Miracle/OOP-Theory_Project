using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestoyOffScreen : MonoBehaviour
{
    private float leftBound = -18.0f;
    private float lowerBound = -2.0f;

    // Update is called once per frame
    void Update()
    {
        if (transform.position.x < leftBound || transform.position.y < lowerBound) {
            gameObject.SetActive(false);
            Destroy(gameObject, 3);
        }
    }
}
