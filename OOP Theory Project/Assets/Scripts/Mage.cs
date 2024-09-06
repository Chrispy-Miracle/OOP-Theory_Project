using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mage : Player
{

    void Awake() {
        // deactivate if not chosen player
        if (MainManager.Instance.playerChoice.name != "Mage") {
            gameObject.SetActive(false);
        };
    }
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
