using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AnimalsPowerControl : MonoBehaviour
{
    public static bool isMousePower = false, isCowPower = false, isTigerPower = false, isRabbitPower = false;
    public static bool isDragonPower = false, isSnakePower = false, isHorsePower = false, isSheepPower = false;
    public static bool isMonkeyPower = false, isChickenPower = false, isDogPower = false, isPigPower = false;

    public static bool tigerUsePower = false;
    public static int mouseIsThisPoint;

    public Text systemText;

    int r, p;

    void Update()
    {
        if (isMousePower)
        {
            StartCoroutine(MousePower());  
        }

        if (isCowPower)
        {
            systemText.text = "ţ�l�Ӽ��ܣ�";
            SystemTestTextControl.isTimer = true;
            switch (ChangeCameraControl.changeCameraNum)
            {
                case 1:
                    DiceControl.P1_totalNum += 3;
                    break;

                case 2:
                    DiceControl.P2_totalNum += 3;
                    break;

                case 3:
                    DiceControl.P3_totalNum += 3;
                    break;

                case 4:
                    DiceControl.P4_totalNum += 3;
                    break;
            }
            PowerUIControl.animalsPowerUseNum[2]--;
            isCowPower = false;
        }

        if (isTigerPower)
        {
            StartCoroutine(TigerPower());
        }

        if (isRabbitPower)
        {
            systemText.text = "���Ӱl�Ӽ��ܣ�";
            SystemTestTextControl.isTimer = true;
            int d = Random.Range(1, 7);
            switch (ChangeCameraControl.changeCameraNum)
            {
                case 1:
                    DiceControl.P1_totalNum += d;
                    break;

                case 2:
                    DiceControl.P2_totalNum += d;
                    break;

                case 3:
                    DiceControl.P3_totalNum += d;
                    break;

                case 4:
                    DiceControl.P4_totalNum += d;
                    break;
            }
            PowerUIControl.animalsPowerUseNum[4]--;
            isRabbitPower = false;
        }
    }

    IEnumerator MousePower()
    {
        systemText.text = "����l�Ӽ��ܣ�";
        SystemTestTextControl.isTimer = true;
        PowerUIControl.animalsPowerUseNum[1]--;
        isMousePower = false;
        yield return new WaitForSeconds(1f);
        switch (ChangeCameraControl.changeCameraNum)
        {
            case 1:
                if (mouseIsThisPoint == 1)
                {
                    r = Random.Range(5, 16);
                    CoinControl.P1CoinTotal += r;
                    systemText.text = "���ҵ�" + r + "�X��";
                    SystemTestTextControl.isTimer = true;
                }
                else
                {
                    p = Random.Range(0, 7);
                    for (int i = 0; i < 7; i++)
                    {
                        if (i == p)
                        {
                            PropsControl.P1Props[i] += 1;
                        }
                    }
                    systemText.text = "͵��" + PropsControl.propsName[p] + "���ߣ�";
                    SystemTestTextControl.isTimer = true;
                }
                break;

            case 2:
                if (mouseIsThisPoint == 1)
                {
                    r = Random.Range(5, 16);
                    CoinControl.P2CoinTotal += r;
                    systemText.text = "�����ҵ�" + r + "�X��";
                    SystemTestTextControl.isTimer = true;
                }
                else
                {
                    p = Random.Range(0, 7);
                    for (int i = 0; i < 7; i++)
                    {
                        if (i == p)
                        {
                            PropsControl.P2Props[i] += 1;
                        }
                    }
                    systemText.text = "͵��" + PropsControl.propsName[p] + "���ߣ�";
                    SystemTestTextControl.isTimer = true;
                }
                break;

            case 3:
                if (mouseIsThisPoint == 1)
                {
                    r = Random.Range(5, 16);
                    CoinControl.P3CoinTotal += r;
                    systemText.text = "�����ҵ�" + r + "�X��";
                    SystemTestTextControl.isTimer = true;
                }
                else
                {
                    p = Random.Range(0, 7);
                    for (int i = 0; i < 7; i++)
                    {
                        if (i == p)
                        {
                            PropsControl.P3Props[i] += 1;
                        }
                    }
                    systemText.text = "͵��" + PropsControl.propsName[p] + "���ߣ�";
                    SystemTestTextControl.isTimer = true;
                }
                break;

            case 4:
                if (mouseIsThisPoint == 1)
                {
                    r = Random.Range(5, 16);
                    CoinControl.P4CoinTotal += r;
                    systemText.text = "�����ҵ�" + r + "�X��";
                    SystemTestTextControl.isTimer = true;
                }
                else
                {
                    p = Random.Range(0, 7);
                    for (int i = 0; i < 7; i++)
                    {
                        if (i == p)
                        {
                            PropsControl.P4Props[i] += 1;
                        }
                    }
                    systemText.text = "͵��" + PropsControl.propsName[p] + "���ߣ�";
                    SystemTestTextControl.isTimer = true;
                }
                break;
        }
        yield return new WaitForSeconds(2f);
        ChangeCameraControl.changeCameraNum++;
        DiceUIControl.isDiceUI = true;
    }
    IEnumerator TigerPower()
    {
        tigerUsePower = true;
        systemText.text = "�ϻ��l�Ӽ��ܣ�";
        SystemTestTextControl.isTimer = true;
        switch (ChangeCameraControl.changeCameraNum)
        {
            case 1:
                DiceControl.P2_totalNum -= 2;
                DiceControl.P3_totalNum -= 2;
                DiceControl.P4_totalNum -= 2;
                break;

            case 2:
                DiceControl.P1_totalNum -= 2;
                DiceControl.P3_totalNum -= 2;
                DiceControl.P4_totalNum -= 2;
                break;

            case 3:
                DiceControl.P1_totalNum -= 2;
                DiceControl.P2_totalNum -= 2;
                DiceControl.P4_totalNum -= 2;
                break;

            case 4:
                DiceControl.P1_totalNum -= 2;
                DiceControl.P2_totalNum -= 2;
                DiceControl.P3_totalNum -= 2;
                break;
        }
        PowerUIControl.animalsPowerUseNum[3]--;
        isTigerPower = false;
        yield return new WaitForSeconds(1f);
        systemText.text = "ȫ����Һ��ˣ�";
        SystemTestTextControl.isTimer = true; 
        ChangeCameraControl.changeCameraNum++;
        yield return new WaitForSeconds(1f);
        ChangeCameraControl.changeCameraNum++;
        yield return new WaitForSeconds(1f);
        if (Menu_ChoosePlayer.whoPlay >= 3)
        {
            ChangeCameraControl.changeCameraNum++;
        }
        yield return new WaitForSeconds(1f);
        if (Menu_ChoosePlayer.whoPlay >= 4)
        {
            ChangeCameraControl.changeCameraNum++;
        }
        yield return new WaitForSeconds(1f);
        ChangeCameraControl.changeCameraNum++;
        DiceUIControl.isDiceUI = true;
        yield return new WaitForSeconds(2f);
        //tigerUsePower = false;
    }
}
