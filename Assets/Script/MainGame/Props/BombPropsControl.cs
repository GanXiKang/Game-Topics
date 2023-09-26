using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BombPropsControl : MonoBehaviour
{
    public static int pointNum;
    public static bool iscolliderBombText = false;
    bool r = true;

    void FixedUpdate()
    {
        if (r)
        {
            transform.Rotate(0, 1, 0);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "P1")
        {
            if (!InsBombControl.isP1InsBomb)
            {
                if (DiceControl.P1_totalNum == pointNum)
                {
                    IsStopUIControl.isBombStopP1 = true;
                    AnimatorControl.isP1Dizziness = true;
                    StartCoroutine(StopTiming());
                }
            }
            else 
            {
                InsBombControl.isP1InsBomb = false;
            }
        }
        else if (other.tag == "P2")
        {
            if (!InsBombControl.isP2InsBomb)
            {
                if (DiceControl.P2_totalNum == pointNum)
                {
                    IsStopUIControl.isBombStopP2 = true;
                    AnimatorControl.isP2Dizziness = true;
                    StartCoroutine(StopTiming());
                }
            }
            else
            {
                InsBombControl.isP2InsBomb = false;
            }
        }
        else if (other.tag == "P3")
        {
            if (!InsBombControl.isP3InsBomb)
            {
                if (DiceControl.P3_totalNum == pointNum)
                {
                    IsStopUIControl.isBombStopP3 = true;
                    AnimatorControl.isP3Dizziness = true;
                    StartCoroutine(StopTiming());
                }
            }
            else
            {
                InsBombControl.isP3InsBomb = false;
            }
        }
        else if (other.tag == "P4")
        {
            if (!InsBombControl.isP4InsBomb)
            {
                if (DiceControl.P4_totalNum == pointNum)
                {
                    IsStopUIControl.isBombStopP4 = true;
                    AnimatorControl.isP4Dizziness = true;
                    StartCoroutine(StopTiming());
                }
            }
            else
            {
                InsBombControl.isP4InsBomb = false;
            }
        }
    }
    IEnumerator StopTiming()
    {
        r = false;
        iscolliderBombText = true;
        yield return new WaitForSeconds(3f);
        IsStopUIControl.isBombStopUI++;
        Destroy(this.gameObject);  
    }
}
