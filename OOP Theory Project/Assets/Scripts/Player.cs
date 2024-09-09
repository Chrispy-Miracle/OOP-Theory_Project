using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : Character
{
    private Rigidbody playerRigidBody;

 
    private int m_Life = 20;  // needs get/set
    public int Life {
        get { return m_Life; }
        set { 
            if (value < 1) {
                Debug.Log("Game Over");
            } else if (value > 20) {
                Debug.Log("Error: Player can only have 20 life");
            } else {
                m_Life = value; 
            }
        }
    }
   

    private float m_JumpForce = 9.0f;
    public float JumpForce {
        get { return m_JumpForce; }
        set { 
            if (value < 0 || value > 20) {
                Debug.Log("Error:  JumpForce value is too high or low");
            } else {
                m_JumpForce = value; 
            }
        }
    }

    public bool wasDamaged = false;


    // Start is called before the first frame update
    void Start()
    {
        DeactivateIfNot(gameObject.name); // ensures just one player object
        playerRigidBody = gameObject.GetComponent<Rigidbody>();
    }




    public override void Move() { // polymorphism
        // enable player movement
        HandleHorizontalInput();
        HandleJump();
    }

    // and some abstraction
    void HandleHorizontalInput() {
        float horizontalInput = Input.GetAxis("Horizontal");
        transform.Translate(Vector3.right * horizontalInput * MoveSpeed * Time.deltaTime); 
    }

    public void HandleJump() {
        if (Input.GetButtonDown("Jump")) { // space or y 
            playerRigidBody.AddForce(Vector3.up * m_JumpForce, ForceMode.Impulse);
        }
    }

    public void DeactivateIfNot(string playerType) {
        // if (MainManager.Instance != null) {
            if (MainManager.Instance.playerChoice.name != playerType) {
                gameObject.SetActive(false);
            };            
        // }
    }
}
