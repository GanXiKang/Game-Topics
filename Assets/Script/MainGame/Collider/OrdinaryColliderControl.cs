using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OrdinaryColliderControl : MonoBehaviour
{
    public static bool P1_Enter = true, P2_Enter = true, P3_Enter = true, P4_Enter = true;
    public int pointNum;

    private void OnTriggerEnter(Collider other)
    {
        if (!PropsControl.isTrans)
        {
            PowerUIControl.isMouseCanUsePower = false;
            if (other.tag == "P1" && P1_Enter)
            {
                if (DiceControl.P1_totalNum == pointNum)
                {
                    P1_Enter = false;
                    AnimatorControl.isP1Move = false;
                    StartCoroutine(ChangeCamera());
                }
            }
            else if (other.tag == "P2" && P2_Enter)
            {
                if (DiceControl.P2_totalNum == pointNum)
                {
                    P2_Enter = false;
                    AnimatorControl.isP2Move = false;
                    StartCoroutine(ChangeCamera());
                }
            }
            else if (other.tag == "P3" && P3_Enter)
            {
                if (DiceControl.P3_totalNum == pointNum)
                {
                    P3_Enter = false;
                    AnimatorControl.isP3Move = false;
                    StartCoroutine(ChangeCamera());
                }
            }
            else if (other.tag == "P4" && P4_Enter)
            {
                if (DiceControl.P4_totalNum == pointNum)
                {
                    P4_Enter = false;
                    AnimatorControl.isP4Move = false;
                    StartCoroutine(ChangeCamera());
                }
            }
        }
        else
        {
            StartCoroutine(Transposition());
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "P1")
        {
            P1_Enter = true;
        }
        if (other.tag == "P2")
        {
            P2_Enter = true;
        }
        if (other.tag == "P3")
        {
            P3_Enter = true;
        }
        if (other.tag == "P4")
        {
            P4_Enter = true;
        }
    }
    IEnumerator ChangeCamera()
    {
        yield return new WaitForSeconds(1f);
        ChangeCameraControl.changeCameraNum++;
        DiceUIControl.isDiceUI = true;
    }
    IEnumerator Transposition()
    {
        yield return new WaitForSeconds(1f);
        PropsControl.isTrans = false;
    }
}
