using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MG2_GameResultControl : MonoBehaviour
{
    public static bool win, lose;

    public GameObject gameWinUI, gameLoseUI;
    public AudioSource BGM;
    public AudioClip gameWin, gameLose, goodApple, badApple;

    bool gameResult = true;

    void Update()
    {
        if (MG2_UIControl.gameTime <= 0 && gameResult)
        {
            if (MG2_CollectScoreControl.score >= 30)
            {
                win = true;
                gameWinUI.SetActive(true);
                BGM.PlayOneShot(gameWin);
            }
            else
            {
                lose = true;
                gameLoseUI.SetActive(true);
                BGM.PlayOneShot(gameLose);
            }
            StartCoroutine(BackMainGame());
        }
        else 
        {
            if (MG2_CollectScoreControl.goodA)
            {
                BGM.PlayOneShot(goodApple);
                MG2_CollectScoreControl.goodA = false;
            }
            if (MG2_CollectScoreControl.badA)
            {
                BGM.PlayOneShot(badApple);
                MG2_CollectScoreControl.badA = false;
            }
        }
    }
    void PlayerPlayGameControl()
    {
        if (MiniGameColliderControl.p == 1)
        {
            MiniGameColliderControl.P1_playGame = false;
            MiniGameColliderControl.p = 0;
        }
        if (MiniGameColliderControl.p == 2)
        {
            MiniGameColliderControl.P2_playGame = false;
            MiniGameColliderControl.p = 0;
        }
        if (MiniGameColliderControl.p == 3)
        {
            MiniGameColliderControl.P3_playGame = false;
            MiniGameColliderControl.p = 0;
        }
        if (MiniGameColliderControl.p == 4)
        {
            MiniGameColliderControl.P4_playGame = false;
            MiniGameColliderControl.p = 0;
        }
    }
    IEnumerator BackMainGame()
    {
        gameResult = false;
        PlayerPlayGameControl();
        yield return new WaitForSeconds(5f);
        win = false;
        lose = false;
        MG2_StartButtonControl.isStart = false;
        MG2_CollectScoreControl.score = 0;
        MG2_UIControl.gameTime = 45;
        SceneManager.LoadScene(7);
        MiniGameColliderControl.isMiniGame = false;
    }
}
