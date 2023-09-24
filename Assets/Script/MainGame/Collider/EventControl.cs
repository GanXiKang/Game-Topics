using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EventControl : MonoBehaviour
{
    public static bool P1_EnterEvent = true, P2_EnterEvent = true, P3_EnterEvent = true, P4_EnterEvent = true;
    public static bool isStopP1 = false, isStopP2 = false, isStopP3 = false, isStopP4 = false;

    public Text systemTest;
    public int EventPoint;
    public int forward, backward, stop, getCoin, lossCoin, getPorps;
    public bool eventAB;

    int r;

    private void OnTriggerEnter(Collider other)
    {
        if (!PropsControl.isTrans || !AnimalsPowerControl.tigerUsePower)
        {
            if (other.tag == "P1" && P1_EnterEvent)
            {
                if (DiceControl.P1_totalNum == EventPoint)
                {
                    P1_EnterEvent = false;
                    if (!eventAB)
                    {
                        StartCoroutine(P1_EventHappened());
                    }
                    else
                    {
                        r = Random.Range(1, 3);
                        switch (r)
                        {
                            case 1:
                                EventA();
                                StartCoroutine(P1_EventHappened());
                                break;

                            case 2:
                                EventB();
                                StartCoroutine(P1_EventHappened());
                                break;
                        }
                    }
                    if (Menu_ChoosePlayer.whyP1 == 1)
                    {
                        PowerUIControl.isMouseCanUsePower = false;
                    }
                }
            }
            else if (other.tag == "P2" && P2_EnterEvent)
            {
                if (DiceControl.P2_totalNum == EventPoint)
                {
                    P2_EnterEvent = false;
                    if (!eventAB)
                    {
                        StartCoroutine(P2_EventHappened());
                    }
                    else
                    {
                        r = Random.Range(1, 3);
                        switch (r)
                        {
                            case 1:
                                EventA();
                                StartCoroutine(P2_EventHappened());
                                break;

                            case 2:
                                EventB();
                                StartCoroutine(P2_EventHappened());
                                break;
                        }
                    }
                    if (Menu_ChoosePlayer.whyP2 == 1)
                    {
                        PowerUIControl.isMouseCanUsePower = false;
                    }
                }
            }
            else if (other.tag == "P3" && P3_EnterEvent)
            {
                if (DiceControl.P3_totalNum == EventPoint)
                {
                    P3_EnterEvent = false;
                    if (!eventAB)
                    {
                        StartCoroutine(P3_EventHappened());
                    }
                    else
                    {
                        r = Random.Range(1, 3);
                        switch (r)
                        {
                            case 1:
                                EventA();
                                StartCoroutine(P3_EventHappened());
                                break;

                            case 2:
                                EventB();
                                StartCoroutine(P3_EventHappened());
                                break;
                        }
                    }
                }
                if (Menu_ChoosePlayer.whyP3 == 1)
                {
                    PowerUIControl.isMouseCanUsePower = false;
                }
            }
            else if (other.tag == "P4" && P4_EnterEvent)
            {
                if (DiceControl.P4_totalNum == EventPoint)
                {
                    P4_EnterEvent = false;
                    if (!eventAB)
                    {
                        StartCoroutine(P4_EventHappened());
                    }
                    else
                    {
                        r = Random.Range(1, 3);
                        switch (r)
                        {
                            case 1:
                                EventA();
                                StartCoroutine(P4_EventHappened());
                                break;

                            case 2:
                                EventB();
                                StartCoroutine(P4_EventHappened());
                                break;
                        }
                    }
                }
                if (Menu_ChoosePlayer.whyP4 == 1)
                {
                    PowerUIControl.isMouseCanUsePower = false;
                }
            }
        }
        else
        {
            StartCoroutine(Transposition());
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "P1")
        {
            P1_EnterEvent = true;
        }
        if (other.tag == "P2")
        {
            P2_EnterEvent = true;
        }
        if (other.tag == "P3")
        {
            P3_EnterEvent = true;
        }
        if (other.tag == "P4")
        {
            P4_EnterEvent = true;
        }
    }
    IEnumerator P1_EventHappened()
    {
        AnimatorControl.isP1Move = false;
        EventImageUIControl.isTimer = true;
        EventImageUIControl.eventPointNum = EventPoint;
        yield return new WaitForSeconds(2f);
        if (getCoin != 0)
        {
            CoinControl.P1CoinTotal += getCoin;
        }
        else if (lossCoin != 0)
        {
            CoinControl.P1CoinTotal -= lossCoin;
        }
        else if (getPorps != 0)
        {
            if (getPorps == 1)
            {
                PropsControl.P1Props[4] += 1;
            }
            else if (getPorps == 2)
            {
                PropsControl.P1Props[2] += 1;
            }
        }
        yield return new WaitForSeconds(0.5f);
        if (getCoin != 0 || lossCoin != 0 || getPorps != 0)
        {
            ChangeCameraControl.changeCameraNum++;
            DiceUIControl.isDiceUI = true;
        }
        else
        {
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
                IsStopUIControl.isStopUI += stop;
            }
        }
    }
    IEnumerator P2_EventHappened()
    {
        AnimatorControl.isP2Move = false;
        EventImageUIControl.isTimer = true;
        EventImageUIControl.eventPointNum = EventPoint;
        yield return new WaitForSeconds(2f);
        if (getCoin != 0)
        {
            CoinControl.P2CoinTotal += getCoin;
        }
        else if (lossCoin != 0)
        {
            CoinControl.P2CoinTotal -= lossCoin;
        }
        else if (getPorps != 0)
        {
            if (getPorps == 1)
            {
                PropsControl.P2Props[4] += 1;
            }
            else if (getPorps == 2)
            {
                PropsControl.P1Props[2] += 1;
            }
        }
        yield return new WaitForSeconds(0.5f);
        if (getCoin != 0 || lossCoin != 0 || getPorps != 0)
        {
            ChangeCameraControl.changeCameraNum++;
            DiceUIControl.isDiceUI = true;
        }
        else
        {
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
                DiceUIControl.isDiceUI = true;
                isStopP2 = true;
                IsStopUIControl.isStopUI += stop;
            }
        }
    }
    IEnumerator P3_EventHappened()
    {
        AnimatorControl.isP3Move = false;
        EventImageUIControl.isTimer = true;
        EventImageUIControl.eventPointNum = EventPoint;
        yield return new WaitForSeconds(2f);
        if (getCoin != 0)
        {
            CoinControl.P3CoinTotal += getCoin;
        }
        else if (lossCoin != 0)
        {
            CoinControl.P3CoinTotal -= lossCoin;
        }
        else if (getPorps != 0)
        {
            if (getPorps == 1)
            {
                PropsControl.P3Props[4] += 1;
            }
            else if (getPorps == 2)
            {
                PropsControl.P1Props[2] += 1;
            }
        }
        yield return new WaitForSeconds(0.5f);
        if (getCoin != 0 || lossCoin != 0 || getPorps != 0)
        {
            ChangeCameraControl.changeCameraNum++;
            DiceUIControl.isDiceUI = true;
        }
        else
        {
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
                DiceUIControl.isDiceUI = true;
                isStopP3 = true;
                IsStopUIControl.isStopUI += stop;
            }
        }
    }
    IEnumerator P4_EventHappened()
    {
        AnimatorControl.isP4Move = false;
        EventImageUIControl.isTimer = true;
        EventImageUIControl.eventPointNum = EventPoint;
        yield return new WaitForSeconds(2f);
        if (getCoin != 0)
        {
            CoinControl.P4CoinTotal += getCoin;
        }
        else if (lossCoin != 0)
        {
            CoinControl.P4CoinTotal -= lossCoin;
        }
        else if (getPorps != 0)
        {
            if (getPorps == 1)
            {
                PropsControl.P2Props[4] += 1;
            }
            else if (getPorps == 2)
            {
                PropsControl.P1Props[2] += 1;
            }
        }
        yield return new WaitForSeconds(0.5f);
        if (getCoin != 0 || lossCoin != 0 || getPorps != 0)
        {
            ChangeCameraControl.changeCameraNum++;
            DiceUIControl.isDiceUI = true;
        }
        else
        {
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
                DiceUIControl.isDiceUI = true;
                isStopP4 = true;
                IsStopUIControl.isStopUI += stop;
            }
        }
    }
    IEnumerator Transposition()
    {
        yield return new WaitForSeconds(1f);
        PropsControl.isTrans = false;
    }

    void EventA()
    {
        EventImageUIControl.eventAB = 1;
        if (EventPoint == 6)
        {
            forward = 0;
            backward = 0;
            stop = 0;
            getCoin = 5;
            lossCoin = 0;
            getPorps = 0;
        }
        if (EventPoint == 20)
        {
            forward = 0;
            backward = 5;
            stop = 0;
            getCoin = 0;
            lossCoin = 0;
            getPorps = 0;
        }
        if (EventPoint == 22)
        {
            forward = 3;
            backward = 0;
            stop = 0;
            getCoin = 0;
            lossCoin = 0;
            getPorps = 0;
        }
        if (EventPoint == 26)
        {
            forward = 0;
            backward = 3;
            stop = 0;
            getCoin = 0;
            lossCoin = 0;
            getPorps = 0;
        }
        if (EventPoint == 46)
        {
            forward = 0;
            backward = 0;
            stop = 0;
            getCoin = 0;
            lossCoin = 5;
            getPorps = 0;
        }
        if (EventPoint == 56)
        {
            forward = 0;
            backward = 0;
            stop = 1;
            getCoin = 0;
            lossCoin = 0;
            getPorps = 0;
        }
    }
    void EventB()
    {
        EventImageUIControl.eventAB = 2;
        if (EventPoint == 6)
        {
            forward = 1;
            backward = 0;
            stop = 0;
            getCoin = 0;
            lossCoin = 0;
            getPorps = 0;
        }
        if (EventPoint == 20)
        {
            forward = 0;
            backward = 0;
            stop = 0;
            getCoin = 0;
            lossCoin = 0;
            getPorps = 1;
        }
        if (EventPoint == 22)
        {
            forward = 0;
            backward = 0;
            stop = 1;
            getCoin = 0;
            lossCoin = 0;
            getPorps = 0;
        }
        if (EventPoint == 26)
        {
            forward = 0;
            backward = 0;
            stop = 0;
            getCoin = 0;
            lossCoin = 10;
            getPorps = 0;
        }
        if (EventPoint == 46)
        {
            forward = 2;
            backward = 0;
            stop = 0;
            getCoin = 0;
            lossCoin = 0;
            getPorps = 0;
        }
        if (EventPoint == 56)
        {
            forward = 0;
            backward = 1;
            stop = 0;
            getCoin = 0;
            lossCoin = 5;
            getPorps = 0;
        }
    }
}
