using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MG3_GameControl : MonoBehaviour
{
    public static int round;
    public static bool isMove = false;
    public static float duration;

    void Update()
    {
        switch (round)
        {
            case 1:
                duration = 2f;
                break;

            case 2:
                duration = 1f;
                break;

            case 3:
                duration = 0.5f;
                break;
        }

        if (isMove)
        {
            Invoke("FalseByisMove()", 0.5f);
        }
    }

    void FalseByisMove()
    {
        isMove = false;
    }
}
