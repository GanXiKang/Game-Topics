using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BombPropsControl : MonoBehaviour
{
    public static int pointNum;
    public static bool isBoomStopP1, isBoomStopP2, isBoomStopP3, isBoomStopP4;

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "P1")
        {
            if (!InsBombControl.isP1InsBomb)
            {
                if (DiceControl.P1_totalNum == pointNum)
                {
                    IsStopUIControl.isStopUI++;
                    isBoomStopP1 = true;
                    Destroy(this.gameObject, 2f);
                }
            }
            else 
            {
                InsBombControl.isP1InsBomb = true;
            }
        }
        else if (other.tag == "P2")
        {
            if (!InsBombControl.isP2InsBomb)
            {
                if (DiceControl.P2_totalNum == pointNum)
                {
                    IsStopUIControl.isStopUI++;
                    isBoomStopP2 = true;
                    Destroy(this.gameObject, 2f);
                }
            }
            else
            {
                InsBombControl.isP2InsBomb = true;
            }
        }
        else if (other.tag == "P3")
        {
            if (!InsBombControl.isP3InsBomb)
            {
                if (DiceControl.P3_totalNum == pointNum)
                {
                    IsStopUIControl.isStopUI++;
                    isBoomStopP3 = true;
                    Destroy(this.gameObject, 2f);
                }
            }
            else
            {
                InsBombControl.isP3InsBomb = true;
            }
        }
        else if (other.tag == "P4")
        {
            if (!InsBombControl.isP4InsBomb)
            {
                if (DiceControl.P4_totalNum == pointNum)
                {
                    IsStopUIControl.isStopUI++;
                    isBoomStopP4 = true;
                    Destroy(this.gameObject, 2f);
                }
            }
            else
            {
                InsBombControl.isP4InsBomb = true;
            }
        }
    }
}
