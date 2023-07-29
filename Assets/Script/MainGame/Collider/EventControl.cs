using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EventControl : MonoBehaviour
{
    public Text systemTest;
    public int EventPoint;
    public int forward, backward;

    private void OnTriggerEnter(Collider other)
    {
        if (DiceControl.P1_totalNum == EventPoint || DiceControl.P2_totalNum == EventPoint || DiceControl.P3_totalNum == EventPoint || DiceControl.P4_totalNum == EventPoint)
        {
            if (other.tag == "P1")
            {
                StartCoroutine(P1_EventHappened());
            }
            else if (other.tag == "P2")
            {
                StartCoroutine(P2_EventHappened());
            }
            else if (other.tag == "P3")
            {
                StartCoroutine(P3_EventHappened());
            }
            else if (other.tag == "P4")
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
            systemTest.text = "ǰ�M�ɸ�";
            systemTest.color = Color.green;
        }
        else if (backward != 0)
        {
            systemTest.text = "���˃ɸ�";
            systemTest.color = Color.red;
        }
        SystemTestTextControl.isTimer = true;
        yield return new WaitForSeconds(2f);
        DiceControl.P1_totalNum += forward;
        DiceControl.P1_totalNum -= backward;
        AnimatorControl.isP1Move = true;
    }
    IEnumerator P2_EventHappened()
    {
        AnimatorControl.isP2Move = false;
        if (forward != 0)
        {
            systemTest.text = "ǰ�M�ɸ�";
            systemTest.color = Color.green;
        }
        else if (backward != 0)
        {
            systemTest.text = "���˃ɸ�";
            systemTest.color = Color.red;
        }
        SystemTestTextControl.isTimer = true;
        yield return new WaitForSeconds(2f);
        DiceControl.P2_totalNum += forward;
        DiceControl.P2_totalNum -= backward;
        AnimatorControl.isP2Move = true;
    }
    IEnumerator P3_EventHappened()
    {
        AnimatorControl.isP3Move = false;
        if (forward != 0)
        {
            systemTest.text = "ǰ�M�ɸ�";
            systemTest.color = Color.green;
        }
        else if (backward != 0)
        {
            systemTest.text = "���˃ɸ�";
            systemTest.color = Color.red;
        }
        SystemTestTextControl.isTimer = true;
        yield return new WaitForSeconds(2f);
        DiceControl.P3_totalNum += forward;
        DiceControl.P3_totalNum -= backward;
        AnimatorControl.isP3Move = true;
    }
    IEnumerator P4_EventHappened()
    {
        AnimatorControl.isP4Move = false;
        if (forward != 0)
        {
            systemTest.text = "ǰ�M�ɸ�";
            systemTest.color = Color.green;
        }
        else if (backward != 0)
        {
            systemTest.text = "���˃ɸ�";
            systemTest.color = Color.red;
        }
        SystemTestTextControl.isTimer = true;
        yield return new WaitForSeconds(2f);
        DiceControl.P4_totalNum += forward;
        DiceControl.P4_totalNum -= backward;
        AnimatorControl.isP4Move = true;
    }
}
