using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MiniGame1Control : MonoBehaviour
{
    float playWhat = 0;                   // 1 = 剪刀; 2 = 石頭; 3 = 佈
    float AIplayWhat = 0;
    void Awake()
    {
        print("狸貓猜拳！");
    }
    
    public void Button_Scissors()
    {
        print("我出剪刀");
        playWhat = 1;
    }
    public void Button_Stone()
    {
        print("我出石頭");
        playWhat = 2;
    }
    public void Button_Cloth()
    {
        print("我出佈");
        playWhat = 3;
    }
    void Update()
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
                        print("平局！");
                        playWhat = 0;
                        break;
                    case 2:
                        print("Win！");
                        playWhat = 0;
                        break;
                    case 3:
                        print("Lose！");
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
                        print("Lose！");
                        playWhat = 0;
                        break;
                    case 2:
                        print("平局！");
                        playWhat = 0;
                        break;
                    case 3:
                        print("Win！");
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
                        print("Win！");
                        playWhat = 0;
                        break;
                    case 2:
                        print("Lose");
                        playWhat = 0;
                        break;
                    case 3:
                        print("平局！");
                        playWhat = 0;
                        break;
                }
            }
        }
    }
}
