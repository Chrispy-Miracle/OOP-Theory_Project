using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RepeatBackground : MonoBehaviour
{

    private Vector3 startPosition;
    private float repeatWidth;
    private float scrollSpeed = 6.0f;

    // Start is called before the first frame update
    void Start()
    {
        startPosition = transform.position;
        repeatWidth = GetComponent<BoxCollider>().size.x / 2;
    }

    // Update is called once per frame
    void Update()
    {
        

        if (transform.position.x < startPosition.x - repeatWidth) {
            transform.position = startPosition;
        }
    }

    void FixedUpdate()  {
        transform.Translate(Vector3.left * scrollSpeed * Time.deltaTime);
    }
}
