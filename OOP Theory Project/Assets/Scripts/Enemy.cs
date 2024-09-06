using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : Character
{
    public int damageDealt = 3; // needs get/set ?


    void OnCollisionEnter(Collision collision) {
        if (collision.gameObject.CompareTag("Player")) {
            DoDamage(collision.gameObject, damageDealt);
        }
    }

    void DoDamage(GameObject victim, int damageDealt) {
        Debug.Log($"{damageDealt} Damage was dealt to {victim}");
        // do "damageDealt" to victim 
        Player playerScript = victim.GetComponent<Player>();
        playerScript.life -= damageDealt;
        playerScript.wasDamaged = true; 
        Debug.Log($"player life: {playerScript.life}");
    }
}
