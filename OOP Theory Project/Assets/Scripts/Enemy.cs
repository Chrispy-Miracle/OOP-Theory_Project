using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Enemy : Character
{
    private int damageDealt = 3;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Move();
    }

    void OnCollisionEnter(Collision collision) {
        if (collision.gameObject.CompareTag("Player")) {
            DoDamage(collision.gameObject, damageDealt);
        }
    }

    void DoDamage(GameObject victim, int damageDealt) {
        Debug.Log($"{damageDealt} Damage was dealt to {victim}");
        // do "damageDealt" to victim 
        // get victim lift
        // victim.life -= damage dealt
    }
}
