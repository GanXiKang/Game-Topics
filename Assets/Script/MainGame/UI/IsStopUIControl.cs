using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class IsStopUIControl : MonoBehaviour
{
    public Text systemText;

    public static int isStopUI = 0, isBombStopUI = 0;
    public static bool isBombStopP1, isBombStopP2, isBombStopP3, isBombStopP4;

    void Update()
    {
        if (isStopUI != 0)
        {
            switch (ChangeCameraControl.changeCameraNum)
            {
                case 1:
                    if (EventControl.isStopP1)
                    {
                        StartCoroutine(StopThisRound());
                        EventControl.isStopP1 = false;
                    }
                    break;

                case 2:
                    if (EventControl.isStopP2)
                    {
                        StartCoroutine(StopThisRound());
                        EventControl.isStopP2 = false;
                    }
                    break;

                case 3:
                    if (EventControl.isStopP3)
                    {
                        StartCoroutine(StopThisRound());
                        EventControl.isStopP3 = false;
                    }
                    break;

                case 4:
                    if (EventControl.isStopP4)
                    {
                        StartCoroutine(StopThisRound());
                        EventControl.isStopP4 = false;
                    }
                    break;
            }
        }
        if (isBombStopUI != 0)
        {
            switch (ChangeCameraControl.changeCameraNum)
            {
                case 1:
                    if (isBombStopP1)
                    {
                        StartCoroutine(BombStopThisRound());
                        isBombStopP1 = false;
                    }
                    break;

                case 2:
                    if (isBombStopP2)
                    {
                        StartCoroutine(BombStopThisRound());
                        isBombStopP2 = false;
                    }
                    break;

                case 3:
                    if (isBombStopP3)
                    {
                        StartCoroutine(BombStopThisRound());
                        isBombStopP3 = false;
                    }
                    break;

                case 4:
                    if (isBombStopP4)
                    {
                        StartCoroutine(BombStopThisRound());
                        isBombStopP4 = false;
                    }
                    break;
            }
        }
    }
    IEnumerator StopThisRound()
    {
        isStopUI--;
        DiceUIControl.isDiceUI = false;
        systemText.text = "�˻غϕ�ͣ";
        systemText.color = Color.cyan;
        SystemTestTextControl.isTimer = true;
        yield return new WaitForSeconds(2f);
        ChangeCameraControl.changeCameraNum++;
        DiceUIControl.isDiceUI = true;
    }
    IEnumerator BombStopThisRound()
    {
        isBombStopUI--;
        DiceUIControl.isDiceUI = false;
        systemText.text = "�˻غϕ�ͣ";
        systemText.color = Color.cyan;
        SystemTestTextControl.isTimer = true;
        yield return new WaitForSeconds(2f);
        ChangeCameraControl.changeCameraNum++;
        DiceUIControl.isDiceUI = true;
    }
}
