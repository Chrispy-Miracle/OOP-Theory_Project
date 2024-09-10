using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rogue : Player  // INHERITANCE
{
    // note: Rogue.wasDamaged will be true after hit unless modified some point

    void Awake() {
        JumpForce += 1.5f; // Rogue's special ability
    }
}
