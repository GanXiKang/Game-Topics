using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DiceColliderZoneControl : MonoBehaviour
{
    Vector3 diceVelocity;
    float diceNumber = 0;
    
    void FixedUpdate()
    {
        diceVelocity = DiceControl.diceVelocity;

        if (DiceControl.isThrow == true)
        {
            this.gameObject.SetActive(true);
        }
    }
    private void OnTriggerStay(Collider other)
    {
        if (diceVelocity.x == 0 && diceVelocity.y == 0 && diceVelocity.z == 0)
        {
            switch (other.tag)
            {
                case "Dice1":
                    diceNumber = 1;
                    break;
                case "Dice2":
                    diceNumber = 2;
                    break;
                case "Dice3":
                    diceNumber = 3;
                    break;
                case "Dice4":
                    diceNumber = 4;
                    break;
                case "Dice5":
                    diceNumber = 5;
                    break;
                case "Dice6":
                    diceNumber = 6;
                    break;
            }
            print(diceNumber);
            DiceControl.isThrow = false;
        }
    }
}
