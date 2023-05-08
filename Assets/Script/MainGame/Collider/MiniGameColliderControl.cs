using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MiniGameColliderControl : MonoBehaviour
{
    public static bool P1_playGame = true, P2_playGame = true, P3_playGame = true, P4_playGame = true;
    public static float p;

    public int miniGame, MGPoint;

    private void OnTriggerEnter(Collider other)
    {
        if (Dice.P1_totalNum == MGPoint || Dice.P2_totalNum == MGPoint || Dice.P3_totalNum == MGPoint || Dice.P4_totalNum == MGPoint)
        {
            AnimatorControl.isMove = false;
            if (other.tag == "P1" && P1_playGame)
            {
                p = 1;
                StartCoroutine(StartMiniGame());
            }
            else if (other.tag == "P2" && P2_playGame)
            {
                p = 2;
                StartCoroutine(StartMiniGame());
            }
            else if (other.tag == "P3" && P3_playGame)
            {
                p = 3;
                StartCoroutine(StartMiniGame());
            }
            else if (other.tag == "P4" && P4_playGame)
            {
                p = 4;
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
        if (other.tag == "P2")
        {
            P2_playGame = true;
        }
        if (other.tag == "P3")
        {
            P3_playGame = true;
        }
        if (other.tag == "P4")
        {
            P4_playGame = true;
        }
    }
    IEnumerator StartMiniGame()
    {
        yield return new WaitForSeconds(2f);
        SceneManager.LoadScene(miniGame);
        PlayerMoveControl.isMiniGame = true;
    }
}
