using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StoreColliderControl : MonoBehaviour
{
    public static bool P1_EnterStore = true, P2_EnterStore = true, P3_EnterStore = true, P4_EnterStore = true;
    public static int who;

    public int pointNum;
    public Transform target, buying;

    bool isStopProps = false;

    private void OnTriggerEnter(Collider other)
    {
        if (!PropsControl.isTrans && !AnimalsPowerControl.tigerUsePower)
        {
            if (other.tag == "P1" && P1_EnterStore)
            {
                if (DiceControl.P1_totalNum == pointNum)
                {
                    who = 1;
                    P1_EnterStore = false;
                    AnimatorControl.isP1Move = false;
                    if (!isStopProps)
                    {
                        if (!AnimalsPowerControl.dragonUsePower || Menu_ChoosePlayer.whyP1 != 5)
                        {
                            AnimatorControl.isP1Skill = false;
                            AnimatorControl.isP1Wave = true;
                            StartCoroutine(LookTarget());
                        }
                        else
                        {
                            StartCoroutine(DragonFlyNow());
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
                            AnimatorControl.isP1Skill = false;
                            AnimatorControl.isP1Wave = true;
                            StartCoroutine(LookTarget());
                        }
                        isStopProps = false;
                    }
                    if (Menu_ChoosePlayer.whyP1 == 1)
                    {
                        PowerUIControl.isMouseCanUsePower = true;
                        AnimalsPowerControl.mouseIsThisPoint = 2;
                    }
                }
            }
            else if(other.tag == "P2" && P2_EnterStore)
            {
                if (DiceControl.P2_totalNum == pointNum)
                {
                    who = 2;
                    P2_EnterStore = false;
                    AnimatorControl.isP2Move = false;
                    if (!isStopProps)
                    {
                        if (!AnimalsPowerControl.dragonUsePower || Menu_ChoosePlayer.whyP2 != 5)
                        {
                            AnimatorControl.isP2Skill = false;
                            AnimatorControl.isP2Wave = true;
                            StartCoroutine(LookTarget());
                        }
                        else
                        {
                            StartCoroutine(DragonFlyNow());
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
                            AnimatorControl.isP2Skill = false;
                            AnimatorControl.isP2Wave = true;
                            StartCoroutine(LookTarget());
                        }
                        isStopProps = false;
                    }
                    if (Menu_ChoosePlayer.whyP2 == 1)
                    {
                        PowerUIControl.isMouseCanUsePower = true;
                        AnimalsPowerControl.mouseIsThisPoint = 2;
                    }
                }
            }
            else if (other.tag == "P3" && P3_EnterStore)
            {
                if (DiceControl.P3_totalNum == pointNum)
                {
                    who = 3;
                    P3_EnterStore = false;
                    AnimatorControl.isP3Move = false;
                    if (!isStopProps)
                    {
                        if (!AnimalsPowerControl.dragonUsePower || Menu_ChoosePlayer.whyP3 != 5)
                        {
                            AnimatorControl.isP3Skill = false;
                            AnimatorControl.isP3Wave = true;
                            StartCoroutine(LookTarget());
                        }
                        else
                        {
                            StartCoroutine(DragonFlyNow());
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
                            AnimatorControl.isP3Skill = false;
                            AnimatorControl.isP3Wave = true;
                            StartCoroutine(LookTarget());
                        }
                        isStopProps = false;
                    }
                    if (Menu_ChoosePlayer.whyP3 == 1)
                    {
                        PowerUIControl.isMouseCanUsePower = true;
                        AnimalsPowerControl.mouseIsThisPoint = 2;
                    }
                }
            }
            else if (other.tag == "P4" && P4_EnterStore)
            {
                if (DiceControl.P4_totalNum == pointNum)
                {
                    who = 4;
                    P4_EnterStore = false;
                    AnimatorControl.isP4Move = false;
                    if (!isStopProps)
                    {
                        if (!AnimalsPowerControl.dragonUsePower || Menu_ChoosePlayer.whyP4 != 5)
                        {
                            AnimatorControl.isP4Skill = false;
                            AnimatorControl.isP4Wave = true;
                            StartCoroutine(LookTarget());
                        }
                        else
                        {
                            StartCoroutine(DragonFlyNow());
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
                            AnimatorControl.isP4Skill = false;
                            AnimatorControl.isP4Wave = true;
                            StartCoroutine(LookTarget());
                        }
                        isStopProps = false;
                    }
                    if (Menu_ChoosePlayer.whyP4 == 1)
                    {
                        PowerUIControl.isMouseCanUsePower = true;
                        AnimalsPowerControl.mouseIsThisPoint = 2;
                    }
                }
            }
        }
        else
        {
            if (other.tag == "P1" && P1_EnterStore)
            {
                if (DiceControl.P1_totalNum == pointNum)
                {
                    P1_EnterStore = false;
                    AnimatorControl.isP1Move = false;
                    if (PropsControl.isTrans)
                    {
                        PropsControl.isTransNum++;
                    }
                    if (Menu_ChoosePlayer.whyP1 == 1)
                    {
                        PowerUIControl.isMouseCanUsePower = true;
                        AnimalsPowerControl.mouseIsThisPoint = 2;
                    }
                }
            }
            else if (other.tag == "P2" && P2_EnterStore)
            {
                if (DiceControl.P2_totalNum == pointNum)
                {
                    P2_EnterStore = false;
                    AnimatorControl.isP2Move = false;
                    if (PropsControl.isTrans)
                    {
                        PropsControl.isTransNum++;
                    }
                    if (Menu_ChoosePlayer.whyP2 == 1)
                    {
                        PowerUIControl.isMouseCanUsePower = true;
                        AnimalsPowerControl.mouseIsThisPoint = 2;
                    }
                }
            }
            else if (other.tag == "P3" && P3_EnterStore)
            {
                if (DiceControl.P3_totalNum == pointNum)
                {
                    P3_EnterStore = false;
                    AnimatorControl.isP3Move = false;
                    if (PropsControl.isTrans)
                    {
                        PropsControl.isTransNum++;
                    }
                    if (Menu_ChoosePlayer.whyP3 == 1)
                    {
                        PowerUIControl.isMouseCanUsePower = true;
                        AnimalsPowerControl.mouseIsThisPoint = 2;
                    }
                }
            }
            else if (other.tag == "P4" && P4_EnterStore)
            {
                if (DiceControl.P4_totalNum == pointNum)
                {
                    P4_EnterStore = false;
                    AnimatorControl.isP4Move = false;
                    if (PropsControl.isTrans)
                    {
                        PropsControl.isTransNum++;
                    }
                    if (Menu_ChoosePlayer.whyP4 == 1)
                    {
                        PowerUIControl.isMouseCanUsePower = true;
                        AnimalsPowerControl.mouseIsThisPoint = 2;
                    }
                }
            }
        }

        if (other.tag == "StopProps")
        {
            isStopProps = true;
        }
    }
    private void OnTriggerStay(Collider other)
    {
        switch (ChangeCameraControl.changeCameraNum)
        {
            case 1:
                if (other.tag == "P1")
                {
                    if (DiceControl.P1_totalNum == pointNum)
                    {
                        if (!PlayerMoveControl.isMove)
                        {
                            if (StoreUIControl.isStore)
                            {
                                Vector3 targetDirection = target.position - other.transform.position;
                                Quaternion targetRotation = Quaternion.LookRotation(targetDirection);
                                other.transform.rotation = Quaternion.Lerp(other.transform.rotation, targetRotation, 5f * Time.deltaTime);
                            }
                            if (StoreUIControl.isBuying)
                            {
                                Vector3 buyingDirection = buying.position - other.transform.position;
                                Quaternion buyingRotation = Quaternion.LookRotation(buyingDirection);
                                other.transform.rotation = Quaternion.Lerp(other.transform.rotation, buyingRotation, 5f * Time.deltaTime);
                            }
                        }
                    }
                }
                break;

            case 2:
                if (other.tag == "P2")
                {
                    if (DiceControl.P2_totalNum == pointNum)
                    {
                        if (!PlayerMoveControl.isMove)
                        {
                            if (!StoreUIControl.isBuying)
                            {
                                Vector3 targetDirection = target.position - other.transform.position;
                                Quaternion targetRotation = Quaternion.LookRotation(targetDirection);
                                other.transform.rotation = Quaternion.Lerp(other.transform.rotation, targetRotation, 5f * Time.deltaTime);
                            }
                            else
                            {
                                Vector3 buyingDirection = buying.position - other.transform.position;
                                Quaternion buyingRotation = Quaternion.LookRotation(buyingDirection);
                                other.transform.rotation = Quaternion.Lerp(other.transform.rotation, buyingRotation, 5f * Time.deltaTime);
                            }
                        }
                    }
                }
                break;

            case 3:
                if (other.tag == "P3")
                {
                    if (DiceControl.P3_totalNum == pointNum)
                    {
                        if (!PlayerMoveControl.isMove)
                        {
                            if (!StoreUIControl.isBuying)
                            {
                                Vector3 targetDirection = target.position - other.transform.position;
                                Quaternion targetRotation = Quaternion.LookRotation(targetDirection);
                                other.transform.rotation = Quaternion.Lerp(other.transform.rotation, targetRotation, 5f * Time.deltaTime);
                            }
                            else
                            {
                                Vector3 buyingDirection = buying.position - other.transform.position;
                                Quaternion buyingRotation = Quaternion.LookRotation(buyingDirection);
                                other.transform.rotation = Quaternion.Lerp(other.transform.rotation, buyingRotation, 5f * Time.deltaTime);
                            }
                        }
                    }
                }
                break;

            case 4:
                if (other.tag == "P4")
                {
                    if (DiceControl.P4_totalNum == pointNum)
                    {
                        if (!PlayerMoveControl.isMove)
                        {
                            if (!StoreUIControl.isBuying)
                            {
                                Vector3 targetDirection = target.position - other.transform.position;
                                Quaternion targetRotation = Quaternion.LookRotation(targetDirection);
                                other.transform.rotation = Quaternion.Lerp(other.transform.rotation, targetRotation, 5f * Time.deltaTime);
                            }
                            else
                            {
                                Vector3 buyingDirection = buying.position - other.transform.position;
                                Quaternion buyingRotation = Quaternion.LookRotation(buyingDirection);
                                other.transform.rotation = Quaternion.Lerp(other.transform.rotation, buyingRotation, 5f * Time.deltaTime);
                            }
                        }
                    }
                }
                break;
        }
   
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "P1")
        {
            P1_EnterStore = true;
        }
        if (other.tag == "P2")
        {
            P2_EnterStore = true;
        }
        if (other.tag == "P3")
        {
            P3_EnterStore = true;
        }
        if (other.tag == "P4")
        {
            P4_EnterStore = true;
        }

        if (other.tag == "StopProps")
        {
            isStopProps = false;
        }
    }

    IEnumerator LookTarget()
    {
        yield return new WaitForSeconds(1f);
        PlayerMoveControl.isMove = false;
        StoreUIControl.isStore = true;
        FalseByAnimator();
    }
    IEnumerator DragonFlyNow()
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
    IEnumerator StopRound()
    {
        CameraMoveControl.isChangeCameraPoint = true;
        yield return new WaitForSeconds(3f);
        CameraMoveControl.isChangeCameraPoint = false;
    }

    void FalseByAnimator()
    {
        AnimatorControl.isP1Wave = false;
        AnimatorControl.isP2Wave = false;
        AnimatorControl.isP3Wave = false;
        AnimatorControl.isP4Wave = false;
    }
}

