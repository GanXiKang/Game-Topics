using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StoreColliderControl : MonoBehaviour
{
    public static bool P1_EnterStore = true, P2_EnterStore = true, P3_EnterStore = true, P4_EnterStore = true;
    public static bool isStoreNotStopUI = false;
    public static int who;

    public int pointNum;
    public Transform target, buying;

    bool isStopProps = false;

    private void OnTriggerEnter(Collider other)
    {
        if (!PropsControl.isTrans)
        {
            if (!AnimalsPowerControl.tigerUsePower)
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
                                isStopProps = false;
                                AnimatorControl.isP1Skill = false;
                                AnimatorControl.isP1Wave = true;
                                StartCoroutine(LookTarget());
                            }
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
                                isStopProps = false;
                                AnimatorControl.isP2Skill = false;
                                AnimatorControl.isP2Wave = true;
                                StartCoroutine(LookTarget());
                            }
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
                                isStopProps = false;
                                AnimatorControl.isP3Skill = false;
                                AnimatorControl.isP3Wave = true;
                                StartCoroutine(LookTarget());
                            }
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
                                isStopProps = false;
                                AnimatorControl.isP4Skill = false;
                                AnimatorControl.isP4Wave = true;
                                StartCoroutine(LookTarget());
                            }
                        }
                        if (Menu_ChoosePlayer.whyP4 == 1)
                        {
                            PowerUIControl.isMouseCanUsePower = true;
                            AnimalsPowerControl.mouseIsThisPoint = 2;
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
    private void OnTriggerStay(Collider other)
    {
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
        else if (other.tag == "P2")
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
        else if (other.tag == "P3")
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
        else if (other.tag == "P4")
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

        if (other.tag == "StopProps")
        {
            isStopProps = true;
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
    }

    IEnumerator LookTarget()
    {
        yield return new WaitForSeconds(1f);
        PlayerMoveControl.isMove = false;
        StoreUIControl.isStore = true;
        isStoreNotStopUI = true;
        FalseByAnimator();
    }
    IEnumerator DragonFlyNow()
    {
        AnimatorControl.isDragonFlyWalk = false;
        CameraMoveControl.isChangeCameraPoint = true;
        yield return new WaitForSeconds(2f);
        ChangeCameraControl.changeCameraNum++;
        DiceUIControl.isDiceUI = true;
        CameraMoveControl.isChangeCameraPoint = false;
    }
    IEnumerator StopRound()
    {
        isStopProps = false;
        CameraMoveControl.isChangeCameraPoint = true;
        yield return new WaitForSeconds(4f);
        ChangeCameraControl.changeCameraNum++;
        DiceUIControl.isDiceUI = true;
        CameraMoveControl.isChangeCameraPoint = false;
    }
    IEnumerator Transposition()
    {
        yield return new WaitForSeconds(1f);
        PropsControl.isTrans = false;
    }

    void FalseByAnimator()
    {
        AnimatorControl.isP1Wave = false;
        AnimatorControl.isP2Wave = false;
        AnimatorControl.isP3Wave = false;
        AnimatorControl.isP4Wave = false;
    }
}

