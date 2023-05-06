using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MG1_GameControl : MonoBehaviour
{
    Animator ani;
    float i, win, lose;                                   // 1 = Ότµ¶; 2 = Κ―ξ^; 3 = Ρ

    public static float playWhat, AIplayWhat; 
    public static bool cameraC, cameraEnd, W, L, D, playerAniWin, playerAniLose;

    public GameObject[] aiScore = new GameObject[3];
    public GameObject[] playerScore = new GameObject[3];

    public AudioSource BGM;
    public AudioClip button, winM, loseM, gameWin, gameLose;

    public void Button_Scissors()
    {
        playWhat = 1;
        cameraC = true;
        BGM.PlayOneShot(button);
    }
    public void Button_Stone()
    {
        playWhat = 2;
        cameraC = true;
        BGM.PlayOneShot(button);
    }
    public void Button_Cloth()
    {
        playWhat = 3;
        cameraC = true;
        BGM.PlayOneShot(button);
    }

    void Start()
    {
        ani = GetComponent<Animator>();
    }
    void Update()
    {
        if (i <= 5 && win < 3 && lose < 3)
        {
            if (playWhat != 0)
            {
                AIplayWhat = Random.Range(1, 4);
                if (AIplayWhat == 1)
                {
                    switch (playWhat)
                    {
                        case 1:
                            D = true;
                            break;
                        case 2:
                            i++;
                            win++;
                            W = true;
                            BGM.PlayOneShot(winM);
                            break;
                        case 3:
                            i++;
                            lose++;
                            L = true;
                            BGM.PlayOneShot(loseM);
                            break;
                    }
                }
                if (AIplayWhat == 2)
                {
                    switch (playWhat)
                    {
                        case 1:
                            i++;
                            lose++;
                            L = true;
                            BGM.PlayOneShot(loseM);
                            break;
                        case 2:
                            D = true;
                            break;
                        case 3:
                            i++;
                            win++;
                            W = true;
                            BGM.PlayOneShot(winM);
                            break;
                    }
                }
                if (AIplayWhat == 3)
                {
                    switch (playWhat)
                    {
                        case 1:
                            i++;
                            win++;
                            W = true;
                            BGM.PlayOneShot(winM);
                            break;
                        case 2:
                            i++;
                            lose++;
                            L = true;
                            BGM.PlayOneShot(loseM);
                            break;
                        case 3:
                            D = true;
                            break;
                    }
                }
                ScoreBoard();
            }
        }
        else
        {
            cameraEnd = true;
            if (win >= 3)
            {
                playerAniWin = true;
                BGM.PlayOneShot(gameWin);
            }
            else
            {
                playerAniLose = true;
                BGM.PlayOneShot(gameLose);
            }
            StartCoroutine(BackMainGame());
        }
    }
    void ScoreBoard()
    {
        if (win == 1)
        {
            playerScore[0].SetActive(true);
        }
        if (win == 2)
        {
            playerScore[1].SetActive(true);
        }
        if (win == 3)
        {
            playerScore[2].SetActive(true);
        }
        if (lose == 1)
        {
            aiScore[0].SetActive(true);
        }
        if (lose == 2)
        {
            aiScore[1].SetActive(true);
        }
        if (lose == 3)
        {
            aiScore[2].SetActive(true);
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
        playerAniWin = false;
        playerAniLose = false;
        cameraEnd = false;
        SceneManager.LoadScene(7);
        PointJudgeControl.changeScene = true;
    }
}
