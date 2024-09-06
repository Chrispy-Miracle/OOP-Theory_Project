using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rogue : Player
{
    // wasDamaged will be true unless modified some point

    void Awake() {
        JumpForce += 1.5f; // Rogue's special ability
    }

}
