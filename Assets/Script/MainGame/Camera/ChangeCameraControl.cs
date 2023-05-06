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
        print("changeCameraNum" + changeCameraNum);
        if (changeCameraNum > Menu_ChoosePlayer.whoPlay)
        {
            changeCameraNum = 1;
        }
        if (Input.GetKeyDown(KeyCode.C))
        {
            changeCameraNum++;
        }
    }
}
