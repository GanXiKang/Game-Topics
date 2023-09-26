using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MiniGameColliderControl : MonoBehaviour
{
    public static bool P1_playGame = true, P2_playGame = true, P3_playGame = true, P4_playGame = true ,isMiniGame = false;
    public static float p;

    public int miniGame, MGPoint;
    public Transform target;

    private void OnTriggerEnter(Collider other)
    {
        if (!PropsControl.isTrans)
        {
            if (!AnimalsPowerControl.tigerUsePower)
            {
                if (other.tag == "P1" && P1_playGame)
                {
                    if (DiceControl.P1_totalNum == MGPoint)
                    {
                        p = 1;
                        AnimatorControl.isP1Move = false;
                        AnimatorControl.isP2Skill = false;
                        StartCoroutine(StartMiniGame());
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
                        p = 2;
                        AnimatorControl.isP2Move = false;
                        AnimatorControl.isP2Skill = false;
                        StartCoroutine(StartMiniGame());
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
                        AnimatorControl.isP3Skill = false;
                        StartCoroutine(StartMiniGame());
                    }
                    if (Menu_ChoosePlayer.whyP3 == 1)
                    {
                        PowerUIControl.isMouseCanUsePower = false;
                    }
                }
                else if (other.tag == "P4" && P4_playGame)
                {
                    if (DiceControl.P4_totalNum == MGPoint)
                    {
                        p = 4;
                        AnimatorControl.isP4Move = false;
                        AnimatorControl.isP4Skill = false;
                        StartCoroutine(StartMiniGame());
                        if (Menu_ChoosePlayer.whyP4 == 1)
                        {
                            PowerUIControl.isMouseCanUsePower = false;
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
    }
    IEnumerator StartMiniGame()
    {
        yield return new WaitForSeconds(1f);
        PlayerMoveControl.isMove = false;
        yield return new WaitForSeconds(1f);
        SceneManager.LoadScene(miniGame);
        isMiniGame = true;
        ChangeCameraControl.changeCameraNum++;
        DiceUIControl.isDiceUI = true;
    }
    IEnumerator Transposition()
    {
        yield return new WaitForSeconds(1f);
        PropsControl.isTrans = false;
    }
}
