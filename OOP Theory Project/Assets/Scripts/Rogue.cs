using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rogue : Player
{
    // wasDamaged will be true unless modified some point

    void Awake() {
        // deactivate if not chosen player
        if (MainManager.Instance.playerChoice.name != "Rogue") {
            gameObject.SetActive(false);
        };

        jumpForce += 1.5f; // Rogue's special ability
    }

}
