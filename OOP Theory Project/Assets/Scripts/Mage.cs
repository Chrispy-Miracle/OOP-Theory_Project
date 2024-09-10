using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mage : Player  // INHERITANCE
{
    // Update is called once per frame
    void Update()
    {
        Move(); 

        // POLYMORPHISM
        if (wasDamaged) {
            Life++;// Mage's special ability
            Debug.Log($"Mage restored 1 damage, new life {Life}");
            wasDamaged = false;
        }
    }
}
