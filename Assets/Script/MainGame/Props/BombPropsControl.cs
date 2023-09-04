using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BombPropsControl : MonoBehaviour
{
    public static int pointNum;
    public static bool isBoomStopP1, isBoomStopP2, isBoomStopP3, isBoomStopP4;

    void FixedUpdate()
    {
        transform.Rotate(0, -1, 0);
    }

    private void OnTriggerEnter(Collider other)
    {
        IsStopUIControl.isStopUI++;
        isBoomStopP1 = true;
    }
}
