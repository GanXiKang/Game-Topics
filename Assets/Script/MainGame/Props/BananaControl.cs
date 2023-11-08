using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BananaControl : MonoBehaviour
{
    Rigidbody rb; 

    public static int pointNum;
    public static bool iscolliderBananaText = false;
    public static bool isBananaSound = false;

    bool once = true;
    int whoPut;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "P1")
        {
            if (MonkeyPowerControl.isP1InsBanana)
            {
                whoPut = 1;
                MonkeyPowerControl.isP1InsBanana = false;
            }
        }
        else if (other.tag == "P2")
        {
            if (MonkeyPowerControl.isP2InsBanana)
            {
                whoPut = 2;
                MonkeyPowerControl.isP2InsBanana = false;
            }
        }
        else if (other.tag == "P3")
        {
            if (MonkeyPowerControl.isP3InsBanana)
            {
                whoPut = 3;
                MonkeyPowerControl.isP3InsBanana = false;
            }
        }
        else if (other.tag == "P4")
        {
            if (MonkeyPowerControl.isP4InsBanana)
            {
                whoPut = 4;
                MonkeyPowerControl.isP4InsBanana = false;
            }
        }
    }
    private void OnTriggerStay(Collider other)
    {
        if (whoPut != ChangeCameraControl.changeCameraNum)
        {
            if (once)
            {
                switch (ChangeCameraControl.changeCameraNum)
                {
                    case 1:
                        if (other.tag == "P1")
                        {
                            if (DiceControl.P1_totalNum == pointNum)
                            {
                                if (!AnimalsPowerControl.chickenUsePower || Menu_ChoosePlayer.whyP1 != 10)
                                {
                                    AnimatorControl.isP1Dizziness = true;
                                    IsStopUIControl.isBananaStopP1 = true;
                                    StartCoroutine(StopTiming());
                                    if (AnimalsPowerControl.dragonUsePower && Menu_ChoosePlayer.whyP1 == 5)
                                    {
                                        AnimalsPowerControl.dragonUsePower = false;
                                        AnimatorControl.isP1Skill = false;
                                    }
                                }
                                else
                                {
                                    Destroy(this.gameObject);
                                }
                            }
                        }
                        break;

                    case 2:
                        if (other.tag == "P2")
                        {
                            if (DiceControl.P2_totalNum == pointNum)
                            {
                                if (!AnimalsPowerControl.chickenUsePower || Menu_ChoosePlayer.whyP2 != 10)
                                {
                                    AnimatorControl.isP2Dizziness = true;
                                    IsStopUIControl.isBananaStopP2 = true;
                                    StartCoroutine(StopTiming());
                                    if (AnimalsPowerControl.dragonUsePower && Menu_ChoosePlayer.whyP2 == 5)
                                    {
                                        AnimalsPowerControl.dragonUsePower = false;
                                        AnimatorControl.isP2Skill = false;
                                    }
                                }
                                else
                                {
                                    Destroy(this.gameObject);
                                }
                            }
                        }
                        break;

                    case 3:
                        if (other.tag == "P3")
                        {
                            if (DiceControl.P3_totalNum == pointNum)
                            {
                                if (!AnimalsPowerControl.chickenUsePower || Menu_ChoosePlayer.whyP3 != 10)
                                {
                                    AnimatorControl.isP3Dizziness = true;
                                    IsStopUIControl.isBananaStopP3 = true;
                                    StartCoroutine(StopTiming());
                                    if (AnimalsPowerControl.dragonUsePower && Menu_ChoosePlayer.whyP3 == 5)
                                    {
                                        AnimalsPowerControl.dragonUsePower = false;
                                        AnimatorControl.isP3Skill = false;
                                    }
                                }
                                else
                                {
                                    Destroy(this.gameObject);
                                }
                            }
                        }
                        break;

                    case 4:
                        if (other.tag == "P4")
                        {
                            if (DiceControl.P4_totalNum == pointNum)
                            {
                                if (!AnimalsPowerControl.chickenUsePower || Menu_ChoosePlayer.whyP4 != 10)
                                {
                                    AnimatorControl.isP4Dizziness = true;
                                    IsStopUIControl.isBananaStopP4 = true;
                                    StartCoroutine(StopTiming());
                                    if (AnimalsPowerControl.dragonUsePower && Menu_ChoosePlayer.whyP4 == 5)
                                    {
                                        AnimalsPowerControl.dragonUsePower = false;
                                        AnimatorControl.isP4Skill = false;
                                    }
                                }
                                else
                                {
                                    Destroy(this.gameObject);
                                }
                            }
                        }
                        break;
                }
            }
        }
    }

    IEnumerator StopTiming()
    {
        once = false;
        rb.isKinematic = false;
        isBananaSound = true;
        iscolliderBananaText = true;
        DiceUIControl.isDiceUI = false;
        yield return new WaitForSeconds(4f);
        ChangeCameraControl.changeCameraNum++;
        DiceUIControl.isDiceUI = true;
        yield return new WaitForSeconds(1f);
        IsStopUIControl.isBananaStopUI++;
        Destroy(this.gameObject);
    }
}
