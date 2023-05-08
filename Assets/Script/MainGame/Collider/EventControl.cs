using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EventControl : MonoBehaviour
{
    public Text systemTest;
    public int EventPoint;

    private void OnTriggerEnter(Collider other)
    {
        if (Dice.P1_totalNum == EventPoint || Dice.P2_totalNum == EventPoint || Dice.P3_totalNum == EventPoint || Dice.P4_totalNum == EventPoint)
        {
            AnimatorControl.isMove = false;
            if (other.tag == "P1")
            {
                StartCoroutine(P1_EventHappened());
            }
            if (other.tag == "P2")
            {
                StartCoroutine(P2_EventHappened());
            }
            if (other.tag == "P3")
            {
                StartCoroutine(P3_EventHappened());
            }
            if (other.tag == "P4")
            {
                StartCoroutine(P4_EventHappened());
            }
        }
    }
    IEnumerator P1_EventHappened()
    {
        systemTest.text = "退后兩格！";
        systemTest.color = Color.red;
        SystemTestTextControl.isTimer = true;
        yield return new WaitForSeconds(2f);
        Dice.P1_totalNum -= 2;
        AnimatorControl.isMove = true;
    }
    IEnumerator P2_EventHappened()
    {
        systemTest.text = "退后兩格！";
        systemTest.color = Color.red;
        SystemTestTextControl.isTimer = true;
        yield return new WaitForSeconds(2f);
        Dice.P2_totalNum -= 2;
        AnimatorControl.isMove = true;
    }
    IEnumerator P3_EventHappened()
    {
        systemTest.text = "退后兩格！";
        systemTest.color = Color.red;
        SystemTestTextControl.isTimer = true;
        yield return new WaitForSeconds(2f);
        Dice.P3_totalNum -= 2;
        AnimatorControl.isMove = true;
    }
    IEnumerator P4_EventHappened()
    {
        systemTest.text = "退后兩格！";
        systemTest.color = Color.red;
        SystemTestTextControl.isTimer = true;
        yield return new WaitForSeconds(2f);
        Dice.P4_totalNum -= 2;
        AnimatorControl.isMove = true;
    }
}
