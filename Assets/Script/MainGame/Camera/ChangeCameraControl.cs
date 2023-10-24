using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeCameraControl : MonoBehaviour
{
    public static int changeCameraNum = 1;
    public static int round = 1;

    void Update()
    {
        if (changeCameraNum > Menu_ChoosePlayer.whoPlay)
        {
            changeCameraNum = 1;
            round++;
            if (AnimalsPowerControl.chickenUsePower)
            {
                AnimalsPowerControl.chickenPowerRound += 1 ;
                print(AnimalsPowerControl.chickenPowerRound);
            }
        }
    }
}
