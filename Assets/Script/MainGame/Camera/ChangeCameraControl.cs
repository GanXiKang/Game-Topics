using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeCameraControl : MonoBehaviour
{
    public static int changeCameraNum;
    public static int round;

    void Start()
    {
        changeCameraNum = 1;
        round = 1;
    }
    void Update()
    {
        if (changeCameraNum > Menu_ChoosePlayer.whoPlay)
        {
            changeCameraNum = 1;
            round++;
            if (AnimalsPowerControl.chickenUsePower)
            {
                AnimalsPowerControl.chickenPowerRound += 1;
            }
            if (!AnimalsPowerControl.pigCanUsePower)
            {
                AnimalsPowerControl.pigPowerRound += 1;
            }
        }
    }
}
