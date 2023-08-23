using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EventControl : MonoBehaviour
{
    public GameObject interactiveUI;
    public Text systemTest;
    public int EventPoint;
    public int forward, backward, stop;

    public static bool isStopP1 = false, isStopP2 = false, isStopP3 = false, isStopP4 = false;

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "P1")
        {
            if (DiceControl.P1_totalNum == EventPoint)
            {
                StartCoroutine(P1_EventHappened());
            }
        }
        else if (other.tag == "P2")
        {
            if (DiceControl.P2_totalNum == EventPoint)
            {
                StartCoroutine(P2_EventHappened());
            }
        }
        else if (other.tag == "P3")
        {
            if (DiceControl.P3_totalNum == EventPoint)
            {
                StartCoroutine(P3_EventHappened());
            }
        }
        else if (other.tag == "P4")
        {
            if (DiceControl.P4_totalNum == EventPoint)
            {
                StartCoroutine(P4_EventHappened());
            }
        }
    }
    IEnumerator P1_EventHappened()
    {
        AnimatorControl.isP1Move = false;
        if (forward != 0)
        {
            systemTest.text = "前進" + forward + "格！";
            systemTest.color = Color.green;
        }
        else if (backward != 0)
        {
            systemTest.text = "后退" + backward + "格！";
            systemTest.color = Color.red;
        }
        else if (stop != 0)
        {
            systemTest.text = "停留" + stop + "回合！";
            systemTest.color = Color.cyan;
        }
        SystemTestTextControl.isTimer = true;
        yield return new WaitForSeconds(2f);
        DiceControl.P1_totalNum += forward;
        DiceControl.P1_totalNum -= backward;
        if (stop == 0)
        {
            AnimatorControl.isP1Move = true;
        }
        yield return new WaitForSeconds(1f);
        if (stop != 0)
        {
            ChangeCameraControl.changeCameraNum++;
            DiceUIControl.isDiceUI = true;
            isStopP1 = true;
            IsStopUIControl.isStopUI++;
        }
    }
    IEnumerator P2_EventHappened()
    {
        AnimatorControl.isP2Move = false;
        if (forward != 0)
        {
            systemTest.text = "前進" + forward + "格！";
            systemTest.color = Color.green;
        }
        else if (backward != 0)
        {
            systemTest.text = "后退" + backward + "格！";
            systemTest.color = Color.red;
        }
        else if (stop != 0)
        {
            systemTest.text = "停留" + stop + "回合！";
            systemTest.color = Color.cyan;
        }
        SystemTestTextControl.isTimer = true;
        yield return new WaitForSeconds(2f);
        DiceControl.P2_totalNum += forward;
        DiceControl.P2_totalNum -= backward;
        if (stop == 0)
        {
            AnimatorControl.isP2Move = true;
        }
        yield return new WaitForSeconds(1f);
        if (stop != 0)
        {
            ChangeCameraControl.changeCameraNum++;
            interactiveUI.SetActive(true);
            isStopP2 = true;
            IsStopUIControl.isStopUI++;
        }
    }
    IEnumerator P3_EventHappened()
    {
        AnimatorControl.isP3Move = false;
        if (forward != 0)
        {
            systemTest.text = "前進" + forward + "格！";
            systemTest.color = Color.green;
        }
        else if (backward != 0)
        {
            systemTest.text = "后退" + backward + "格！";
            systemTest.color = Color.red;
        }
        else if (stop != 0)
        {
            systemTest.text = "停留" + stop + "回合！";
            systemTest.color = Color.cyan;
        }
        SystemTestTextControl.isTimer = true;
        yield return new WaitForSeconds(2f);
        DiceControl.P3_totalNum += forward;
        DiceControl.P3_totalNum -= backward;
        if (stop == 0)
        {
            AnimatorControl.isP3Move = true;
        }
        yield return new WaitForSeconds(1f);
        if (stop != 0)
        {
            ChangeCameraControl.changeCameraNum++;
            interactiveUI.SetActive(true);
            isStopP3 = true;
            IsStopUIControl.isStopUI++;
        }
    }
    IEnumerator P4_EventHappened()
    {
        AnimatorControl.isP4Move = false;
        if (forward != 0)
        {
            systemTest.text = "前進" + forward + "格！";
            systemTest.color = Color.green;
        }
        else if (backward != 0)
        {
            systemTest.text = "后退" + backward + "格！";
            systemTest.color = Color.red;
        }
        else if (stop != 0)
        {
            systemTest.text = "停留" + stop + "回合！";
            systemTest.color = Color.cyan;
        }
        SystemTestTextControl.isTimer = true;
        yield return new WaitForSeconds(2f);
        DiceControl.P4_totalNum += forward;
        DiceControl.P4_totalNum -= backward;
        if (stop == 0)
        {
            AnimatorControl.isP2Move = true;
        }
        yield return new WaitForSeconds(1f);
        if (stop != 0)
        {
            ChangeCameraControl.changeCameraNum++;
            interactiveUI.SetActive(true);
            isStopP4 = true;
            IsStopUIControl.isStopUI++;
        }
    }
}
