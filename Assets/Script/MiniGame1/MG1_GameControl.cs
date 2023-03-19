using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MG1_GameControl : MonoBehaviour
{
    float playWhat = 0;                   // 1 = ����; 2 = ʯ�^; 3 = ��
    float AIplayWhat = 0;
    float win = 0;
    float lose = 0;
    float i = 0;
    void Awake()
    {
        print("��؈��ȭ��");
    }
    public void Button_Scissors()
    {
        playWhat = 1;
    }
    public void Button_Stone()
    {
        playWhat = 2;
    }
    public void Button_Cloth()
    {
        playWhat = 3;
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
                            playWhat = 0;
                            break;
                        case 2:
                            print("�ҳ�ʯ�^");
                            print("Win��");
                            i++;
                            win++;
                            playWhat = 0;
                            break;
                        case 3:
                            print("�ҳ���");
                            print("Lose��");
                            i++;
                            lose++;
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
                            playWhat = 0;
                            break;
                        case 2:
                            print("�ҳ�ʯ�^");
                            print("ƽ�֣�");
                            playWhat = 0;
                            break;
                        case 3:
                            print("�ҳ���");
                            print("Win��");
                            i++;
                            win++;
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
                            playWhat = 0;
                            break;
                        case 2:
                            print("�ҳ�ʯ�^");
                            print("Lose");
                            i++;
                            lose++;
                            playWhat = 0;
                            break;
                        case 3:
                            print("�ҳ���");
                            print("ƽ�֣�");
                            playWhat = 0;
                            break;
                    }
                }
            }
        }
        else
        {
            print("�Α�Y��");
            MG1_BoxColliderControl.playGame = false;
            if (win >= 3)
            {
                print("�@�Ä�����");
            }
            else
            {
                print("�Α�ʧ����");
            }
            SceneManager.LoadScene(0);
        }
    }
}
