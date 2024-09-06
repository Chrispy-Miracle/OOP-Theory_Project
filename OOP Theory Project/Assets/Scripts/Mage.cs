using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mage : Player
{
    // Update is called once per frame
    void Update()
    {
        Move();

        // Mage's special ability
        if (wasDamaged) {
            life++;
            Debug.Log($"Mage restored 1 damage, new life {life}");
            wasDamaged = false;
        }
    }
}
