using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BombPropsControl : MonoBehaviour
{
    public static int pointNum;
    public static bool isBoomStopP1, isBoomStopP2, isBoomStopP3, isBoomStopP4;

    private void OnTriggerEnter(Collider other)
    {
        IsStopUIControl.isStopUI++;
        if (gameObject.tag == "P1")
        {
            isBoomStopP1 = true;
        }
        else if (gameObject.tag == "P2")
        {
            isBoomStopP2 = true;
        }
        else if (gameObject.tag == "P3")
        {
            isBoomStopP3 = true;
        }
        else if (gameObject.tag == "P4")
        {
            isBoomStopP4 = true;
        }
        Destroy(this.gameObject, 2f);
    }
}
