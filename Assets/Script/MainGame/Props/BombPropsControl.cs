using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BombPropsControl : MonoBehaviour
{
    public static int pointNum;
    public static bool isBoomStopP1, isBoomStopP2, isBoomStopP3, isBoomStopP4;

    private void FixedUpdate()
    {
        transform.Rotate(0, 1, 0);
    }

    private void OnTriggerEnter(Collider other)
    {
        print("Enter");
        if (other.tag == "P1")
        {
            if (!InsBombControl.isP1InsBomb)
            {
                if (DiceControl.P1_totalNum == pointNum)
                {
                    isBoomStopP1 = true;
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
                    isBoomStopP2 = true;
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
                    isBoomStopP3 = true;
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
                    isBoomStopP4 = true;
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
        yield return new WaitForSeconds(1f);
        Destroy(this.gameObject);
        yield return new WaitForSeconds(3f);
        IsStopUIControl.isBombStopUI++;
    }
}
