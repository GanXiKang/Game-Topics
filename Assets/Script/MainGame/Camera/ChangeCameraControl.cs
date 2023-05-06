using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeCameraControl : MonoBehaviour
{
    public static int changeCameraNum;

    void Start()
    {
        changeCameraNum = 1;
    }
    void Update()
    {
        if (changeCameraNum > Menu_ChoosePlayer.whoPlay)
        {
            changeCameraNum = 1;
        }
    }
}
