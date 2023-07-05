using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChestColliderControl : MonoBehaviour
{
    public int boxPoint, isOpenNumber;

    public static bool isOpen1, isOpen2;

    void OpenBoxJudge()
    {
        if (isOpenNumber == 1)
        {
            isOpen1 = true;
        }
        else if (isOpenNumber == 2)
        {
            isOpen2 = true;
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "P1")
        {
            if (DiceControl.P1_totalNum == boxPoint)
            {
                AnimatorControl.isP1Move = false;
                StartCoroutine(ChangeCamera());
            }
        }
        else if (other.tag == "P2")
        {
            if (DiceControl.P2_totalNum == boxPoint)
            {
                AnimatorControl.isP2Move = false;
                StartCoroutine(ChangeCamera());
            }
        }
        else if (other.tag == "P3")
        {
            if (DiceControl.P3_totalNum == boxPoint)
            {
                AnimatorControl.isP3Move = false;
                StartCoroutine(ChangeCamera());
            }
        }
        else if (other.tag == "P4")
        {
            if (DiceControl.P4_totalNum == boxPoint)
            {
                AnimatorControl.isP4Move = false;
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
