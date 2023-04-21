using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MG1_GameControl : MonoBehaviour
{
    float win, lose, i;                                   // 1 = 剪刀; 2 = 石頭; 3 = 佈

    public static float playWhat, AIplayWhat; 
    public static bool cameraC, W, L, D;

    public void Button_Scissors()
    {
        playWhat = 1;
        cameraC = true;
    }
    public void Button_Stone()
    {
        playWhat = 2;
        cameraC = true;
    }
    public void Button_Cloth()
    {
        playWhat = 3;
        cameraC = true;
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
                            playWhat = 0;
                            break;
                        case 2:
                            i++;
                            win++;
                            W = true;
                            playWhat = 0;
                            break;
                        case 3:
                            i++;
                            lose++;
                            L = true;
                            playWhat = 0;
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
                            playWhat = 0;
                            break;
                        case 2:
                            D = true;
                            playWhat = 0;
                            break;
                        case 3:
                            i++;
                            win++;
                            W = true;
                            playWhat = 0;
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
                            playWhat = 0;
                            break;
                        case 2:
                            i++;
                            lose++;
                            L = true;
                            playWhat = 0;
                            break;
                        case 3:
                            D = true;
                            playWhat = 0;
                            break;
                    }
                }
            }
        }
        else
        {
            print("游戲結束");
            PlayerPlayGameControl();
            if (win >= 3)
            {
                print("獲得勝利！");
            }
            else
            {
                print("游戲失敗！");
            }
            StartCoroutine(BackMainGame());
        }
    }
    void PlayerPlayGameControl()
    {
        if (MG1_BoxColliderControl.p == 1)
        {
            MG1_BoxColliderControl.P1_playGame = false;
            MG1_BoxColliderControl.p = 0;
        }
        if (MG1_BoxColliderControl.p == 2)
        {
            MG1_BoxColliderControl.P2_playGame = false;
            MG1_BoxColliderControl.p = 0;
        }
        if (MG1_BoxColliderControl.p == 3)
        {
            MG1_BoxColliderControl.P3_playGame = false;
            MG1_BoxColliderControl.p = 0;
        }
        if (MG1_BoxColliderControl.p == 4)
        {
            MG1_BoxColliderControl.P4_playGame = false;
            MG1_BoxColliderControl.p = 0;
        }
    }
    IEnumerator BackMainGame()
    {
        yield return new WaitForSeconds(2f);
        SceneManager.LoadScene(0);
    }
}
