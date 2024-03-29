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
    public static bool rabbitUsePower = false;
    public static int dragonPowerRound = 0;
    public static bool dragonUsePower = false;
    public static int snakePoisonWho;
    public static bool snakeUsePower = false;
    public static bool horseUsePower = false, horseTriplePower = false;
    public static bool sheepLuckyPower = false;
    public static bool monkeyPutBananaPower = false;
    public static int chickenPowerRound = 0;
    public static bool chickenUsePower = false;
    public static bool dogUsePower = false;
    public static int pigPowerRound = 0;
    public static bool pigCanUsePower = true, pigPowerGood = false, pigPowerBad = false;
    public static bool isPowerEffects = false;

    AudioSource BGM;
    public AudioClip mouse, mouseGet, cow, tiger, tigerBack, rabbit, dragon, dragonPorps, snake;
    public AudioClip horse, goat, monkey, chicken, dog, pig, pigGood, pigBad;
    public Text systemText;

    int r, p, e;

    void Start()
    {
        BGM = GetComponent<AudioSource>();
    }
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
        DragonPowerEnd();

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
        ChickenPowerEnd();

        if (isDogPower)
        {
            StartCoroutine(DogPower());
        }

        if (isPigPower)
        {
            StartCoroutine(PigPower());
        }
        PigPowerCanUse();
    }

    IEnumerator MousePower()
    {
        isMousePower = false;
        systemText.text = "老鼠發動技能！";
        SystemTestTextControl.isTimer = true;
        PowerUIControl.animalsPowerUseNum[1]--;
        CameraMoveControl.isChangeCameraPoint = true;
        AnimalsSkillAnimator();
        BGM.PlayOneShot(mouse);
        yield return new WaitForSeconds(1f);
        switch (ChangeCameraControl.changeCameraNum)
        {
            case 1:
                if (mouseIsThisPoint == 1)
                {
                    r = Random.Range(5, 16);
                    CoinControl.P1CoinTotal += r;
                    systemText.text = "尋找到" + r + "貓貓幣！";
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
                    systemText.text = "老鼠尋找到" + r + "貓貓幣！";
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
                    systemText.text = "老鼠尋找到" + r + "貓貓幣！";
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
                    systemText.text = "老鼠尋找到" + r + "貓貓幣！";
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
        BGM.PlayOneShot(mouseGet);
        isPowerEffects = true;
        yield return new WaitForSeconds(2f);
        CameraMoveControl.isChangeCameraPoint = false;
        ChangeCameraControl.changeCameraNum++;
        DiceUIControl.isDiceUI = true;
    }

    IEnumerator CowPower()
    {
        isCowPower = false;
        cowUsePower = true;
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
        AnimalsSkillAnimator();
        BGM.PlayOneShot(cow);
        isPowerEffects = true;
        yield return new WaitForSeconds(2f);
    }

    IEnumerator TigerPower()
    {
        isTigerPower = false;
        tigerUsePower = true;
        systemText.text = "老虎發動技能！";
        SystemTestTextControl.isTimer = true;
        PowerUIControl.animalsPowerUseNum[3]--;
        AnimalsSkillAnimator();
        BGM.PlayOneShot(tiger);
        isPowerEffects = true;
        CameraMoveControl.isChangeCameraPoint = true;
        yield return new WaitForSeconds(1f);
        AnimalsSkillAnimator();
        switch (ChangeCameraControl.changeCameraNum)
        {
            case 1:
                if (chickenUsePower || Menu_ChoosePlayer.whyP2 != 10)
                {
                    DiceControl.P2_totalNum -= 2;
                    AnimatorControl.isP2Move = true;
                }
                if (!chickenUsePower || Menu_ChoosePlayer.whyP3 != 10)
                {
                    DiceControl.P3_totalNum -= 2;
                    AnimatorControl.isP3Move = true;
                }
                if (!chickenUsePower || Menu_ChoosePlayer.whyP4 != 10)
                {
                    DiceControl.P4_totalNum -= 2;
                    AnimatorControl.isP4Move = true;
                }
                break;

            case 2:
                if (!chickenUsePower || Menu_ChoosePlayer.whyP1 != 10)
                {
                    DiceControl.P1_totalNum -= 2;
                    AnimatorControl.isP1Move = true;
                }
                if (!chickenUsePower || Menu_ChoosePlayer.whyP3 != 10)
                {
                    DiceControl.P3_totalNum -= 2;
                    AnimatorControl.isP3Move = true;
                }
                if (!chickenUsePower || Menu_ChoosePlayer.whyP4 != 10)
                {
                    DiceControl.P4_totalNum -= 2;
                    AnimatorControl.isP4Move = true;
                }
                break;

            case 3:
                if (!chickenUsePower || Menu_ChoosePlayer.whyP1 != 10)
                {
                    DiceControl.P1_totalNum -= 2;
                    AnimatorControl.isP1Move = true;
                }
                if (!chickenUsePower || Menu_ChoosePlayer.whyP2 != 10)
                {
                    DiceControl.P2_totalNum -= 2;
                    AnimatorControl.isP2Move = true;
                }
                if (!chickenUsePower || Menu_ChoosePlayer.whyP4 != 10)
                {
                    DiceControl.P4_totalNum -= 2;
                    AnimatorControl.isP4Move = true;
                }
                break;

            case 4:
                if (!chickenUsePower || Menu_ChoosePlayer.whyP1 != 10)
                {
                    DiceControl.P1_totalNum -= 2;
                    AnimatorControl.isP1Move = true;
                }
                if (!chickenUsePower || Menu_ChoosePlayer.whyP2 != 10)
                {
                    DiceControl.P2_totalNum -= 2;
                    AnimatorControl.isP2Move = true;
                }
                if (!chickenUsePower || Menu_ChoosePlayer.whyP3 != 10)
                {
                    DiceControl.P3_totalNum -= 2;
                    AnimatorControl.isP3Move = true;
                }
                break;
        }
        yield return new WaitForSeconds(1f);
        systemText.text = "全部玩家後退！";
        SystemTestTextControl.isTimer = true;
        BGM.PlayOneShot(tigerBack);
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
        CameraMoveControl.isChangeCameraPoint = false;
        yield return new WaitForSeconds(2f);
        tigerUsePower = false;
    }

    IEnumerator RabbitPower()
    {
        isRabbitPower = false;
        rabbitUsePower = true;
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
        BGM.PlayOneShot(rabbit);
        isPowerEffects = true;
        yield return new WaitForSeconds(1f);
    }

    IEnumerator DragonPower()
    {
        isDragonPower = false;
        dragonPowerRound = 0;
        systemText.text = "龍發動技能！";
        SystemTestTextControl.isTimer = true;
        PowerUIControl.animalsPowerUseNum[5]--;
        AnimalsSkillAnimator();
        BGM.PlayOneShot(dragon);
        CameraMoveControl.isChangeCameraPoint = true;
        yield return new WaitForSeconds(2f);
        switch (ChangeCameraControl.changeCameraNum)
        {
            case 1:
                p = Random.Range(0, 7);
                for (int i = 0; i < 7; i++)
                {
                    if (i == p)
                    {
                        PropsControl.P1Props[i] += 1;
                    }
                }
                systemText.text = "獲得" + PropsControl.propsName[p] + "道具！";
                SystemTestTextControl.isTimer = true;
                break;

            case 2:
                p = Random.Range(0, 7);
                for (int i = 0; i < 7; i++)
                {
                    if (i == p)
                    {
                        PropsControl.P2Props[i] += 1;
                    }
                }
                systemText.text = "獲得" + PropsControl.propsName[p] + "道具！";
                SystemTestTextControl.isTimer = true;
                break;

            case 3:
                p = Random.Range(0, 7);
                for (int i = 0; i < 7; i++)
                {
                    if (i == p)
                    {
                        PropsControl.P3Props[i] += 1;
                    }
                }
                systemText.text = "獲得" + PropsControl.propsName[p] + "道具！";
                SystemTestTextControl.isTimer = true;
                break;

            case 4:
                p = Random.Range(0, 7);
                for (int i = 0; i < 7; i++)
                {
                    if (i == p)
                    {
                        PropsControl.P4Props[i] += 1;
                    }
                }
                systemText.text = "獲得" + PropsControl.propsName[p] + "道具！";
                SystemTestTextControl.isTimer = true;
                break;
        }
        BGM.PlayOneShot(dragonPorps);
        isPowerEffects = true;
        yield return new WaitForSeconds(2f);
        dragonUsePower = true;
        DiceUIControl.isDiceUI = true;
        CameraMoveControl.isChangeCameraPoint = false;
    }

    IEnumerator SnakePower()
    {
        isSnakePower = false;
        snakeUsePower = true;
        systemText.text = "蛇發動技能！";
        SystemTestTextControl.isTimer = true;
        PowerUIControl.animalsPowerUseNum[6]--;
        AnimalsSkillAnimator();
        BGM.PlayOneShot(snake);
        CameraMoveControl.isChangeCameraPoint = true;
        yield return new WaitForSeconds(2f);
        BGM.PlayOneShot(snake);
        isPowerEffects = true;
        switch (ChangeCameraControl.changeCameraNum)
        {
            case 1:
                snakePoisonWho = Random.Range(1, Menu_ChoosePlayer.whoPlay);
                switch (snakePoisonWho)
                {
                    case 1:
                        systemText.text = "毒了" + RoundUIControl.Player[2].ToString();
                        SystemTestTextControl.isTimer = true;
                        if (!AnimalsPowerControl.chickenUsePower || Menu_ChoosePlayer.whyP2 != 10)
                        {
                            IsStopUIControl.isSnakePowerStopUI += 1;
                            AnimatorControl.isP2Dizziness = true;
                            IsStopUIControl.isPoisonStopP2 = true;
                            if (dragonUsePower && Menu_ChoosePlayer.whyP2 == 5)
                            {
                                dragonUsePower = false;
                                AnimatorControl.isP2Skill = false;
                            }
                        }
                        else
                        {
                            yield return new WaitForSeconds(2f);
                            systemText.text = "雞處於無敵狀態";
                            SystemTestTextControl.isTimer = true;
                        }
                        break;

                    case 2:
                        systemText.text = "毒了" + RoundUIControl.Player[3].ToString();
                        SystemTestTextControl.isTimer = true;
                        if (!AnimalsPowerControl.chickenUsePower || Menu_ChoosePlayer.whyP3 != 10)
                        {
                            IsStopUIControl.isSnakePowerStopUI += 1;
                            AnimatorControl.isP3Dizziness = true;
                            IsStopUIControl.isPoisonStopP3 = true;
                            if (dragonUsePower && Menu_ChoosePlayer.whyP3 == 5)
                            {
                                dragonUsePower = false;
                                AnimatorControl.isP3Skill = false;
                            }
                        }
                        else
                        {
                            yield return new WaitForSeconds(2f);
                            systemText.text = "雞處於無敵狀態";
                            SystemTestTextControl.isTimer = true;
                        }
                        break;

                    case 3:
                        systemText.text = "毒了" + RoundUIControl.Player[4].ToString();
                        SystemTestTextControl.isTimer = true;
                        if (!AnimalsPowerControl.chickenUsePower || Menu_ChoosePlayer.whyP4 != 10)
                        {
                            IsStopUIControl.isSnakePowerStopUI += 1;
                            AnimatorControl.isP4Dizziness = true;
                            IsStopUIControl.isPoisonStopP4 = true;
                            if (dragonUsePower && Menu_ChoosePlayer.whyP4 == 5)
                            {
                                dragonUsePower = false;
                                AnimatorControl.isP4Skill = false;
                            }
                        }
                        else
                        {
                            yield return new WaitForSeconds(2f);
                            systemText.text = "雞處於無敵狀態";
                            SystemTestTextControl.isTimer = true;
                        }
                        break;
                }
                break;

            case 2:
                snakePoisonWho = Random.Range(1, Menu_ChoosePlayer.whoPlay);
                switch (snakePoisonWho)
                {
                    case 1:
                        systemText.text = "毒了" + RoundUIControl.Player[1].ToString();
                        SystemTestTextControl.isTimer = true;
                        if (!AnimalsPowerControl.chickenUsePower || Menu_ChoosePlayer.whyP1 != 10)
                        {
                            IsStopUIControl.isSnakePowerStopUI += 1;
                            AnimatorControl.isP1Dizziness = true;
                            IsStopUIControl.isPoisonStopP1 = true;
                            if (dragonUsePower && Menu_ChoosePlayer.whyP1 == 5)
                            {
                                dragonUsePower = false;
                                AnimatorControl.isP1Skill = false;
                            }
                        }
                        else
                        {
                            yield return new WaitForSeconds(2f);
                            systemText.text = "雞處於無敵狀態";
                            SystemTestTextControl.isTimer = true;
                        }
                        break;

                    case 2:
                        systemText.text = "毒了" + RoundUIControl.Player[3].ToString();
                        SystemTestTextControl.isTimer = true;
                        if (!AnimalsPowerControl.chickenUsePower || Menu_ChoosePlayer.whyP3 != 10)
                        {
                            IsStopUIControl.isSnakePowerStopUI += 1;
                            AnimatorControl.isP3Dizziness = true;
                            IsStopUIControl.isPoisonStopP3 = true;
                            if (dragonUsePower && Menu_ChoosePlayer.whyP3 == 5)
                            {
                                dragonUsePower = false;
                                AnimatorControl.isP3Skill = false;
                            }
                        }
                        else
                        {
                            yield return new WaitForSeconds(2f);
                            systemText.text = "雞處於無敵狀態";
                            SystemTestTextControl.isTimer = true;
                        }
                        break;

                    case 3:
                        systemText.text = "毒了" + RoundUIControl.Player[4].ToString();
                        SystemTestTextControl.isTimer = true;
                        if (!AnimalsPowerControl.chickenUsePower || Menu_ChoosePlayer.whyP4 != 10)
                        {
                            IsStopUIControl.isSnakePowerStopUI += 1;
                            AnimatorControl.isP4Dizziness = true;
                            IsStopUIControl.isPoisonStopP4 = true;
                            if (dragonUsePower && Menu_ChoosePlayer.whyP4 == 5)
                            {
                                dragonUsePower = false;
                                AnimatorControl.isP4Skill = false;
                            }
                        }
                        else
                        {
                            yield return new WaitForSeconds(2f);
                            systemText.text = "雞處於無敵狀態";
                            SystemTestTextControl.isTimer = true;
                        }
                        break;
                }
                break;

            case 3:
                snakePoisonWho = Random.Range(1, Menu_ChoosePlayer.whoPlay);
                switch (snakePoisonWho)
                {
                    case 1:
                        systemText.text = "毒了" + RoundUIControl.Player[1].ToString();
                        SystemTestTextControl.isTimer = true;
                        if (!AnimalsPowerControl.chickenUsePower || Menu_ChoosePlayer.whyP1 != 10)
                        {
                            IsStopUIControl.isSnakePowerStopUI += 1;
                            AnimatorControl.isP1Dizziness = true;
                            IsStopUIControl.isPoisonStopP1 = true;
                            if (dragonUsePower && Menu_ChoosePlayer.whyP1 == 5)
                            {
                                dragonUsePower = false;
                                AnimatorControl.isP1Skill = false;
                            }
                        }
                        else
                        {
                            yield return new WaitForSeconds(2f);
                            systemText.text = "雞處於無敵狀態";
                            SystemTestTextControl.isTimer = true;
                        }
                        break;

                    case 2:
                        systemText.text = "毒了" + RoundUIControl.Player[2].ToString();
                        SystemTestTextControl.isTimer = true;
                        if (!AnimalsPowerControl.chickenUsePower || Menu_ChoosePlayer.whyP2 != 10)
                        {
                            IsStopUIControl.isSnakePowerStopUI += 1;
                            AnimatorControl.isP2Dizziness = true;
                            IsStopUIControl.isPoisonStopP2 = true;
                            if (dragonUsePower && Menu_ChoosePlayer.whyP2 == 5)
                            {
                                dragonUsePower = false;
                                AnimatorControl.isP2Skill = false;
                            }
                        }
                        else
                        {
                            yield return new WaitForSeconds(2f);
                            systemText.text = "雞處於無敵狀態";
                            SystemTestTextControl.isTimer = true;
                        }
                        break;

                    case 3:
                        systemText.text = "毒了" + RoundUIControl.Player[4].ToString();
                        SystemTestTextControl.isTimer = true;
                        if (!AnimalsPowerControl.chickenUsePower || Menu_ChoosePlayer.whyP4 != 10)
                        {
                            IsStopUIControl.isSnakePowerStopUI += 1;
                            AnimatorControl.isP4Dizziness = true;
                            IsStopUIControl.isPoisonStopP4 = true;
                            if (dragonUsePower && Menu_ChoosePlayer.whyP4 == 5)
                            {
                                dragonUsePower = false;
                                AnimatorControl.isP4Skill = false;
                            }
                        }
                        else
                        {
                            yield return new WaitForSeconds(2f);
                            systemText.text = "雞處於無敵狀態";
                            SystemTestTextControl.isTimer = true;
                        }
                        break;
                }
                break;

            case 4:
                snakePoisonWho = Random.Range(1, Menu_ChoosePlayer.whoPlay);
                switch (snakePoisonWho)
                {
                    case 1:
                        systemText.text = "毒了" + RoundUIControl.Player[1].ToString();
                        SystemTestTextControl.isTimer = true;
                        if (!AnimalsPowerControl.chickenUsePower || Menu_ChoosePlayer.whyP1 != 10)
                        {
                            IsStopUIControl.isSnakePowerStopUI += 1;
                            AnimatorControl.isP1Dizziness = true;
                            IsStopUIControl.isPoisonStopP1 = true;
                            if (dragonUsePower && Menu_ChoosePlayer.whyP1 == 5)
                            {
                                dragonUsePower = false;
                                AnimatorControl.isP1Skill = false;
                            }
                        }
                        else
                        {
                            yield return new WaitForSeconds(2f);
                            systemText.text = "雞處於無敵狀態";
                            SystemTestTextControl.isTimer = true;
                        }
                        break;

                    case 2:
                        systemText.text = "毒了" + RoundUIControl.Player[2].ToString();
                        SystemTestTextControl.isTimer = true;
                        if (!AnimalsPowerControl.chickenUsePower || Menu_ChoosePlayer.whyP2 != 10)
                        {
                            IsStopUIControl.isSnakePowerStopUI += 1;
                            AnimatorControl.isP2Dizziness = true;
                            IsStopUIControl.isPoisonStopP2 = true;
                            if (dragonUsePower && Menu_ChoosePlayer.whyP2 == 5)
                            {
                                dragonUsePower = false;
                                AnimatorControl.isP2Skill = false;
                            }
                        }
                        else
                        {
                            yield return new WaitForSeconds(2f);
                            systemText.text = "雞處於無敵狀態";
                            SystemTestTextControl.isTimer = true;
                        }
                        break;

                    case 3:
                        systemText.text = "毒了" + RoundUIControl.Player[3].ToString();
                        SystemTestTextControl.isTimer = true;
                        if (!AnimalsPowerControl.chickenUsePower || Menu_ChoosePlayer.whyP3 != 10)
                        {
                            IsStopUIControl.isSnakePowerStopUI += 1;
                            AnimatorControl.isP3Dizziness = true;
                            IsStopUIControl.isPoisonStopP3 = true;
                            if (dragonUsePower && Menu_ChoosePlayer.whyP3 == 5)
                            {
                                dragonUsePower = false;
                                AnimatorControl.isP3Skill = false;
                            }
                        }
                        else
                        {
                            yield return new WaitForSeconds(2f);
                            systemText.text = "雞處於無敵狀態";
                            SystemTestTextControl.isTimer = true;
                        }
                        break;
                }
                break;
        }
        yield return new WaitForSeconds(2f);
        AnimalsSkillAnimator();
        DiceUIControl.isDiceUI = true;
        CameraMoveControl.isChangeCameraPoint = false;
    }

    IEnumerator HorsePower()
    {
        isHorsePower = false;
        horseTriplePower = true;
        systemText.text = "馬發動技能！";
        SystemTestTextControl.isTimer = true;
        PowerUIControl.animalsPowerUseNum[7]--;
        AnimalsSkillAnimator();
        BGM.PlayOneShot(horse);
        CameraMoveControl.isChangeCameraPoint = true;
        yield return new WaitForSeconds(2f);
        SceneManager.LoadScene(9);
        DiceUIControl.isDiceScene = true;
        horseUsePower = true;
        isPowerEffects = true;
        CameraMoveControl.isChangeCameraPoint = false;
    }

    IEnumerator SheepPower()
    {
        isSheepPower = false;
        sheepLuckyPower = true;
        systemText.text = "羊發動技能！";
        SystemTestTextControl.isTimer = true;
        PowerUIControl.animalsPowerUseNum[8]--;
        AnimalsSkillAnimator();
        BGM.PlayOneShot(goat);
        isPowerEffects = true;
        CameraMoveControl.isChangeCameraPoint = true;
        yield return new WaitForSeconds(3f);
        SceneManager.LoadScene(9);
        DiceUIControl.isDiceScene = true;
        AnimalsSkillAnimator();
        CameraMoveControl.isChangeCameraPoint = false;
    }

    IEnumerator MonkeyPower()
    {
        isMonkeyPower = false;
        systemText.text = "猴子發動技能！";
        SystemTestTextControl.isTimer = true;
        PowerUIControl.animalsPowerUseNum[9]--;
        AnimalsSkillAnimator();
        BGM.PlayOneShot(monkey);
        isPowerEffects = true;
        CameraMoveControl.isChangeCameraPoint = true;
        yield return new WaitForSeconds(3.5f);
        monkeyPutBananaPower = true;
        AnimalsSkillAnimator();
        SceneManager.LoadScene(9);
        DiceUIControl.isDiceScene = true;
        CameraMoveControl.isChangeCameraPoint = false;
    }

    IEnumerator ChickenPower()
    {
        isChickenPower = false;
        chickenUsePower = true;
        chickenPowerRound = 0;
        systemText.text = "雞發動技能！";
        SystemTestTextControl.isTimer = true;
        PowerUIControl.animalsPowerUseNum[10]--;
        AnimalsSkillAnimator();
        BGM.PlayOneShot(chicken);
        isPowerEffects = true;
        CameraMoveControl.isChangeCameraPoint = true;
        yield return new WaitForSeconds(3f);
        AnimalsSkillAnimator();
        DiceUIControl.isDiceUI = true;
        CameraMoveControl.isChangeCameraPoint = false;
    }

    IEnumerator DogPower()
    {
        isDogPower = false;
        dogUsePower = true;
        systemText.text = "狗發動技能！";
        SystemTestTextControl.isTimer = true;
        PowerUIControl.animalsPowerUseNum[11]--;
        AnimalsSkillAnimator();
        BGM.PlayOneShot(dog);
        CameraMoveControl.isChangeCameraPoint = true;
        yield return new WaitForSeconds(2f);
        SceneManager.LoadScene(9);
        DiceUIControl.isDiceScene = true;
        isPowerEffects = true;
        CameraMoveControl.isChangeCameraPoint = false;
    }

    IEnumerator PigPower()
    {
        isPigPower = false;
        pigCanUsePower = false;
        pigPowerRound = 0;
        systemText.text = "豬發動技能！";
        SystemTestTextControl.isTimer = true;
        PowerUIControl.animalsPowerUseNum[12]--;
        AnimalsSkillAnimator();
        BGM.PlayOneShot(pig);
        e = Random.Range(1, 4);
        switch (e)
        {
            case 1:
                pigPowerGood = true;
                break;

            case 2:
                pigPowerGood = true;
                break;

            case 3:
                pigPowerBad = true;
                break;
        }
        CameraMoveControl.isChangeCameraPoint = true;
        yield return new WaitForSeconds(2f);
        switch (e)
        {
            case 1:
                systemText.text = "獲得雙倍骰子";
                SystemTestTextControl.isTimer = true;
                switch (ChangeCameraControl.changeCameraNum)
                {
                    case 1:
                        PropsControl.P1Props[1] += 1;
                        break;

                    case 2:
                        PropsControl.P2Props[1] += 1;
                        break;

                    case 3:
                        PropsControl.P3Props[1] += 1;
                        break;

                    case 4:
                        PropsControl.P4Props[1] += 1;
                        break;
                }
                BGM.PlayOneShot(pigGood);
                break;

            case 2:
                systemText.text = "獲得了30貓貓幣";
                SystemTestTextControl.isTimer = true;
                switch (ChangeCameraControl.changeCameraNum)
                {
                    case 1:
                        CoinControl.P1CoinTotal += 30;
                        break;

                    case 2:
                        CoinControl.P2CoinTotal += 30;
                        break;

                    case 3:
                        CoinControl.P3CoinTotal += 30;
                        break;

                    case 4:
                        CoinControl.P4CoinTotal += 30;
                        break;
                }
                BGM.PlayOneShot(pigGood);
                break;

            case 3:
                systemText.text = "損失了25貓貓幣";
                SystemTestTextControl.isTimer = true;
                switch (ChangeCameraControl.changeCameraNum)
                {
                    case 1:
                        CoinControl.P1CoinTotal -= 25;
                        break;

                    case 2:
                        CoinControl.P2CoinTotal -= 25;
                        break;

                    case 3:
                        CoinControl.P3CoinTotal -= 25;
                        break;

                    case 4:
                        CoinControl.P4CoinTotal -= 25;
                        break;
                }
                BGM.PlayOneShot(pigBad);
                break;
        }
        isPowerEffects = true;
        yield return new WaitForSeconds(3f);
        AnimalsSkillAnimator();
        pigPowerGood = false;
        pigPowerBad = false;
        DiceUIControl.isDiceUI = true; ;
        CameraMoveControl.isChangeCameraPoint = false;
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

    void DragonPowerEnd()
    {
        if (dragonPowerRound >= 2)
        {
            dragonUsePower = false;
            AnimalsSkillAnimator();
            dragonPowerRound = 0;
        }
    }
    void ChickenPowerEnd()
    {
        if (chickenPowerRound >= 3)
        {
            ChickenEffectsControl.isEffects = false;
            chickenUsePower = false;
            chickenPowerRound = 0;
        }
    }
    void PigPowerCanUse()
    {
        if (pigPowerRound >= 2)
        {
            pigCanUsePower = true;
            pigPowerRound = 0;
        }
    }
}
