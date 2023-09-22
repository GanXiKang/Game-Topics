using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AnimalsPowerControl : MonoBehaviour
{
    public static bool isMousePower = false, isCowPower = false, isTigerPower = false, isRabbitPower = false;
    public static bool isDragonPower = false, isSnakePower = false, isHorsePower = false, isSheepPower = false;
    public static bool isMonkeyPower = false, isChickenPower = false, isDogPower = false, isPigPower = false;

    public Text systemText;

    void Start()
    {
        
    }

    void Update()
    {
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
}
