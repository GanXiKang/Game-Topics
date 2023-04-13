using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChestColliderControl : MonoBehaviour
{
    int a;
    public static bool isOpen1, isOpen2;

    void Award()
    {
        a = Random.Range(1, 11);
        switch (a)
        {
            case 1:
            case 2:
            case 3:
            case 4:
                print("獲得10個貓貓幣！");
                break;
            case 5:
            case 6:
                print("獲得20個貓貓幣！");
                break;
            case 7:
            case 8:
                print("獲得30個貓貓幣！");
                break;
            case 9:
                print("獲得一個道具！");
                break;
            case 10:
                print("空！");
                break;
        }
        Destroy(this.gameObject, 2f);
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "P1" || other.tag == "P2" || other.tag == "P3" || other.tag == "P4")
        {
            if (Dice.P1_totalNum == 2 || Dice.P2_totalNum == 2 || Dice.P3_totalNum == 2 || Dice.P4_totalNum == 2)
            {
                isOpen1 = true;
                Award();
            }
            if (Dice.P1_totalNum == 1 || Dice.P2_totalNum == 1 || Dice.P3_totalNum == 1 || Dice.P4_totalNum == 1)
            {
                isOpen2 = true;
                Award();
            }
        }
    }
}
