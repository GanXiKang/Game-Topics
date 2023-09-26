using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AnimalsPowerControl : MonoBehaviour
{
    public static bool isMousePower = false, isCowPower = false, isTigerPower = false, isRabbitPower = false;
    public static bool isDragonPower = false, isSnakePower = false, isHorsePower = false, isSheepPower = false;
    public static bool isMonkeyPower = false, isChickenPower = false, isDogPower = false, isPigPower = false;

    public static bool cowUsePower = false;
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
            StartCoroutine(CowPower());
        }

        if (isTigerPower)
        {
            StartCoroutine(TigerPower());
        }

        if (isRabbitPower)
        {
            StartCoroutine(RabbitPower());
        }
    }

    IEnumerator MousePower()
    {
        systemText.text = "老鼠發動技能！";
        SystemTestTextControl.isTimer = true;
        PowerUIControl.animalsPowerUseNum[1]--;
        isMousePower = false;
        AnimalsSkillAnimator();
        yield return new WaitForSeconds(1f);
        switch (ChangeCameraControl.changeCameraNum)
        {
            case 1:
                if (mouseIsThisPoint == 1)
                {
                    r = Random.Range(5, 16);
                    CoinControl.P1CoinTotal += r;
                    systemText.text = "尋找到" + r + "錢！";
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
                    systemText.text = "偷走" + PropsControl.propsName[p] + "道具！";
                    SystemTestTextControl.isTimer = true;
                }
                break;

            case 2:
                if (mouseIsThisPoint == 1)
                {
                    r = Random.Range(5, 16);
                    CoinControl.P2CoinTotal += r;
                    systemText.text = "老鼠尋找到" + r + "錢！";
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
                    systemText.text = "偷走" + PropsControl.propsName[p] + "道具！";
                    SystemTestTextControl.isTimer = true;
                }
                break;

            case 3:
                if (mouseIsThisPoint == 1)
                {
                    r = Random.Range(5, 16);
                    CoinControl.P3CoinTotal += r;
                    systemText.text = "老鼠尋找到" + r + "錢！";
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
                    systemText.text = "偷走" + PropsControl.propsName[p] + "道具！";
                    SystemTestTextControl.isTimer = true;
                }
                break;

            case 4:
                if (mouseIsThisPoint == 1)
                {
                    r = Random.Range(5, 16);
                    CoinControl.P4CoinTotal += r;
                    systemText.text = "老鼠尋找到" + r + "錢！";
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
                    systemText.text = "偷走" + PropsControl.propsName[p] + "道具！";
                    SystemTestTextControl.isTimer = true;
                }
                break;
        }
        AnimalsSkillAnimator();
        yield return new WaitForSeconds(2f);
        ChangeCameraControl.changeCameraNum++;
        DiceUIControl.isDiceUI = true;
    }
    IEnumerator CowPower()
    {
        systemText.text = "牛發動技能！";
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
        cowUsePower = true;
        AnimalsSkillAnimator();
        yield return new WaitForSeconds(5f);
        cowUsePower = false;
        AnimalsSkillAnimator();
    }
    IEnumerator TigerPower()
    {
        tigerUsePower = true;
        systemText.text = "老虎發動技能！";
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
        AnimalsSkillAnimator();
        yield return new WaitForSeconds(1f);
        systemText.text = "全部玩家后退！";
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
        AnimalsSkillAnimator();
        yield return new WaitForSeconds(1f);
        ChangeCameraControl.changeCameraNum++;
        DiceUIControl.isDiceUI = true;
        yield return new WaitForSeconds(2f);
        tigerUsePower = false;
    }
    IEnumerator RabbitPower()
    {
        systemText.text = "兔子發動技能！";
        SystemTestTextControl.isTimer = true;
        switch (ChangeCameraControl.changeCameraNum)
        {
            case 1:
                DiceControl.P1_totalNum += PowerUIControl.rabbitPowerChooseNum;
                break;

            case 2:
                DiceControl.P2_totalNum += PowerUIControl.rabbitPowerChooseNum;
                break;

            case 3:
                DiceControl.P3_totalNum += PowerUIControl.rabbitPowerChooseNum;
                break;

            case 4:
                DiceControl.P4_totalNum += PowerUIControl.rabbitPowerChooseNum;
                break;
        }
        PowerUIControl.animalsPowerUseNum[4]--;
        isRabbitPower = false;
        AnimalsSkillAnimator();
        yield return new WaitForSeconds(4f);
        AnimalsSkillAnimator();
    }

    void AnimalsSkillAnimator()
    {
        switch (ChangeCameraControl.changeCameraNum)
        {
            case 1:
                if (!AnimatorControl.isP1Skill)
                {
                    AnimatorControl.isP1Skill = true;
                }
                else
                {
                    AnimatorControl.isP1Skill = false;
                }
                break;

            case 2:
                if (!AnimatorControl.isP2Skill)
                {
                    AnimatorControl.isP2Skill = true;
                }
                else
                {
                    AnimatorControl.isP2Skill = false;
                }
                break;

            case 3:
                if (!AnimatorControl.isP3Skill)
                {
                    AnimatorControl.isP3Skill = true;
                }
                else
                {
                    AnimatorControl.isP3Skill = false;
                }
                break;

            case 4:
                if (!AnimatorControl.isP4Skill)
                {
                    AnimatorControl.isP4Skill = true;
                }
                else
                {
                    AnimatorControl.isP4Skill = false;
                }
                break;
        }
    }
}
