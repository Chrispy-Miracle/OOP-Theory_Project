using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Token : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(0, 1.0f, 0);
    }

    void OnTriggerEnter(Collider other) {
        if(other.gameObject.CompareTag("Player")) {
            Debug.Log("token collected");
            EnhancePlayer();
            Destroy(gameObject);            
        }

    }

    void EnhancePlayer() {
        Debug.Log("Enhance player");
    }
}
