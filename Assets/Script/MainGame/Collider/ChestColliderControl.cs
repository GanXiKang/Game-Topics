using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChestColliderControl : MonoBehaviour
{
    int[] boxPoint = new int[3];

    public static bool isOpen1, isOpen2;

    void Start()
    {
        boxPoint[1] = 2;
        boxPoint[2] = 6;        
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "P1" || other.tag == "P2" || other.tag == "P3" || other.tag == "P4")
        {
            if (Dice.P1_totalNum == boxPoint[1] || Dice.P2_totalNum == boxPoint[1] || Dice.P3_totalNum == boxPoint[1] || Dice.P4_totalNum == boxPoint[1])
            {
                StartCoroutine(ChangeCamera());
                isOpen1 = true;
            }
            if (Dice.P1_totalNum == boxPoint[2] || Dice.P2_totalNum == boxPoint[2] || Dice.P3_totalNum == boxPoint[2] || Dice.P4_totalNum == boxPoint[2])
            {
                StartCoroutine(ChangeCamera());
                isOpen2 = true;
            }
        }
    }
    IEnumerator ChangeCamera()
    {
        AnimatorControl.isMove = false;
        yield return new WaitForSeconds(2f);
        ChangeCameraControl.changeCameraNum++;
        Dice.isDiceUI = true;
    }
}
