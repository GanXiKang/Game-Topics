using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimalsPowerControl : MonoBehaviour
{
    public static bool isMousePower = false, isCowPower = false, isTigerPower = false, isRabbitPower = false;
    public static bool isDragonPower = false, isSnakePower = false, isHorsePower = false, isSheepPower = false;
    public static bool isMonkeyPower = false, isChickenPower = false, isDogPower = false, isPigPower = false;

    void Start()
    {
        
    }

    void Update()
    {
        if (isCowPower)
        {
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
    }
}
