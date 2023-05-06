using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeCameraControl : MonoBehaviour
{
    //GameObject[] PlayerCamera = new GameObject[5];

    public static int changeCamera = 1;

    //void Update()
    //{
    //    if (CameraControl.findCamera)
    //    {
    //        PlayerCamera[1] = GameObject.FindGameObjectWithTag("P1Camera");
    //        PlayerCamera[2] = GameObject.FindGameObjectWithTag("P2Camera");
    //        PlayerCamera[3] = GameObject.FindGameObjectWithTag("P3Camera");
    //        PlayerCamera[4] = GameObject.FindGameObjectWithTag("P4Camera");
    //        CameraControl.findCamera = false;
    //    }
    //    if (Input.GetKeyDown(KeyCode.P))
    //    {
    //        print(PlayerCamera[1]);
    //        print(PlayerCamera[2]);
    //        print(PlayerCamera[3]);
    //        print(PlayerCamera[4]);
    //    }
    //    if (Input.GetKeyDown(KeyCode.C))
    //    {
    //        changeCamera++;
    //    }
    //    ChangeCamera();
    //}
    //void ChangeCamera()
    //{
    //    if (changeCamera > Menu_ChoosePlayer.whoPlay)
    //    {
    //        changeCamera = 1;
    //    }

    //    switch (changeCamera)
    //    {
    //        case 1:
    //            PlayerCamera[1].SetActive(true);
    //            PlayerCamera[2].SetActive(false);
    //            PlayerCamera[3].SetActive(false);
    //            PlayerCamera[4].SetActive(false);
    //            break;

    //        case 2:
    //            PlayerCamera[1].SetActive(false);
    //            PlayerCamera[2].SetActive(true);
    //            PlayerCamera[3].SetActive(false);
    //            PlayerCamera[4].SetActive(false);
    //            break;

    //        case 3:
    //            PlayerCamera[1].SetActive(false);
    //            PlayerCamera[2].SetActive(false);
    //            PlayerCamera[3].SetActive(true);
    //            PlayerCamera[4].SetActive(false);
    //            break;

    //        case 4:
    //            PlayerCamera[1].SetActive(false);
    //            PlayerCamera[2].SetActive(false);
    //            PlayerCamera[3].SetActive(false);
    //            PlayerCamera[4].SetActive(true);
    //            break;
    //    }
    //}
}
