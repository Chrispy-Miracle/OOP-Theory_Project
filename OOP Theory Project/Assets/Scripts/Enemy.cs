using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : Character  // INHERITANCE
{
    private int m_DamageDealt = 3; // ENCAPSULATION
    public int DamageDealt {
        // manually created getter with conditional setter format
        get { return m_DamageDealt; } 
        set { 
            if (value < 1 || value > 10) {
                Debug.Log("Error: DamageDealt too high or low");
            } else {
                m_DamageDealt = value; 
            }
        }
    }


    void OnCollisionEnter(Collision collision) {
        // damgage player upon collision
        if (collision.gameObject.CompareTag("Player")) {
            DoDamage(collision.gameObject, m_DamageDealt);
        }
    }

    void DoDamage(GameObject victim, int damageDealt) {  // ABSTRACTION
        Player playerScript = victim.GetComponent<Player>();

        playerScript.Life -= damageDealt;
        playerScript.wasDamaged = true;

        Debug.Log($"{damageDealt} Damage was dealt to {victim}, player life: {playerScript.Life}");
    }
}
