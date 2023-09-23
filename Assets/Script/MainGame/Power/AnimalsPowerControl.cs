using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AnimalsPowerControl : MonoBehaviour
{
    public static bool isMousePower = false, isCowPower = false, isTigerPower = false, isRabbitPower = false;
    public static bool isDragonPower = false, isSnakePower = false, isHorsePower = false, isSheepPower = false;
    public static bool isMonkeyPower = false, isChickenPower = false, isDogPower = false, isPigPower = false;
    public static int mouseIsThisPoint;

    public Text systemText;

    int r, p;

    void Update()
    {
        if (isCowPower)
        {
            systemText.text = "老鼠發動技能！";
            SystemTestTextControl.isTimer = true;
            switch (ChangeCameraControl.changeCameraNum)
            {
                case 1:
                    if (mouseIsThisPoint == 1)
                    {
                        r = Random.Range(5, 16);
                    }
                    else 
                    {

                    }
                    break;

                case 2:
                    if (mouseIsThisPoint == 1)
                    {

                    }
                    else
                    {

                    }
                    break;

                case 3:
                    if (mouseIsThisPoint == 1)
                    {

                    }
                    else
                    {

                    }
                    break;

                case 4:
                    if (mouseIsThisPoint == 1)
                    {

                    }
                    else
                    {

                    }
                    break;
            }
            PowerUIControl.animalsPowerUseNum[1]--;
            isMousePower = false;
        }

        if (isCowPower)
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
        }

        if (isTigerPower)
        {
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
        }

        if (isRabbitPower)
        {
            systemText.text = "兔子發動技能！";
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
}
