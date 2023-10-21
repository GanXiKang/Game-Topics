using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class AnimalsPowerControl : MonoBehaviour
{
    public static bool isMousePower = false, isCowPower = false, isTigerPower = false, isRabbitPower = false;
    public static bool isDragonPower = false, isSnakePower = false, isHorsePower = false, isSheepPower = false;
    public static bool isMonkeyPower = false, isChickenPower = false, isDogPower = false, isPigPower = false;

    public static int mouseIsThisPoint;
    public static bool cowUsePower = false;
    public static bool tigerUsePower = false;
    public static bool horseTriplePower = false;
    

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

        if (isDragonPower)
        {
            StartCoroutine(DragonPower());
        }

        if (isSnakePower)
        {
            StartCoroutine(SnakePower());
        }

        if (isHorsePower)
        {
            StartCoroutine(HorsePower());
        }

        if (isSheepPower)
        {
            StartCoroutine(SheepPower());
        }

        if (isMonkeyPower)
        {
            StartCoroutine(MonkeyPower());
        }

        if (isChickenPower)
        {
            StartCoroutine(ChickenPower());
        }

        if (isDogPower)
        {
            StartCoroutine(DogPower());
        }

        if (isPigPower)
        {
            StartCoroutine(PigPower());
        }
    }

    IEnumerator MousePower()
    {
        isMousePower = false;
        systemText.text = "老鼠發動技能！";
        SystemTestTextControl.isTimer = true;
        PowerUIControl.animalsPowerUseNum[1]--;
        CameraMoveControl.isChangeCameraPoint = true;
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
                    p = Random.Range(0, 6);
                    for (int i = 0; i < 6; i++)
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
                    p = Random.Range(0, 6);
                    for (int i = 0; i < 6; i++)
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
                    p = Random.Range(0, 6);
                    for (int i = 0; i < 6; i++)
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
                    p = Random.Range(0, 6);
                    for (int i = 0; i < 6; i++)
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
        CameraMoveControl.isChangeCameraPoint = false;
        ChangeCameraControl.changeCameraNum++;
        DiceUIControl.isDiceUI = true;
    }

    IEnumerator CowPower()
    {
        isCowPower = false;
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
        cowUsePower = true;
        AnimalsSkillAnimator();
        yield return new WaitForSeconds(5f);
        cowUsePower = false;
    }

    IEnumerator TigerPower()
    {
        isTigerPower = false;
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
        AnimalsSkillAnimator();
        CameraMoveControl.isChangeCameraPoint = true;
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
        AnimalsSkillAnimator();
        yield return new WaitForSeconds(1f);
        if (Menu_ChoosePlayer.whoPlay >= 4)
        {
            ChangeCameraControl.changeCameraNum++;
        }
        yield return new WaitForSeconds(1f);
        ChangeCameraControl.changeCameraNum++;
        DiceUIControl.isDiceUI = true;
        CameraMoveControl.isChangeCameraPoint = false;
        yield return new WaitForSeconds(2f);
        tigerUsePower = false;
    }

    IEnumerator RabbitPower()
    {
        isRabbitPower = false;
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
        AnimalsSkillAnimator();
        yield return new WaitForSeconds(1f);
    }

    IEnumerator DragonPower()
    {
        isDragonPower = false;
        systemText.text = "龍發動技能！";
        SystemTestTextControl.isTimer = true;
        PowerUIControl.animalsPowerUseNum[5]--;
        yield return new WaitForSeconds(2f);
    }

    IEnumerator SnakePower()
    {
        isSnakePower = false;
        systemText.text = "蛇發動技能！";
        SystemTestTextControl.isTimer = true;
        PowerUIControl.animalsPowerUseNum[6]--;
        yield return new WaitForSeconds(2f);
    }

    IEnumerator HorsePower()
    {
        isHorsePower = false;
        horseTriplePower = true;
        systemText.text = "馬發動技能！";
        SystemTestTextControl.isTimer = true;
        PowerUIControl.animalsPowerUseNum[7]--;
        AnimalsSkillAnimator();
        CameraMoveControl.isChangeCameraPoint = true;
        yield return new WaitForSeconds(2f);
        SceneManager.LoadScene(9);
        DiceUIControl.isDiceScene = true;
        CameraMoveControl.isChangeCameraPoint = false;
    }

    IEnumerator SheepPower()
    {
        isSheepPower = false;
        systemText.text = "羊發動技能！";
        SystemTestTextControl.isTimer = true;
        PowerUIControl.animalsPowerUseNum[8]--;
        yield return new WaitForSeconds(2f);
    }

    IEnumerator MonkeyPower()
    {
        isMonkeyPower = false;
        systemText.text = "猴子發動技能！";
        SystemTestTextControl.isTimer = true;
        PowerUIControl.animalsPowerUseNum[9]--;
        yield return new WaitForSeconds(2f);
    }

    IEnumerator ChickenPower()
    {
        isChickenPower = false;
        systemText.text = "雞發動技能！";
        SystemTestTextControl.isTimer = true;
        PowerUIControl.animalsPowerUseNum[9]--;
        yield return new WaitForSeconds(2f);
    }

    IEnumerator DogPower()
    {
        isDogPower = false;
        systemText.text = "狗發動技能！";
        SystemTestTextControl.isTimer = true;
        PowerUIControl.animalsPowerUseNum[10]--;
        yield return new WaitForSeconds(2f);
    }

    IEnumerator PigPower()
    {
        isPigPower = false;
        systemText.text = "豬發動技能！";
        SystemTestTextControl.isTimer = true;
        PowerUIControl.animalsPowerUseNum[12]--;
        yield return new WaitForSeconds(2f);
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
