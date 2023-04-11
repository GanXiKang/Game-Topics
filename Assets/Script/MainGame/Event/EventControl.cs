using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EventControl : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
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
    IEnumerator P1_EventHappened()
    {
        print("�˺�ɸ�");
        yield return new WaitForSeconds(2f);
        Dice.P1_totalNum -= 2;
    }
    IEnumerator P2_EventHappened()
    {
        print("�˺�ɸ�");
        yield return new WaitForSeconds(2f);
        Dice.P2_totalNum -= 2;
    }
    IEnumerator P3_EventHappened()
    {
        print("�˺�ɸ�");
        yield return new WaitForSeconds(2f);
        Dice.P3_totalNum -= 2;
    }
    IEnumerator P4_EventHappened()
    {
        print("�˺�ɸ�");
        yield return new WaitForSeconds(2f);
        Dice.P4_totalNum -= 2;
    }
}
