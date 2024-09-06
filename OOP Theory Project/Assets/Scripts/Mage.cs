using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mage : Player
{
    // Update is called once per frame
    void Update()
    {
        Move(); // inheritance in action

        // Mage's special ability (poly-morph-ism)
        if (wasDamaged) {
            Life++;
            Debug.Log($"Mage restored 1 damage, new life {Life}");
            wasDamaged = false;
        }
    }
}
