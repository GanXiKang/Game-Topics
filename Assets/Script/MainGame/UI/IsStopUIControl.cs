using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class IsStopUIControl : MonoBehaviour
{
    public Text systemText;

    public static int isStopUI = 0;

    void Update()
    {
        if (isStopUI != 0)
        {
            switch (ChangeCameraControl.changeCameraNum)
            {
                case 1:
                    if (EventControl.isStopP1 || BombPropsControl.isBoomStopP1)
                    {
                        StartCoroutine(StopThisRound());
                        EventControl.isStopP1 = false;
                        BombPropsControl.isBoomStopP1 = false;
                    }
                    break;

                case 2:
                    if (EventControl.isStopP2 || BombPropsControl.isBoomStopP2)
                    {
                        StartCoroutine(StopThisRound());
                        EventControl.isStopP2 = false;
                        BombPropsControl.isBoomStopP2 = false;
                    }
                    break;

                case 3:
                    if (EventControl.isStopP3 || BombPropsControl.isBoomStopP3)
                    {
                        StartCoroutine(StopThisRound());
                        EventControl.isStopP3 = false;
                        BombPropsControl.isBoomStopP3 = false;
                    }
                    break;

                case 4:
                    if (EventControl.isStopP4 || BombPropsControl.isBoomStopP4)
                    {
                        StartCoroutine(StopThisRound());
                        EventControl.isStopP4 = false;
                        BombPropsControl.isBoomStopP4 = false;
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
}
