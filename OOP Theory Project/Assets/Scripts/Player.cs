using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : Character
{
    private Rigidbody playerRigidBody;

    // [SerializeField]
    public int life = 20;  // needs get/set

    public bool wasDamaged = false;

    // [SerializeField]
    // private
    public float jumpForce = 9.0f;


    // Start is called before the first frame update
    void Start()
    {
        playerRigidBody = gameObject.GetComponent<Rigidbody>();
    }


    public override void Move() {
        // enable player movement
        float horizontalInput = Input.GetAxis("Horizontal");
        
        transform.Translate(Vector3.right * horizontalInput * moveSpeed * Time.deltaTime);  
    
        Jump();
    }


    public void Jump() {
        if (Input.GetButtonDown("Jump")) { // space or y 
            playerRigidBody.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
        }
    }
}
