using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OrdinaryColliderControl : MonoBehaviour
{
    public int pointNum;

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "P1")
        {
            if (DiceControl.P1_totalNum == pointNum)
            {
                AnimatorControl.isP1Move = false;
                StartCoroutine(ChangeCamera());
            }
        }
        else if (other.tag == "P2")
        {
            if (DiceControl.P2_totalNum == pointNum)
            {
                AnimatorControl.isP2Move = false;
                StartCoroutine(ChangeCamera());
            }
        }
        else if (other.tag == "P3")
        {
            if (DiceControl.P3_totalNum == pointNum)
            {
                AnimatorControl.isP3Move = false;
                StartCoroutine(ChangeCamera());
            }
        }
        else if (other.tag == "P4")
        {
            if (DiceControl.P4_totalNum == pointNum)
            {
                AnimatorControl.isP4Move = false;
                StartCoroutine(ChangeCamera());
            }
        }
    }
    IEnumerator ChangeCamera()
    {
        yield return new WaitForSeconds(1f);
        ChangeCameraControl.changeCameraNum++;
        Dice.isDiceUI = true;
    }
}
