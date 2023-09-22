using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PowerUIControl : MonoBehaviour
{
    public Button power;
    public Text powerUseNum;

    public static int[] animalsPowerUseNum = new int[13];
    void Start()
    {
        Initial();
    }


    void Update()
    {
        
    }

    public void Power_Button()
    {
        FindWhoUsePower();
    }
    void FindWhoUsePower()
    {
        switch (ChangeCameraControl.changeCameraNum)
        {
            case 1:
                for (int i = 1; i <= 12; i++)
                {
                    if (i == Menu_ChoosePlayer.whyP1)
                    {
                        switch (i)
                        {
                            case 1:
                                AnimalsPowerControl.isMousePower = true;
                                break;

                            case 2:
                                AnimalsPowerControl.isCowPower = true;
                                break;

                            case 3:
                                AnimalsPowerControl.isTigerPower = true;
                                break;

                            case 4:
                                AnimalsPowerControl.isRabbitPower = true;
                                break;

                            case 5:
                                AnimalsPowerControl.isDragonPower = true;
                                break;

                            case 6:
                                AnimalsPowerControl.isSnakePower = true;
                                break;

                            case 7:
                                AnimalsPowerControl.isHorsePower = true;
                                break;

                            case 8:
                                AnimalsPowerControl.isSheepPower = true;
                                break;

                            case 9:
                                AnimalsPowerControl.isMonkeyPower = true;
                                break;

                            case 10:
                                AnimalsPowerControl.isChickenPower = true;
                                break;

                            case 11:
                                AnimalsPowerControl.isDogPower = true;
                                break;

                            case 12:
                                AnimalsPowerControl.isPigPower = true;
                                break;
                        }
                    }
                }
                break;

            case 2:
                for (int i = 1; i <= 12; i++)
                {
                    if (i == Menu_ChoosePlayer.whyP2)
                    {
                        switch (i)
                        {
                            case 1:
                                AnimalsPowerControl.isMousePower = true;
                                break;

                            case 2:
                                AnimalsPowerControl.isCowPower = true;
                                break;

                            case 3:
                                AnimalsPowerControl.isTigerPower = true;
                                break;

                            case 4:
                                AnimalsPowerControl.isRabbitPower = true;
                                break;

                            case 5:
                                AnimalsPowerControl.isDragonPower = true;
                                break;

                            case 6:
                                AnimalsPowerControl.isSnakePower = true;
                                break;

                            case 7:
                                AnimalsPowerControl.isHorsePower = true;
                                break;

                            case 8:
                                AnimalsPowerControl.isSheepPower = true;
                                break;

                            case 9:
                                AnimalsPowerControl.isMonkeyPower = true;
                                break;

                            case 10:
                                AnimalsPowerControl.isChickenPower = true;
                                break;

                            case 11:
                                AnimalsPowerControl.isDogPower = true;
                                break;

                            case 12:
                                AnimalsPowerControl.isPigPower = true;
                                break;
                        }
                    }
                }
                break;

            case 3:
                for (int i = 1; i <= 12; i++)
                {
                    if (i == Menu_ChoosePlayer.whyP3)
                    {
                        switch (i)
                        {
                            case 1:
                                AnimalsPowerControl.isMousePower = true;
                                break;

                            case 2:
                                AnimalsPowerControl.isCowPower = true;
                                break;

                            case 3:
                                AnimalsPowerControl.isTigerPower = true;
                                break;

                            case 4:
                                AnimalsPowerControl.isRabbitPower = true;
                                break;

                            case 5:
                                AnimalsPowerControl.isDragonPower = true;
                                break;

                            case 6:
                                AnimalsPowerControl.isSnakePower = true;
                                break;

                            case 7:
                                AnimalsPowerControl.isHorsePower = true;
                                break;

                            case 8:
                                AnimalsPowerControl.isSheepPower = true;
                                break;

                            case 9:
                                AnimalsPowerControl.isMonkeyPower = true;
                                break;

                            case 10:
                                AnimalsPowerControl.isChickenPower = true;
                                break;

                            case 11:
                                AnimalsPowerControl.isDogPower = true;
                                break;

                            case 12:
                                AnimalsPowerControl.isPigPower = true;
                                break;
                        }
                    }
                }
                break;

            case 4:
                for (int i = 1; i <= 12; i++)
                {
                    if (i == Menu_ChoosePlayer.whyP4)
                    {
                        switch (i)
                        {
                            case 1:
                                AnimalsPowerControl.isMousePower = true;
                                break;

                            case 2:
                                AnimalsPowerControl.isCowPower = true;
                                break;

                            case 3:
                                AnimalsPowerControl.isTigerPower = true;
                                break;

                            case 4:
                                AnimalsPowerControl.isRabbitPower = true;
                                break;

                            case 5:
                                AnimalsPowerControl.isDragonPower = true;
                                break;

                            case 6:
                                AnimalsPowerControl.isSnakePower = true;
                                break;

                            case 7:
                                AnimalsPowerControl.isHorsePower = true;
                                break;

                            case 8:
                                AnimalsPowerControl.isSheepPower = true;
                                break;

                            case 9:
                                AnimalsPowerControl.isMonkeyPower = true;
                                break;

                            case 10:
                                AnimalsPowerControl.isChickenPower = true;
                                break;

                            case 11:
                                AnimalsPowerControl.isDogPower = true;
                                break;

                            case 12:
                                AnimalsPowerControl.isPigPower = true;
                                break;
                        }
                    }
                }
                break;
        }
    }
    void Initial()
    {
        animalsPowerUseNum[1] = 2;
        animalsPowerUseNum[2] = 3;
        animalsPowerUseNum[3] = 2;
        animalsPowerUseNum[4] = 2;
        animalsPowerUseNum[5] = 2;
        animalsPowerUseNum[6] = 2;
        animalsPowerUseNum[7] = 1;
        animalsPowerUseNum[8] = 3;
        animalsPowerUseNum[9] = 2;
        animalsPowerUseNum[10] = 1;
        animalsPowerUseNum[11] = 2;
        animalsPowerUseNum[12] = 2;
    }
}
