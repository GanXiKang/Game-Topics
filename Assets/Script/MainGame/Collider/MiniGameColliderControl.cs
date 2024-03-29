using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MiniGameColliderControl : MonoBehaviour
{
    public static bool P1_playGame = true, P2_playGame = true, P3_playGame = true, P4_playGame = true, isMiniGame = false;
    public static bool isRacoonCall, isSlothCall, isFoxCall, isOstrichCall, isBearCall, isDolphinCall;
    public static float p;

    public int miniGame, MGPoint;
    public Transform target;

    bool isStopProps = false;

    private void OnTriggerEnter(Collider other)
    {
        if (!PropsControl.isTrans && !AnimalsPowerControl.tigerUsePower)
        {
            if (other.tag == "P1" && P1_playGame)
            {
                if (DiceControl.P1_totalNum == MGPoint)
                {
                    p = 1;
                    AnimatorControl.isP1Move = false;
                    if (!isStopProps)
                    {
                        if (!AnimalsPowerControl.dragonUsePower || Menu_ChoosePlayer.whyP1 != 5)
                        {
                            AnimatorControl.isP1Skill = false;
                            StartCoroutine(StartMiniGame());
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
                            StartCoroutine(StartMiniGame());
                        }
                        isStopProps = false;
                    }
                    if (Menu_ChoosePlayer.whyP1 == 1)
                    {
                        PowerUIControl.isMouseCanUsePower = false;
                    }
                }
            }
            else if(other.tag == "P2" && P2_playGame)
            {
                if (DiceControl.P2_totalNum == MGPoint)
                {
                    p = 2;
                    AnimatorControl.isP2Move = false;
                    if (!isStopProps)
                    {
                        if (!AnimalsPowerControl.dragonUsePower || Menu_ChoosePlayer.whyP2 != 5)
                        {
                            AnimatorControl.isP2Skill = false;
                            StartCoroutine(StartMiniGame());
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
                            StartCoroutine(StartMiniGame());
                        }
                        isStopProps = false;
                    }
                    if (Menu_ChoosePlayer.whyP2 == 1)
                    {
                        PowerUIControl.isMouseCanUsePower = false;
                    }
                }
            }
            else if (other.tag == "P3" && P3_playGame)
            {
                if (DiceControl.P3_totalNum == MGPoint)
                {
                    p = 3;
                    AnimatorControl.isP3Move = false;
                    if (!isStopProps)
                    {
                        if (!AnimalsPowerControl.dragonUsePower || Menu_ChoosePlayer.whyP3 != 5)
                        {
                            AnimatorControl.isP3Skill = false;
                            StartCoroutine(StartMiniGame());
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
                            StartCoroutine(StartMiniGame());
                        }
                        isStopProps = false;
                    }
                    if (Menu_ChoosePlayer.whyP3 == 1)
                    {
                        PowerUIControl.isMouseCanUsePower = false;
                    }
                }
            }
            else if (other.tag == "P4" && P4_playGame)
            {
                if (DiceControl.P4_totalNum == MGPoint)
                {
                    p = 4;
                    AnimatorControl.isP4Move = false;
                    if (!isStopProps)
                    {
                        if (!AnimalsPowerControl.dragonUsePower || Menu_ChoosePlayer.whyP4 != 5)
                        {
                            AnimatorControl.isP4Skill = false;
                            StartCoroutine(StartMiniGame());
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
                            StartCoroutine(StartMiniGame());
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
            if (other.tag == "P1" && P1_playGame)
            {
                if (DiceControl.P1_totalNum == MGPoint)
                {
                    P1_playGame = false;
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
            else if (other.tag == "P2" && P2_playGame)
            {
                if (DiceControl.P2_totalNum == MGPoint)
                {
                    P2_playGame = false;
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
            else if (other.tag == "P3" && P3_playGame)
            {
                if (DiceControl.P3_totalNum == MGPoint)
                {
                    P3_playGame = false;
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
            else if (other.tag == "P4" && P4_playGame)
            {
                if (DiceControl.P4_totalNum == MGPoint)
                {
                    P4_playGame = false;
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
    private void OnTriggerStay(Collider other)
    {
        if (other.tag == "P1")
        {
            if (DiceControl.P1_totalNum == MGPoint)
            {
                if (!PlayerMoveControl.isMove)
                {
                    MGAnimalsAnimatorControl.isWave = true;
                    Vector3 targetDirection = target.position - other.transform.position;
                    Quaternion targetRotation = Quaternion.LookRotation(targetDirection);
                    other.transform.rotation = Quaternion.Lerp(other.transform.rotation, targetRotation, 5f * Time.deltaTime);
                }
            }
        }
        else if (other.tag == "P2")
        {
            if (DiceControl.P2_totalNum == MGPoint)
            {
                if (!PlayerMoveControl.isMove)
                {
                    MGAnimalsAnimatorControl.isWave = true;
                    Vector3 targetDirection = target.position - other.transform.position;
                    Quaternion targetRotation = Quaternion.LookRotation(targetDirection);
                    other.transform.rotation = Quaternion.Lerp(other.transform.rotation, targetRotation, 5f * Time.deltaTime);
                }
            }
        }
        else if (other.tag == "P3")
        {
            if (DiceControl.P3_totalNum == MGPoint)
            {
                if (!PlayerMoveControl.isMove)
                {
                    MGAnimalsAnimatorControl.isWave = true;
                    Vector3 targetDirection = target.position - other.transform.position;
                    Quaternion targetRotation = Quaternion.LookRotation(targetDirection);
                    other.transform.rotation = Quaternion.Lerp(other.transform.rotation, targetRotation, 5f * Time.deltaTime);
                }
            }
        }
        else if (other.tag == "P4")
        {
            if (DiceControl.P4_totalNum == MGPoint)
            {
                if (!PlayerMoveControl.isMove)
                {
                    MGAnimalsAnimatorControl.isWave = true;
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
            P1_playGame = true;
            MGAnimalsAnimatorControl.isBye = true;
        }
        else if (other.tag == "P2")
        {
            P2_playGame = true;
            MGAnimalsAnimatorControl.isBye = true;
        }
        else if (other.tag == "P3")
        {
            P3_playGame = true;
            MGAnimalsAnimatorControl.isBye = true;
        }
        else if (other.tag == "P4")
        {
            P4_playGame = true;
            MGAnimalsAnimatorControl.isBye = true;
        }

        if (other.tag == "StopProps")
        {
            isStopProps = false;
        }
    }

    IEnumerator StartMiniGame()
    {
        yield return new WaitForSeconds(1f);
        AnimalsCall();
        PlayerMoveControl.isMove = false;
        yield return new WaitForSeconds(1f);
        SceneManager.LoadScene(miniGame);
        isMiniGame = true;
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

    void AnimalsCall()
    {
        switch (miniGame)
        {
            case 1:
                isRacoonCall = true;
                break;

            case 2:
                isSlothCall = true;
                break;

            case 3:
                isFoxCall = true;
                break;

            case 4:
                isOstrichCall = true;
                break;

            case 5:
                isBearCall = true;
                break;

            case 6:
                isDolphinCall = true;
                break;
        }
    }
}
