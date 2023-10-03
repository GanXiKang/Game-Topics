using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MG5_GameResultControl : MonoBehaviour
{
    public static bool win = false;
    public GameObject gameWinUI, gameLoseUI;
    public AudioSource BGM;
    public AudioClip gameWin, gameLose;

    void Update()
    {
        if (MG5_UIControl.timer >= 45)
        {
            if (MG5_HookControl.score >= 15)
            {
                win = true;
                MGFinishAwardControl.isWin = true;
                MG5_BrownBearControl.isWin = true;
                gameWinUI.SetActive(true);
                BGM.PlayOneShot(gameWin);
            }
            else
            {
                MG5_BrownBearControl.isLose = true;
                gameLoseUI.SetActive(true);
                BGM.PlayOneShot(gameLose);
            }
            StartCoroutine(BackMainGame());
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
        PlayerPlayGameControl();
        yield return new WaitForSeconds(5f);
        MG5_HookControl.score = 0;
        MG5_UIControl.timer = 0;
        MG5_UIControl.isStart = false;
        SceneManager.LoadScene(7);
        win = false;
        MiniGameColliderControl.isMiniGame = false;
        MGFinishAwardControl.miniGame = 5;
        MGFinishAwardControl.isFinishMG = true;
    }
}
