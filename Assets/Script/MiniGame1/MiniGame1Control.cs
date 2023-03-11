using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MiniGame1Control : MonoBehaviour
{
    float playWhat = 0;                   // 1 = ����; 2 = ʯ�^; 3 = ��
    float AIplayWhat = 0;
    void Awake()
    {
        print("��؈��ȭ��");
    }
    
    public void Button_Scissors()
    {
        print("�ҳ�����");
        playWhat = 1;
    }
    public void Button_Stone()
    {
        print("�ҳ�ʯ�^");
        playWhat = 2;
    }
    public void Button_Cloth()
    {
        print("�ҳ���");
        playWhat = 3;
    }
    void Update()
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
                        print("ƽ�֣�");
                        playWhat = 0;
                        break;
                    case 2:
                        print("Win��");
                        playWhat = 0;
                        break;
                    case 3:
                        print("Lose��");
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
                        print("Lose��");
                        playWhat = 0;
                        break;
                    case 2:
                        print("ƽ�֣�");
                        playWhat = 0;
                        break;
                    case 3:
                        print("Win��");
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
                        print("Win��");
                        playWhat = 0;
                        break;
                    case 2:
                        print("Lose");
                        playWhat = 0;
                        break;
                    case 3:
                        print("ƽ�֣�");
                        playWhat = 0;
                        break;
                }
            }
        }
    }
}
