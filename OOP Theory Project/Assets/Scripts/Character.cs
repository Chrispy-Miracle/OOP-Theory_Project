using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Timeline;

public class Character : MonoBehaviour
{
    public float moveSpeed = 3.0f; // needs get/set


    // Update is called once per frame
    void Update()
    {
        Move();
    }

    // basic movement is for enemies, because most characters will be enemies
    public virtual void Move() {
        transform.Translate(Vector3.left * moveSpeed * Time.deltaTime);
    }
}
