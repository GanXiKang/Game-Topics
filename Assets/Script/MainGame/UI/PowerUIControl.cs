using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUIControl : MonoBehaviour
{
    void Start()
    {
        
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
                                print("Mouse");
                                break;

                            case 2:
                                AnimalsPowerControl.isCowPower = true;
                                print("Cow");
                                break;

                            case 3:
                                AnimalsPowerControl.isTigerPower = true;
                                print("Tiger");
                                break;

                            case 4:
                                AnimalsPowerControl.isRabbitPower = true;
                                print("Rabbit");
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
                                print("Mouse");
                                break;

                            case 2:
                                AnimalsPowerControl.isCowPower = true;
                                print("Cow");
                                break;

                            case 3:
                                AnimalsPowerControl.isTigerPower = true;
                                print("Tiger");
                                break;

                            case 4:
                                AnimalsPowerControl.isRabbitPower = true;
                                print("Rabbit");
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
                                print("Mouse");
                                break;

                            case 2:
                                AnimalsPowerControl.isCowPower = true;
                                print("Cow");
                                break;

                            case 3:
                                AnimalsPowerControl.isTigerPower = true;
                                print("Tiger");
                                break;

                            case 4:
                                AnimalsPowerControl.isRabbitPower = true;
                                print("Rabbit");
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
                                print("Mouse");
                                break;

                            case 2:
                                AnimalsPowerControl.isCowPower = true;
                                print("Cow");
                                break;

                            case 3:
                                AnimalsPowerControl.isTigerPower = true;
                                print("Tiger");
                                break;

                            case 4:
                                AnimalsPowerControl.isRabbitPower = true;
                                print("Rabbit");
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
}
