using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EventControl : MonoBehaviour
{
    public static bool P1_EnterEvent = true, P2_EnterEvent = true, P3_EnterEvent = true, P4_EnterEvent = true;
    public static bool isStopP1 = false, isStopP2 = false, isStopP3 = false, isStopP4 = false;

    public AudioSource BGM;
    public AudioClip goodE, badE;
    public Text systemTest;
    public int EventPoint;
    public int forward, backward, stop, getCoin, lossCoin, getPorps;
    public bool eventAB;

    int r;
    bool isStopProps = false;

    private void OnTriggerEnter(Collider other)
    {
        if (!PropsControl.isTrans && !AnimalsPowerControl.tigerUsePower)
        {
            if (other.tag == "P1" && P1_EnterEvent)
            {
                if (DiceControl.P1_totalNum == EventPoint)
                {
                    P1_EnterEvent = false;
                    AnimatorControl.isP1Move = false;
                    if (!isStopProps)
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
                    else
                    {
                        if (!AnimalsPowerControl.chickenUsePower || Menu_ChoosePlayer.whyP1 != 10)
                        {
                            StartCoroutine(StopRound());
                        }
                        else
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
                        isStopProps = false;
                    }
                    if (Menu_ChoosePlayer.whyP1 == 1)
                    {
                        PowerUIControl.isMouseCanUsePower = false;
                    }
                }
            }
            else if(other.tag == "P2" && P2_EnterEvent)
            {
                if (DiceControl.P2_totalNum == EventPoint)
                {
                    P2_EnterEvent = false;
                    AnimatorControl.isP2Move = false;
                    if (!isStopProps)
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
                    else
                    {
                        if (!AnimalsPowerControl.chickenUsePower || Menu_ChoosePlayer.whyP2 != 10)
                        {
                            StartCoroutine(StopRound());
                        }
                        else
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
                        isStopProps = false;
                    }
                    if (Menu_ChoosePlayer.whyP2 == 1)
                    {
                        PowerUIControl.isMouseCanUsePower = false;
                    }
                }
            }
            else if(other.tag == "P3" && P3_EnterEvent)
            {
                if (DiceControl.P3_totalNum == EventPoint)
                {
                    P3_EnterEvent = false;
                    AnimatorControl.isP3Move = false;
                    if (!isStopProps)
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
                    else
                    {
                        if (!AnimalsPowerControl.chickenUsePower || Menu_ChoosePlayer.whyP3 != 10)
                        {
                            StartCoroutine(StopRound());
                        }
                        else
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
                        isStopProps = false;
                    }
                    if (Menu_ChoosePlayer.whyP3 == 1)
                    {
                        PowerUIControl.isMouseCanUsePower = false;
                    }
                }
            }
            else if(other.tag == "P4" && P4_EnterEvent)
            {
                if (DiceControl.P4_totalNum == EventPoint)
                {
                    P4_EnterEvent = false;
                    AnimatorControl.isP4Move = false;
                    if (!isStopProps)
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
                    else
                    {
                        if (!AnimalsPowerControl.chickenUsePower || Menu_ChoosePlayer.whyP4 != 10)
                        {
                            StartCoroutine(StopRound());
                        }
                        else
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
                        isStopProps = false;
                    }
                    if (Menu_ChoosePlayer.whyP4 == 1)
                    {
                        PowerUIControl.isMouseCanUsePower = false;
                    }
                }
            }
        }
        else
        {
            if (other.tag == "P1" && P1_EnterEvent)
            {
                if (DiceControl.P1_totalNum == EventPoint)
                {
                    P1_EnterEvent = false;
                    AnimatorControl.isP1Move = false;
                    if (PropsControl.isTrans)
                    {
                        PropsControl.isTransNum++;
                    }
                    if (Menu_ChoosePlayer.whyP1 == 1)
                    {
                        PowerUIControl.isMouseCanUsePower = false;
                    }
                }
            }
            else if(other.tag == "P2" && P2_EnterEvent)
            {
                if (DiceControl.P2_totalNum == EventPoint)
                {
                    P2_EnterEvent = false;
                    AnimatorControl.isP2Move = false;
                    if (PropsControl.isTrans)
                    {
                        PropsControl.isTransNum++;
                    }
                    if (Menu_ChoosePlayer.whyP2 == 1)
                    {
                        PowerUIControl.isMouseCanUsePower = false;
                    }
                }
            }
            else if(other.tag == "P3" && P3_EnterEvent)
            {
                if (DiceControl.P3_totalNum == EventPoint)
                {
                    P3_EnterEvent = false;
                    AnimatorControl.isP3Move = false;
                    if (PropsControl.isTrans)
                    {
                        PropsControl.isTransNum++;
                    }
                    if (Menu_ChoosePlayer.whyP3 == 1)
                    {
                        PowerUIControl.isMouseCanUsePower = false;
                    }
                }
            }
            else if(other.tag == "P4" && P4_EnterEvent)
            {
                if (DiceControl.P4_totalNum == EventPoint)
                {
                    P4_EnterEvent = false;
                    AnimatorControl.isP4Move = false;
                    if (PropsControl.isTrans)
                    {
                        PropsControl.isTransNum++;
                    }
                    if (Menu_ChoosePlayer.whyP4 == 1)
                    {
                        PowerUIControl.isMouseCanUsePower = false;
                    }
                }
            }
        }

        if (other.tag == "StopProps")
        {
            isStopProps = true;
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
        if (!AnimalsPowerControl.dragonUsePower || Menu_ChoosePlayer.whyP1 != 5)
        {
            AnimatorControl.isP1Skill = false;
            EventImageUIControl.isTimer = true;
            EventImageUIControl.eventPointNum = EventPoint;
            if (getCoin != 0 || getPorps != 0 || forward != 0)
            {
                BGM.PlayOneShot(goodE);
            }
            else
            {
                BGM.PlayOneShot(badE);
            }
            yield return new WaitForSeconds(4f);
            if (getCoin != 0)
            {
                CoinControl.P1CoinTotal += getCoin;
                AnimatorControl.isP1Win = true;
            }
            else if (lossCoin != 0)
            {
                CoinControl.P1CoinTotal -= lossCoin;
                AnimatorControl.isP1Lose = true;
            }
            else if (getPorps != 0)
            {
                AnimatorControl.isP1Win = true;
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
                AnimatorControl.isP1Win = false;
                AnimatorControl.isP1Lose = false;
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
        else
        {
            AnimatorControl.isDragonFlyWalk = false;
            CameraMoveControl.isChangeCameraPoint = true;
            yield return new WaitForSeconds(1f);
            AnimalsPowerControl.dragonPowerRound += 1;
            yield return new WaitForSeconds(1f);
            ChangeCameraControl.changeCameraNum++;
            DiceUIControl.isDiceUI = true;
            CameraMoveControl.isChangeCameraPoint = false;
        }
    }
    IEnumerator P2_EventHappened()
    {
        if (!AnimalsPowerControl.dragonUsePower || Menu_ChoosePlayer.whyP2 != 5)
        {
            AnimatorControl.isP2Skill = false;
            EventImageUIControl.isTimer = true;
            EventImageUIControl.eventPointNum = EventPoint;
            if (getCoin != 0 || getPorps != 0 || forward != 0)
            {
                BGM.PlayOneShot(goodE);
            }
            else
            {
                BGM.PlayOneShot(badE);
            }
            yield return new WaitForSeconds(4f);
            if (getCoin != 0)
            {
                CoinControl.P2CoinTotal += getCoin;
                AnimatorControl.isP2Win = true;
            }
            else if (lossCoin != 0)
            {
                CoinControl.P2CoinTotal -= lossCoin;
                AnimatorControl.isP2Lose = true;
            }
            else if (getPorps != 0)
            {
                AnimatorControl.isP2Win = true;
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
                AnimatorControl.isP2Win = false;
                AnimatorControl.isP2Lose = false;
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
        else
        {
            AnimatorControl.isDragonFlyWalk = false;
            CameraMoveControl.isChangeCameraPoint = true;
            yield return new WaitForSeconds(1f);
            AnimalsPowerControl.dragonPowerRound += 1;
            yield return new WaitForSeconds(1f);
            ChangeCameraControl.changeCameraNum++;
            DiceUIControl.isDiceUI = true;
            CameraMoveControl.isChangeCameraPoint = false;
        }
    }
    IEnumerator P3_EventHappened()
    {
        if (!AnimalsPowerControl.dragonUsePower || Menu_ChoosePlayer.whyP3 != 5)
        {
            AnimatorControl.isP3Skill = false;
            EventImageUIControl.isTimer = true;
            EventImageUIControl.eventPointNum = EventPoint;
            if (getCoin != 0 || getPorps != 0 || forward != 0)
            {
                BGM.PlayOneShot(goodE);
            }
            else
            {
                BGM.PlayOneShot(badE);
            }
            yield return new WaitForSeconds(4f);
            if (getCoin != 0)
            {
                CoinControl.P3CoinTotal += getCoin;
                AnimatorControl.isP3Win = true;
            }
            else if (lossCoin != 0)
            {
                CoinControl.P3CoinTotal -= lossCoin;
                AnimatorControl.isP3Lose = true;
            }
            else if (getPorps != 0)
            {
                AnimatorControl.isP3Win = true;
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
                AnimatorControl.isP3Win = false;
                AnimatorControl.isP3Lose = false;
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
        else
        {
            AnimatorControl.isDragonFlyWalk = false;
            CameraMoveControl.isChangeCameraPoint = true;
            yield return new WaitForSeconds(1f);
            AnimalsPowerControl.dragonPowerRound += 1;
            yield return new WaitForSeconds(1f);
            ChangeCameraControl.changeCameraNum++;
            DiceUIControl.isDiceUI = true;
            CameraMoveControl.isChangeCameraPoint = false;
        }
    }
    IEnumerator P4_EventHappened()
    {
        if (!AnimalsPowerControl.dragonUsePower || Menu_ChoosePlayer.whyP4 != 5)
        {
            AnimatorControl.isP4Skill = false;
            EventImageUIControl.isTimer = true;
            EventImageUIControl.eventPointNum = EventPoint;
            if (getCoin != 0 || getPorps != 0 || forward != 0)
            {
                BGM.PlayOneShot(goodE);
            }
            else
            {
                BGM.PlayOneShot(badE);
            }
            yield return new WaitForSeconds(4f);
            if (getCoin != 0)
            {
                CoinControl.P4CoinTotal += getCoin;
                AnimatorControl.isP4Win = true;
            }
            else if (lossCoin != 0)
            {
                CoinControl.P4CoinTotal -= lossCoin;
                AnimatorControl.isP4Lose = true;
            }
            else if (getPorps != 0)
            {
                AnimatorControl.isP4Win = true;
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
                AnimatorControl.isP4Win = false;
                AnimatorControl.isP4Lose = false;
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
        else
        {
            AnimatorControl.isDragonFlyWalk = false;
            CameraMoveControl.isChangeCameraPoint = true;
            yield return new WaitForSeconds(1f);
            AnimalsPowerControl.dragonPowerRound += 1;
            yield return new WaitForSeconds(1f);
            ChangeCameraControl.changeCameraNum++;
            DiceUIControl.isDiceUI = true;
            CameraMoveControl.isChangeCameraPoint = false;
        }
    }
    IEnumerator StopRound()
    {
        CameraMoveControl.isChangeCameraPoint = true;
        yield return new WaitForSeconds(3f);
        CameraMoveControl.isChangeCameraPoint = false;
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
