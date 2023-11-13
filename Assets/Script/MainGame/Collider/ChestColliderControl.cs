using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChestColliderControl : MonoBehaviour
{
    public static bool P1_EnterBox = true, P2_EnterBox = true, P3_EnterBox = true, P4_EnterBox = true;
    public int boxPoint, isOpenNumber;
    public Transform target;

    public static int isOpen;

    bool isOpened = false;
    bool isStopProps = false;

    void OpenBoxJudge()
    {
        isOpen = isOpenNumber;
    }
    private void OnTriggerEnter(Collider other)
    {
        if (!PropsControl.isTrans || !AnimalsPowerControl.tigerUsePower)
        {
            if (other.tag == "P1" && P1_EnterBox)
            {
                if (DiceControl.P1_totalNum == boxPoint)
                {
                    P1_EnterBox = false;
                    AnimatorControl.isP1Move = false;
                    if (!isStopProps)
                    {
                        if (!AnimalsPowerControl.dragonUsePower || Menu_ChoosePlayer.whyP1 != 5)
                        {
                            AnimatorControl.isP1Skill = false;
                            StartCoroutine(ChangeCamera());
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
                            StartCoroutine(ChangeCamera());
                        }
                    }
                    if (Menu_ChoosePlayer.whyP1 == 1)
                    {
                        PowerUIControl.isMouseCanUsePower = true;
                        AnimalsPowerControl.mouseIsThisPoint = 1;
                    }
                }
            }
            else if (other.tag == "P2" && P2_EnterBox)
            {
                if (DiceControl.P2_totalNum == boxPoint)
                {
                    P2_EnterBox = false;
                    AnimatorControl.isP2Move = false;
                    if (!isStopProps)
                    {
                        if (!AnimalsPowerControl.dragonUsePower || Menu_ChoosePlayer.whyP2 != 5)
                        {
                            AnimatorControl.isP2Skill = false;
                            StartCoroutine(ChangeCamera());
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
                            StartCoroutine(ChangeCamera());
                        }
                    }
                    if (Menu_ChoosePlayer.whyP2 == 1)
                    {
                        PowerUIControl.isMouseCanUsePower = true;
                        AnimalsPowerControl.mouseIsThisPoint = 1;
                    }
                }
            }
            else if (other.tag == "P3" && P3_EnterBox)
            {
                if (DiceControl.P3_totalNum == boxPoint)
                {
                    P3_EnterBox = false;
                    AnimatorControl.isP3Move = false;
                    if (!isStopProps)
                    {
                        if (!AnimalsPowerControl.dragonUsePower || Menu_ChoosePlayer.whyP3 != 5)
                        {
                            AnimatorControl.isP3Skill = false;
                            StartCoroutine(ChangeCamera());
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
                            StartCoroutine(ChangeCamera());
                        }
                    }
                    if (Menu_ChoosePlayer.whyP3 == 1)
                    {
                        PowerUIControl.isMouseCanUsePower = true;
                        AnimalsPowerControl.mouseIsThisPoint = 1;
                    }
                }
            }
            else if (other.tag == "P4" && P4_EnterBox)
            {
                if (DiceControl.P4_totalNum == boxPoint)
                {
                    P4_EnterBox = false;
                    AnimatorControl.isP4Move = false;
                    if (!isStopProps)
                    {
                        if (!AnimalsPowerControl.dragonUsePower || Menu_ChoosePlayer.whyP4 != 5)
                        {
                            AnimatorControl.isP4Skill = false;
                            StartCoroutine(ChangeCamera());
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
                            StartCoroutine(ChangeCamera());
                        }
                    }
                    if (Menu_ChoosePlayer.whyP4 == 1)
                    {
                        PowerUIControl.isMouseCanUsePower = true;
                        AnimalsPowerControl.mouseIsThisPoint = 1;
                    }
                }
            }
        }
        else
        {
            if (other.tag == "P1" && P1_EnterBox)
            {
                if (DiceControl.P1_totalNum == boxPoint)
                {
                    P1_EnterBox = false;
                    AnimatorControl.isP1Move = false;
                    PropsControl.isTransNum++;
                    if (Menu_ChoosePlayer.whyP1 == 1)
                    {
                        PowerUIControl.isMouseCanUsePower = true;
                        AnimalsPowerControl.mouseIsThisPoint = 1;
                    }
                }
            }
            else if (other.tag == "P2" && P2_EnterBox)
            {
                if (DiceControl.P2_totalNum == boxPoint)
                {
                    P2_EnterBox = false;
                    AnimatorControl.isP2Move = false;
                    PropsControl.isTransNum++;
                    if (Menu_ChoosePlayer.whyP2 == 1)
                    {
                        PowerUIControl.isMouseCanUsePower = true;
                        AnimalsPowerControl.mouseIsThisPoint = 1;
                    }
                }
            }
            else if (other.tag == "P3" && P3_EnterBox)
            {
                if (DiceControl.P3_totalNum == boxPoint)
                {
                    P3_EnterBox = false;
                    AnimatorControl.isP3Move = false;
                    PropsControl.isTransNum++;
                    if (Menu_ChoosePlayer.whyP3 == 1)
                    {
                        PowerUIControl.isMouseCanUsePower = true;
                        AnimalsPowerControl.mouseIsThisPoint = 1;
                    }
                }
            }
            else if (other.tag == "P4" && P4_EnterBox)
            {
                if (DiceControl.P4_totalNum == boxPoint)
                {
                    P4_EnterBox = false;
                    AnimatorControl.isP4Move = false;
                    PropsControl.isTransNum++;
                    if (Menu_ChoosePlayer.whyP4 == 1)
                    {
                        PowerUIControl.isMouseCanUsePower = true;
                        AnimalsPowerControl.mouseIsThisPoint = 1;
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
        if (other.tag == "P1")
        {
            if (DiceControl.P1_totalNum == boxPoint)
            {
                if (!PlayerMoveControl.isMove)
                {
                    Vector3 targetDirection = target.position - other.transform.position;
                    Quaternion targetRotation = Quaternion.LookRotation(targetDirection);
                    other.transform.rotation = Quaternion.Lerp(other.transform.rotation, targetRotation, 5f * Time.deltaTime);
                }
            }
        }
        else if (other.tag == "P2")
        {
            if (DiceControl.P2_totalNum == boxPoint)
            {
                if (!PlayerMoveControl.isMove)
                {
                    Vector3 targetDirection = target.position - other.transform.position;
                    Quaternion targetRotation = Quaternion.LookRotation(targetDirection);
                    other.transform.rotation = Quaternion.Lerp(other.transform.rotation, targetRotation, 5f * Time.deltaTime);
                }
            }
        }
        else if (other.tag == "P3")
        {
            if (DiceControl.P3_totalNum == boxPoint)
            {
                if (!PlayerMoveControl.isMove)
                {
                    Vector3 targetDirection = target.position - other.transform.position;
                    Quaternion targetRotation = Quaternion.LookRotation(targetDirection);
                    other.transform.rotation = Quaternion.Lerp(other.transform.rotation, targetRotation, 5f * Time.deltaTime);
                }
            }
        }
        else if (other.tag == "P4")
        {
            if (DiceControl.P4_totalNum == boxPoint)
            {
                if (!PlayerMoveControl.isMove)
                {
                    Vector3 targetDirection = target.position - other.transform.position;
                    Quaternion targetRotation = Quaternion.LookRotation(targetDirection);
                    other.transform.rotation = Quaternion.Lerp(other.transform.rotation, targetRotation, 5f * Time.deltaTime);
                }
            }
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "P1")
        {
            P1_EnterBox = true;
        }
        if (other.tag == "P2")
        {
            P2_EnterBox = true;
        }
        if (other.tag == "P3")
        {
            P3_EnterBox = true;
        }
        if (other.tag == "P4")
        {
            P4_EnterBox = true;
        }
    }

    IEnumerator ChangeCamera()
    {
        yield return new WaitForSeconds(1f);
        if (!isOpened)
        {
            PlayerMoveControl.isMove = false;
            yield return new WaitForSeconds(1f);
            OpenBoxJudge();
            yield return new WaitForSeconds(0.5f);
        }
        else
        {
            TrueByAnimator();
        }
        CameraMoveControl.isChangeCameraPoint = true;
        yield return new WaitForSeconds(1.5f);
        ChangeCameraControl.changeCameraNum++;
        DiceUIControl.isDiceUI = true;
        isOpened = true;
        CameraMoveControl.isChangeCameraPoint = false;
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
        yield return new WaitForSeconds(3f);
        CameraMoveControl.isChangeCameraPoint = false;
    }

    void TrueByAnimator()
    {
        if (!P1_EnterBox)
        {
            AnimatorControl.isP1Wave = true;
        }
        else if (!P2_EnterBox)
        {
            AnimatorControl.isP2Wave = true;
        }
        else if (!P3_EnterBox)
        {
            AnimatorControl.isP3Wave = true;
        }
        else if (!P4_EnterBox)
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
