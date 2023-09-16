using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EventControl : MonoBehaviour
{
    public Text systemTest;
    public int EventPoint;
    public int forward, backward, stop, getCoin, lossCoin, getPorps;
    public bool eventAB;

    public static bool isStopP1 = false, isStopP2 = false, isStopP3 = false, isStopP4 = false;

    int r,p;

    private void OnTriggerEnter(Collider other)
    {
        if (!PropsControl.isTrans)
        {
            if (other.tag == "P1")
            {
                if (DiceControl.P1_totalNum == EventPoint)
                {
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
                }
            }
            else if (other.tag == "P2")
            {
                if (DiceControl.P2_totalNum == EventPoint)
                {
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
                }
            }
            else if (other.tag == "P3")
            {
                if (DiceControl.P3_totalNum == EventPoint)
                {
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
            }
            else if (other.tag == "P4")
            {
                if (DiceControl.P4_totalNum == EventPoint)
                {
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
            }
        }
        else
        {
            StartCoroutine(Transposition());
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
        else if (getCoin != 0)
        {
            systemTest.text = "獲得" + getCoin + "錢！";
            systemTest.color = Color.yellow;
            CoinControl.P1CoinTotal += getCoin;
        }
        else if (lossCoin != 0)
        {
            systemTest.text = "損失" + lossCoin + "錢！";
            systemTest.color = Color.yellow;
            CoinControl.P1CoinTotal -= lossCoin;
        }
        else if (getPorps != 0)
        {
            systemTest.text = "獲得道具！";
            systemTest.color = Color.blue;
            if (getPorps == 1)
            {
                PropsControl.P1Props[4] += 1;
            }
            else if (getPorps == 2)
            {
                p = Random.Range(1, 3);
                switch (p)
                {
                    case 1:
                        PropsControl.P1Props[1] += 1;
                        break;

                    case 2:
                        PropsControl.P1Props[2] += 1;
                        break;
                }
            }
        }
        SystemTestTextControl.isTimer = true;
        yield return new WaitForSeconds(2f);
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
        else if (getCoin != 0)
        {
            systemTest.text = "獲得" + getCoin + "錢！";
            systemTest.color = Color.yellow;
            CoinControl.P2CoinTotal += getCoin;
        }
        else if (lossCoin != 0)
        {
            systemTest.text = "損失" + lossCoin + "錢！";
            systemTest.color = Color.yellow;
            CoinControl.P2CoinTotal -= lossCoin;
        }
        SystemTestTextControl.isTimer = true;
        yield return new WaitForSeconds(2f);
        if (getCoin != 0 || lossCoin != 0)
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
        else if (getCoin != 0)
        {
            systemTest.text = "獲得" + getCoin + "錢！";
            systemTest.color = Color.yellow;
            CoinControl.P3CoinTotal += getCoin;
        }
        else if (lossCoin != 0)
        {
            systemTest.text = "損失" + lossCoin + "錢！";
            systemTest.color = Color.yellow;
            CoinControl.P3CoinTotal -= lossCoin;
        }
        SystemTestTextControl.isTimer = true;
        yield return new WaitForSeconds(2f);
        if (getCoin != 0 || lossCoin != 0)
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
        else if (getCoin != 0)
        {
            systemTest.text = "獲得" + getCoin + "錢！";
            systemTest.color = Color.yellow;
            CoinControl.P4CoinTotal += getCoin;
        }
        else if (lossCoin != 0)
        {
            systemTest.text = "損失" + lossCoin + "錢！";
            systemTest.color = Color.yellow;
            CoinControl.P4CoinTotal -= lossCoin;
        }
        SystemTestTextControl.isTimer = true;
        yield return new WaitForSeconds(2f);
        if (getCoin != 0 || lossCoin != 0)
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
        if (EventPoint == 4)
        {
            forward = 0;
            backward = 2;
            stop = 0;
            getCoin = 0;
            lossCoin = 0;
        }
    }
    void EventB()
    {
        if (EventPoint == 4)
        {
            forward = 0;
            backward = 1;
            stop = 0;
            getCoin = 0;
            lossCoin = 0;
        }
    }
}
