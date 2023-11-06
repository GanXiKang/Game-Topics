using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BananaControl : MonoBehaviour
{
    public static int pointNum;
    public static bool iscolliderBananaText = false;
    public static bool isBananaSound = false;

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "P1")
        {
            if (!MonkeyPowerControl.isP1InsBanana)
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
            else
            {
                MonkeyPowerControl.isP1InsBanana = false;
            }
        }
        else if (other.tag == "P2")
        {
            if (!MonkeyPowerControl.isP2InsBanana)
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
            else
            {
                MonkeyPowerControl.isP2InsBanana = false;
            }
        }
        else if (other.tag == "P3")
        {
            if (!MonkeyPowerControl.isP3InsBanana)
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
            else
            {
                MonkeyPowerControl.isP3InsBanana = false;
            }
        }
        else if (other.tag == "P4")
        {
            if (!MonkeyPowerControl.isP4InsBanana)
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
            else
            {
                MonkeyPowerControl.isP4InsBanana = false;
            }
        }
    }
    IEnumerator StopTiming()
    {
        isBananaSound = true;
        iscolliderBananaText = true;
        yield return new WaitForSeconds(5f);
        IsStopUIControl.isBananaStopUI++;
        Destroy(this.gameObject);
    }
}
