using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MG3_GameControl : MonoBehaviour
{
    public GameObject WinUI, LoseUI;

    public static int round;
    public static bool isCupMove, isDownCup, isEnd, isWin;
    public static float duration;

    void Start()
    {
        round = 0;
        isCupMove = false;
        isDownCup = false;
        isEnd = false;
        isWin = true;
    }
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
                duration = 0.6f;
                break;
        }

        if (isDownCup)
        {
            Invoke("BeforeisCupMove", 0.5f);
            Invoke("FalseByisCupMove", 1f);
        }

        if (isEnd)
        {
            if (isWin)
            {
                WinUI.SetActive(true);
            }
            else
            {
                LoseUI.SetActive(false);
            }
        }
    }

    void BeforeisCupMove()
    {
        isDownCup = false;
        isCupMove = true;
    }
    void FalseByisCupMove()
    {
        isCupMove = false;
    }
}
