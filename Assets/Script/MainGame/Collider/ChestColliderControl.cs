using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChestColliderControl : MonoBehaviour
{
    public int boxPoint, isOpenNumber;

    public static bool isOpen1, isOpen2;
    public static int whoReward;

    void OpenBoxJudge()
    {
        switch (isOpenNumber)
        {
            case 1:
                isOpen1 = true;
                break;

            case 2:
                isOpen2 = true;
                break;
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "P1")
        {
            if (DiceControl.P1_totalNum == boxPoint)
            {
                whoReward = 1;
                StartCoroutine(ChangeCamera());
            }
        }
        else if (other.tag == "P2")
        {
            if (DiceControl.P2_totalNum == boxPoint)
            {
                whoReward = 2;
                StartCoroutine(ChangeCamera());
            }
        }
        else if (other.tag == "P3")
        {
            if (DiceControl.P3_totalNum == boxPoint)
            {
                whoReward = 3;
                StartCoroutine(ChangeCamera());
            }
        }
        else if (other.tag == "P4")
        {
            if (DiceControl.P4_totalNum == boxPoint)
            {
                whoReward = 4;
                StartCoroutine(ChangeCamera());
            }
        }
    }
    IEnumerator ChangeCamera()
    {
        OpenBoxJudge();
        yield return new WaitForSeconds(2f);
        ChangeCameraControl.changeCameraNum++;
        Dice.isDiceUI = true;
    }
}
