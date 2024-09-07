using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Token : MonoBehaviour
{
    public Player PlayerScript { get; private set; }
    private float destroyDelay = 5.0f;


    // Update is called once per frame
    void Update()
    {
        transform.Rotate(0, 1.0f, 0);
    }

    void OnTriggerEnter(Collider other) {
        if(other.gameObject.CompareTag("Player")) {
            PlayerScript = other.gameObject.GetComponent<Player>();
            
            EnhancePlayer();
            gameObject.SetActive(false);
            Destroy(gameObject, destroyDelay);            
        }
    }

    public virtual void EnhancePlayer() {
        Debug.Log("Enhance player");
    }
}
