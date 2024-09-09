using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveLeft : MonoBehaviour
{
    private float scrollSpeed = 6.0f;

    void FixedUpdate()
    {
        transform.Translate(Vector3.left * scrollSpeed * Time.deltaTime);
    }
}
