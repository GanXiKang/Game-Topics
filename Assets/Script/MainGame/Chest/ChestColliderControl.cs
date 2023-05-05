using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChestColliderControl : MonoBehaviour
{

    int a;
    int[] boxPoint = new int[3];
    public static bool isOpen1, isOpen2;

    void Start()
    {
        boxPoint[1] = 2;
        boxPoint[2] = 6;
    }
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
            if (Dice.P1_totalNum == boxPoint[1] || Dice.P2_totalNum == boxPoint[1] || Dice.P3_totalNum == boxPoint[1] || Dice.P4_totalNum == boxPoint[1])
            {
                isOpen1 = true;
                Award();
            }
            if (Dice.P1_totalNum == boxPoint[2] || Dice.P2_totalNum == boxPoint[2] || Dice.P3_totalNum == boxPoint[2] || Dice.P4_totalNum == boxPoint[2])
            {
                isOpen2 = true;
                Award();
            }
        }
    }
}
