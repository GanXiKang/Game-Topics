using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeCameraControl : MonoBehaviour
{
    
    public static int changeCamera = 0;


    void Update()
    {

        if (Input.GetKeyDown(KeyCode.C))
        {
            changeCamera++;
        }
        ChangeCamera();
    }
    void ChangeCamera()
    {
        if (changeCamera > Menu_ChoosePlayer.whoPlay)
        {
            changeCamera = 1;
        }

        switch (changeCamera)
        {
            case 1:
                CameraControl.PlayerCamera[1].SetActive(true);
                CameraControl.PlayerCamera[2].SetActive(false);
                CameraControl.PlayerCamera[3].SetActive(false);
                CameraControl.PlayerCamera[4].SetActive(false);
                break;

            case 2:
                CameraControl.PlayerCamera[1].SetActive(false);
                CameraControl.PlayerCamera[2].SetActive(true);
                CameraControl.PlayerCamera[3].SetActive(false);
                CameraControl.PlayerCamera[4].SetActive(false);
                break;

            case 3:
                CameraControl.PlayerCamera[1].SetActive(false);
                CameraControl.PlayerCamera[2].SetActive(false);
                CameraControl.PlayerCamera[3].SetActive(true);
                CameraControl.PlayerCamera[4].SetActive(false);
                break;

            case 4:
                CameraControl.PlayerCamera[1].SetActive(false);
                CameraControl.PlayerCamera[2].SetActive(false);
                CameraControl.PlayerCamera[3].SetActive(false);
                CameraControl.PlayerCamera[4].SetActive(true);
                break;
        }
    }
}
