using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DiceColliderZoneControl : MonoBehaviour
{
    public static float diceNumber = 0;
    Vector3 diceVelocity;

    void FixedUpdate()
    {
        diceVelocity = DiceControl.diceVelocity;
    }
    private void OnTriggerStay(Collider other)
    {
        if (diceVelocity.x == 0 && diceVelocity.y == 0 && diceVelocity.z == 0)
        {
            switch (other.tag)
            {
                case "Dice1":
                    diceNumber = 6;
                    break;
                case "Dice2":
                    diceNumber = 5;
                    break;
                case "Dice3":
                    diceNumber = 4;
                    break;
                case "Dice4":
                    diceNumber = 3;
                    break;
                case "Dice5":
                    diceNumber = 2;
                    break;
                case "Dice6":
                    diceNumber = 1;
                    break;
            }
        }
    }
}
