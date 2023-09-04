using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BombPropsControl : MonoBehaviour
{
    public static int pointNum;
    public static bool isBoomStopP1, isBoomStopP2, isBoomStopP3, isBoomStopP4;

    private void OnTriggerEnter(Collider other)
    {
        if (gameObject.tag == "P1")
        {
            //if (!InsBombControl.isP1InsBomb)
            //{
                IsStopUIControl.isStopUI++;
                isBoomStopP1 = true;
                Destroy(this.gameObject, 2f);
            //}
        }
        else if (gameObject.tag == "P2")
        {
            IsStopUIControl.isStopUI++;
            isBoomStopP2 = true;
            Destroy(this.gameObject, 2f);
        }
        else if (gameObject.tag == "P3")
        {
            IsStopUIControl.isStopUI++;
            isBoomStopP3 = true;
            Destroy(this.gameObject, 2f);
        }
        else if (gameObject.tag == "P4")
        {
            IsStopUIControl.isStopUI++;
            isBoomStopP4 = true;
            Destroy(this.gameObject, 2f);
        }
    }
}
