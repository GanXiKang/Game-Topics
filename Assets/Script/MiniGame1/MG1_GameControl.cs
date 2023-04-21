using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MG1_GameControl : MonoBehaviour
{
    float playWhat, AIplayWhat, win, lose, i;                   // 1 = ����; 2 = ʯ�^; 3 = ��

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
                    print("AI������");
                    switch (playWhat)
                    {
                        case 1:
                            print("�ҳ�����");
                            print("ƽ�֣�");
                            D = true;
                            playWhat = 0;
                            break;
                        case 2:
                            print("�ҳ�ʯ�^");
                            print("Win��");
                            i++;
                            win++;
                            W = true;
                            playWhat = 0;
                            break;
                        case 3:
                            print("�ҳ���");
                            print("Lose��");
                            i++;
                            lose++;
                            L = true;
                            playWhat = 0;
                            break;
                    }
                }
                if (AIplayWhat == 2)
                {
                    print("AI��ʯ�^");
                    switch (playWhat)
                    {
                        case 1:
                            print("�ҳ�����");
                            print("Lose��");
                            i++;
                            lose++;
                            L = true;
                            playWhat = 0;
                            break;
                        case 2:
                            print("�ҳ�ʯ�^");
                            print("ƽ�֣�");
                            D = true;
                            playWhat = 0;
                            break;
                        case 3:
                            print("�ҳ���");
                            print("Win��");
                            i++;
                            win++;
                            W = true;
                            playWhat = 0;
                            break;
                    }
                }
                if (AIplayWhat == 3)
                {
                    print("AI�����");
                    switch (playWhat)
                    {
                        case 1:
                            print("�ҳ�����");
                            print("Win��");
                            i++;
                            win++;
                            W = true;
                            playWhat = 0;
                            break;
                        case 2:
                            print("�ҳ�ʯ�^");
                            print("Lose");
                            i++;
                            lose++;
                            L = true;
                            playWhat = 0;
                            break;
                        case 3:
                            print("�ҳ���");
                            print("ƽ�֣�");
                            D = true;
                            playWhat = 0;
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
