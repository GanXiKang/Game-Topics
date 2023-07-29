using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OrdinaryColliderControl : MonoBehaviour
{
    public int pointNum;

    private void OnTriggerEnter(Collider other)
    {
        if (DiceControl.P1_totalNum == pointNum || DiceControl.P2_totalNum == pointNum || DiceControl.P3_totalNum == pointNum || DiceControl.P4_totalNum == pointNum)
        {
            if (other.tag == "P1")
            {
                AnimatorControl.isP1Move = false;
                StartCoroutine(ChangeCamera());
            }
            else if (other.tag == "P2")
            {
                AnimatorControl.isP2Move = false;
                StartCoroutine(ChangeCamera());
            }
            else if (other.tag == "P3")
            {
                AnimatorControl.isP3Move = false;
                StartCoroutine(ChangeCamera());
            }
            else if (other.tag == "P4")
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
