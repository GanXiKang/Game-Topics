using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MiniGameColliderControl : MonoBehaviour
{
    public static bool P1_playGame = true, P2_playGame = true, P3_playGame = true, P4_playGame = true ,isMiniGame = false;
    public static float p;

    public int miniGame, MGPoint;

    private void OnTriggerEnter(Collider other)
    {
        if (DiceControl.P1_totalNum == MGPoint || DiceControl.P2_totalNum == MGPoint || DiceControl.P3_totalNum == MGPoint || DiceControl.P4_totalNum == MGPoint)
        {
            if (other.tag == "P1" && P1_playGame)
            {
                p = 1;
                AnimatorControl.isP1Move = false;
                StartCoroutine(StartMiniGame());
            }
            else if (other.tag == "P2" && P2_playGame)
            {
                p = 2;
                AnimatorControl.isP2Move = false;
                StartCoroutine(StartMiniGame());
            }
            else if (other.tag == "P3" && P3_playGame)
            {
                p = 3;
                AnimatorControl.isP3Move = false;
                StartCoroutine(StartMiniGame());
            }
            else if (other.tag == "P4" && P4_playGame)
            {
                p = 4;
                AnimatorControl.isP4Move = false;
                StartCoroutine(StartMiniGame());
            }
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "P1")
        {
            P1_playGame = true;
        }
        else if (other.tag == "P2")
        {
            P2_playGame = true;
        }
        else if (other.tag == "P3")
        {
            P3_playGame = true;
        }
        else if (other.tag == "P4")
        {
            P4_playGame = true;
        }
    }
    IEnumerator StartMiniGame()
    {
        yield return new WaitForSeconds(2f);
        SceneManager.LoadScene(miniGame);
        isMiniGame = true;
        ChangeCameraControl.changeCameraNum++;
        Dice.isDiceUI = true;
    }
}
