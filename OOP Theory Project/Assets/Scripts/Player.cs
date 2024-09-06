using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : Character
{
    private Rigidbody playerRigidBody;

    [SerializeField]
    private int life = 20;  // needs get/set

    // [SerializeField]
    // private
    public float jumpForce = 150.0f;

    // Start is called before the first frame update
    void Start()
    {
        playerRigidBody = gameObject.GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        Move();
    }

    public override void Move() {
        // enable player movement
        float horizontalInput = Input.GetAxis("Horizontal");
        
        transform.Translate(Vector3.right * horizontalInput * moveSpeed * Time.deltaTime);  
    
        if (Input.GetButtonDown("Jump")) { // space or y 
            


            playerRigidBody.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
        }
    }
}
