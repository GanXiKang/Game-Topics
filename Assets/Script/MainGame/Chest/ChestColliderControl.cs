using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChestColliderControl : MonoBehaviour
{
    int a, box1Point = 2, box2Point = 6;
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
                print("�@��10��؈؈�ţ�");
                break;
            case 5:
            case 6:
                print("�@��20��؈؈�ţ�");
                break;
            case 7:
            case 8:
                print("�@��30��؈؈�ţ�");
                break;
            case 9:
                print("�@��һ�����ߣ�");
                break;
            case 10:
                print("�գ�");
                break;
        }
        Destroy(this.gameObject, 2f);
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "P1" || other.tag == "P2" || other.tag == "P3" || other.tag == "P4")
        { 
            if (Dice.P1_totalNum == box1Point || Dice.P2_totalNum == box1Point || Dice.P3_totalNum == box1Point || Dice.P4_totalNum == box1Point)
            {
                isOpen1 = true;
                Award();
            }
            if (Dice.P1_totalNum == box2Point || Dice.P2_totalNum == box2Point || Dice.P3_totalNum == box2Point || Dice.P4_totalNum == box2Point)
            {
                isOpen2 = true;
                Award();
            }
        }
    }
}
