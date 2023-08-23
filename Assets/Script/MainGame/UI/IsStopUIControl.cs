using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class IsStopUIControl : MonoBehaviour
{
    public GameObject interactiveUI;
    public Text systemText;

    public static bool isStopUI = false;

    void Update()
    {
        if (isStopUI)
        {
            switch (ChangeCameraControl.changeCameraNum)
            {
                case 1:
                    if (EventControl.isStopP1)
                    {
                        StartCoroutine(StopThisRound());
                    }
                    break;

                case 2:
                    if (EventControl.isStopP2)
                    {
                        StartCoroutine(StopThisRound());
                    }
                    break;

                case 3:
                    if (EventControl.isStopP3)
                    {
                        StartCoroutine(StopThisRound());
                    }
                    break;

                case 4:
                    if (EventControl.isStopP4)
                    {
                        StartCoroutine(StopThisRound());
                    }
                    break;
            }
        }
    }
    IEnumerator StopThisRound()
    {
        isStopUI = false;
        DiceUIControl.isDiceUI = false;
        systemText.text = "�˻غϕ�ͣ";
        systemText.color = Color.cyan;
        yield return new WaitForSeconds(2f);
        ChangeCameraControl.changeCameraNum++;
        DiceUIControl.isDiceUI = true;
    }
}
