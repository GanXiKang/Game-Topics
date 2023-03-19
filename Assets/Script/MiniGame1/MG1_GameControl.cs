using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MG1_GameControl : MonoBehaviour
{
    float playWhat = 0;                   // 1 = 剪刀; 2 = 石頭; 3 = 佈
    float AIplayWhat = 0;
    float win = 0;
    float lose = 0;
    float i = 0;
    void Awake()
    {
        print("狸貓猜拳！");
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
                    print("AI出剪刀");
                    switch (playWhat)
                    {
                        case 1:
                            print("我出剪刀");
                            print("平局！");
                            playWhat = 0;
                            break;
                        case 2:
                            print("我出石頭");
                            print("Win！");
                            i++;
                            win++;
                            playWhat = 0;
                            break;
                        case 3:
                            print("我出佈");
                            print("Lose！");
                            i++;
                            lose++;
                            playWhat = 0;
                            break;
                    }
                }
                if (AIplayWhat == 2)
                {
                    print("AI出石頭");
                    switch (playWhat)
                    {
                        case 1:
                            print("我出剪刀");
                            print("Lose！");
                            i++;
                            lose++;
                            playWhat = 0;
                            break;
                        case 2:
                            print("我出石頭");
                            print("平局！");
                            playWhat = 0;
                            break;
                        case 3:
                            print("我出佈");
                            print("Win！");
                            i++;
                            win++;
                            playWhat = 0;
                            break;
                    }
                }
                if (AIplayWhat == 3)
                {
                    print("AI出剪佈");
                    switch (playWhat)
                    {
                        case 1:
                            print("我出剪刀");
                            print("Win！");
                            i++;
                            win++;
                            playWhat = 0;
                            break;
                        case 2:
                            print("我出石頭");
                            print("Lose");
                            i++;
                            lose++;
                            playWhat = 0;
                            break;
                        case 3:
                            print("我出佈");
                            print("平局！");
                            playWhat = 0;
                            break;
                    }
                }
            }
        }
        else
        {
            print("游戲結束");
            MG1_BoxColliderControl.playGame = false;
            if (win >= 3)
            {
                print("獲得勝利！");
            }
            else
            {
                print("游戲失敗！");
            }
            SceneManager.LoadScene(0);
        }
    }
}
