using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OrdinaryColliderControl : MonoBehaviour
{
    public static bool P1_Enter = true, P2_Enter = true, P3_Enter = true, P4_Enter = true;
    public int pointNum;

    private void OnTriggerEnter(Collider other)
    {
        if (!PropsControl.isTrans)
        {
            if (!AnimalsPowerControl.tigerUsePower)
            {
                if (other.tag == "P1" && P1_Enter)
                {
                    if (DiceControl.P1_totalNum == pointNum)
                    {
                        P1_Enter = false;
                        AnimatorControl.isP1Move = false;
                        StartCoroutine(ChangeCamera());
                        if (Menu_ChoosePlayer.whyP1 == 1)
                        {
                            PowerUIControl.isMouseCanUsePower = false;
                        }

                        if (!AnimalsPowerControl.dragonUsePower || Menu_ChoosePlayer.whyP1 != 5)
                        {
                            AnimatorControl.isP1Skill = false;
                        }
                        else
                        {
                            AnimatorControl.isDragonFlyWalk = false;
                        }
                    }
                }
                else if (other.tag == "P2" && P2_Enter)
                {
                    if (DiceControl.P2_totalNum == pointNum)
                    {
                        P2_Enter = false;
                        AnimatorControl.isP2Move = false;
                        StartCoroutine(ChangeCamera());
                        if (Menu_ChoosePlayer.whyP2 == 1)
                        {
                            PowerUIControl.isMouseCanUsePower = false;
                        }

                        if (!AnimalsPowerControl.dragonUsePower || Menu_ChoosePlayer.whyP2 != 5)
                        {
                            AnimatorControl.isP2Skill = false;
                        }
                        else
                        {
                            AnimatorControl.isDragonFlyWalk = false;
                        }
                    }
                }
                else if (other.tag == "P3" && P3_Enter)
                {
                    if (DiceControl.P3_totalNum == pointNum)
                    {
                        P3_Enter = false;
                        AnimatorControl.isP3Move = false;
                        StartCoroutine(ChangeCamera());
                        if (Menu_ChoosePlayer.whyP3 == 1)
                        {
                            PowerUIControl.isMouseCanUsePower = false;
                        }

                        if (!AnimalsPowerControl.dragonUsePower || Menu_ChoosePlayer.whyP3 != 5)
                        {
                            AnimatorControl.isP3Skill = false;
                        }
                        else
                        {
                            AnimatorControl.isDragonFlyWalk = false;
                        }
                    }
                }
                else if (other.tag == "P4" && P4_Enter)
                {
                    if (DiceControl.P4_totalNum == pointNum)
                    {
                        P4_Enter = false;
                        AnimatorControl.isP4Move = false;
                        StartCoroutine(ChangeCamera());
                        if (Menu_ChoosePlayer.whyP4 == 1)
                        {
                            PowerUIControl.isMouseCanUsePower = false;
                        }

                        if (!AnimalsPowerControl.dragonUsePower || Menu_ChoosePlayer.whyP4 != 5)
                        {
                            AnimatorControl.isP4Skill = false;
                        }
                        else
                        {
                            AnimatorControl.isDragonFlyWalk = false;
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
    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "P1")
        {
            P1_Enter = true;
        }
        if (other.tag == "P2")
        {
            P2_Enter = true;
        }
        if (other.tag == "P3")
        {
            P3_Enter = true;
        }
        if (other.tag == "P4")
        {
            P4_Enter = true;
        }
    }

    IEnumerator ChangeCamera()
    {
        TrueByAnimator();
        CameraMoveControl.isChangeCameraPoint = true;
        yield return new WaitForSeconds(2f);
        ChangeCameraControl.changeCameraNum++;
        DiceUIControl.isDiceUI = true;
        CameraMoveControl.isChangeCameraPoint = false;
        FalseByAnimator();
    }
    IEnumerator Transposition()
    {
        yield return new WaitForSeconds(1f);
        PropsControl.isTrans = false;
    }

    void TrueByAnimator()
    {
        if (!P1_Enter)
        {
            AnimatorControl.isP1Wave = true;
        }
        else if (!P2_Enter)
        {
            AnimatorControl.isP2Wave = true;
        }
        else if (!P3_Enter)
        {
            AnimatorControl.isP3Wave = true;
        }
        else if (!P4_Enter)
        {
            AnimatorControl.isP4Wave = true;
        }
    }
    void FalseByAnimator()
    {
        AnimatorControl.isP1Wave = false;
        AnimatorControl.isP2Wave = false;
        AnimatorControl.isP3Wave = false;
        AnimatorControl.isP4Wave = false;
    }
}
