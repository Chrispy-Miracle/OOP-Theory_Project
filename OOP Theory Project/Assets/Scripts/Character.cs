using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Timeline;

public class Character : MonoBehaviour
{
    private float m_MoveSpeed = 3.0f; // backing field (encapsulation)
    public float MoveSpeed {
        // manually created getter with conditional setter format
        get { return m_MoveSpeed; } 
        set { 
            if (value < 1 || value > 10) {
                Debug.Log("Error: Move speed too high or low");
            } else {
                m_MoveSpeed = value; 
            }
        }
    }


    // Update is called once per frame
    void Update()
    {
        Move();
    }

    // basic movement is for enemies, because most characters will be enemies
    public virtual void Move() {
        transform.Translate(Vector3.left * m_MoveSpeed * Time.deltaTime);
    }
}
