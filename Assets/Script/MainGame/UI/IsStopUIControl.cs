using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class IsStopUIControl : MonoBehaviour
{
    public GameObject interactiveUI;
    public Text systemText;

    public static int isStopUI = 0;

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
    }
    IEnumerator StopThisRound()
    {
        isStopUI--;
        DiceUIControl.isDiceUI = false;
        systemText.text = "�˻غϕ�ͣ";
        systemText.color = Color.cyan;
        yield return new WaitForSeconds(2f);
        ChangeCameraControl.changeCameraNum++;
        DiceUIControl.isDiceUI = true;
    }
}
