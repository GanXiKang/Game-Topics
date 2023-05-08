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
        if (other.tag == "P1" || other.tag == "P2" || other.tag == "P3" || other.tag == "P4")
        {
            if (Dice.P1_totalNum == boxPoint || Dice.P2_totalNum == boxPoint || Dice.P3_totalNum == boxPoint || Dice.P4_totalNum == boxPoint)
            {
                StartCoroutine(ChangeCamera());
            }
        }
    }
    IEnumerator ChangeCamera()
    {
        OpenBoxJudge();
        AnimatorControl.isMove = false;
        yield return new WaitForSeconds(2f);
        ChangeCameraControl.changeCameraNum++;
        Dice.isDiceUI = true;
    }
}
