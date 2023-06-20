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
            AnimatorControl.isP1Move = false;
            if (Dice.P1_totalNum == boxPoint)
            {
                StartCoroutine(ChangeCamera());
            }
        }
        else if (other.tag == "P2")
        {
            AnimatorControl.isP2Move = false;
            if (Dice.P2_totalNum == boxPoint)
            {
                StartCoroutine(ChangeCamera());
            }
        }
        else if (other.tag == "P3")
        {
            AnimatorControl.isP3Move = false;
            if (Dice.P3_totalNum == boxPoint)
            {
                StartCoroutine(ChangeCamera());
            }
        }
        else if (other.tag == "P4")
        {
            AnimatorControl.isP4Move = false;
            if (Dice.P4_totalNum == boxPoint)
            {
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
