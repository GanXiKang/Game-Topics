using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DiceColliderZoneControl : MonoBehaviour
{
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
                    print("6");
                    break;
                case "Dice2":
                    print("5");
                    break;
                case "Dice3":
                    print("4");
                    break;
                case "Dice4":
                    print("3");
                    break;
                case "Dice5":
                    print("2");
                    break;
                case "Dice6":
                    print("1");
                    break;
            }
        }
    }
}
