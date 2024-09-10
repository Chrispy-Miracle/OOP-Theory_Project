using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StarToken : Token
{
    private float speedBonus = 2.5f;

    public override void EnhancePlayer() {
        PlayerScript.MoveSpeed += speedBonus; // add speed bonus
        Invoke(nameof(RemoveSpeedBonus), 3);
        Debug.Log("bonus on");
    }

    void RemoveSpeedBonus() {
        PlayerScript.MoveSpeed -= speedBonus; // remove speed bonus
        Debug.Log("bonus off");
    }
}
