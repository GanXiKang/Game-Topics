using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraControl : MonoBehaviour
{
    public static int changeCameraNum = 1;

    void Update()
    {
        if (changeCameraNum > Menu_ChoosePlayer.whoPlay)
        {
            changeCameraNum = 1;
        }
        if (Input.GetKeyDown(KeyCode.C))
        {
            changeCameraNum++;
            print(changeCameraNum);
        }

        ChangeCamera();
    }
    void ChangeCamera()
    {
        switch (changeCameraNum)
        {
            case 1:
                if (gameObject.tag == "P2Camera" || gameObject.tag == "P3Camera" || gameObject.tag == "P4Camera")
                {
                    gameObject.SetActive(false);
                }
                else
                {
                    gameObject.SetActive(true);
                }
                break;

            case 2:
                if (gameObject.tag == "P1Camera" || gameObject.tag == "P3Camera" || gameObject.tag == "P4Camera")
                {
                    gameObject.SetActive(false);
                }
                else
                {
                    gameObject.SetActive(true);
                }
                break;

            case 3:
                if (gameObject.tag == "P1Camera" || gameObject.tag == "P2Camera" || gameObject.tag == "P4Camera")
                {
                    gameObject.SetActive(false);
                }
                else
                {
                    gameObject.SetActive(true);
                }
                break;

            case 4:
                if (gameObject.tag == "P1Camera" || gameObject.tag == "P2Camera" || gameObject.tag == "P3Camera")
                {
                    gameObject.SetActive(false);
                }
                else
                {
                    gameObject.SetActive(true);
                }
                break;
        }
    }
}