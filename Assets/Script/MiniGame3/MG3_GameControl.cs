using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MG3_GameControl : MonoBehaviour
{
    AudioSource BGM;

    public GameObject WinUI, LoseUI;
    public AudioClip gameWin, gameLose;

    public static int round;
    public static bool isCupMove, isDownCup, isEnd, isWin;
    public static float duration;

    void Start()
    {
        BGM = GetComponent<AudioSource>();
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
                BGM.PlayOneShot(gameWin);
            }
            else
            {
                LoseUI.SetActive(false);
                BGM.PlayOneShot(gameLose);
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
    void PlayerPlayGameControl()
    {
        if (MiniGameColliderControl.p == 1)
        {
            MiniGameColliderControl.P1_playGame = false;
            MiniGameColliderControl.p = 0;
        }
        if (MiniGameColliderControl.p == 2)
        {
            MiniGameColliderControl.P2_playGame = false;
            MiniGameColliderControl.p = 0;
        }
        if (MiniGameColliderControl.p == 3)
        {
            MiniGameColliderControl.P3_playGame = false;
            MiniGameColliderControl.p = 0;
        }
        if (MiniGameColliderControl.p == 4)
        {
            MiniGameColliderControl.P4_playGame = false;
            MiniGameColliderControl.p = 0;
        }
    }
}
