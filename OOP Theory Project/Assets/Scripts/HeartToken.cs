using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class HeartToken : Token  // INHERITANCE
{
    private int lifeBonus = 5;

    public override void EnhancePlayer() {  // POLYMORPHISM
        PlayerScript.Life += lifeBonus; // add life bonus
        Debug.Log($"life up to {PlayerScript.Life}");
    }

}
