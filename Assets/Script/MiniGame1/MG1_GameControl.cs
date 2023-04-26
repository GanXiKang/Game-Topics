using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MG1_GameControl : MonoBehaviour
{
    float i, win, lose;                                   // 1 = ����; 2 = ʯ�^; 3 = ��

    public static float playWhat, AIplayWhat; 
    public static bool cameraC, W, L, D;

    public GameObject[] aiScore = new GameObject[3];
    public GameObject[] playerScore = new GameObject[3];

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
                            break;
                        case 2:
                            i++;
                            win++;
                            W = true;
                            break;
                        case 3:
                            i++;
                            lose++;
                            L = true;
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
                            break;
                        case 2:
                            D = true;
                            break;
                        case 3:
                            i++;
                            win++;
                            W = true;
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
                            break;
                        case 2:
                            i++;
                            lose++;
                            L = true;
                            break;
                        case 3:
                            D = true;
                            break;
                    }
                }
            }
        }
        else
        {
            print("�Α�Y��");
            PlayerPlayGameControl();
            if (win >= 3)
            {
                print("�@�Ä�����");
            }
            else
            {
                print("�Α�ʧ����");
            }
            StartCoroutine(BackMainGame());
        }
    }
    void ScoreBoard()
    {
        if (MG1_GameControl.win == 1)
        {
            playerScore[0].SetActive(true);
        }
        if (MG1_GameControl.win == 2)
        {
            playerScore[1].SetActive(true);
        }
        if (MG1_GameControl.win == 3)
        {
            playerScore[2].SetActive(true);
        }
        if (MG1_GameControl.lose == 1)
        {
            aiScore[0].SetActive(true);
        }
        if (MG1_GameControl.lose == 2)
        {
            aiScore[1].SetActive(true);
        }
        if (MG1_GameControl.lose == 3)
        {
            aiScore[2].SetActive(true);
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
