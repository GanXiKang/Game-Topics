using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DiceColliderZoneControl : MonoBehaviour
{
    Vector3 diceVelocity;
    float diceNumber = 0;

    public static float totalNum = 0;
    
    void FixedUpdate()
    {
        diceVelocity = DiceControl.diceVelocity;

        if (DiceControl.isThrow == true)
        {
            Debug.Log("Open");
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
                    diceNumber = 6;
                    gameObject.SetActive(false);
                    break;
                case "Dice2":
                    diceNumber = 5;
                    gameObject.SetActive(false);
                    break;
                case "Dice3":
                    diceNumber = 4;
                    gameObject.SetActive(false);
                    break;
                case "Dice4":
                    diceNumber = 3;
                    gameObject.SetActive(false);
                    break;
                case "Dice5":
                    diceNumber = 2;
                    gameObject.SetActive(false);
                    break;
                case "Dice6":
                    diceNumber = 1;
                    gameObject.SetActive(false);
                    break;
            }
            print(diceNumber);
            totalNum += diceNumber;
            print(totalNum);
            this.gameObject.SetActive(false);
            DiceControl.isThrow = false;
        }
    }
}
