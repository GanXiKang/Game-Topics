using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraControl : MonoBehaviour
{
    public static int changeCameraNum;

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
        ChangeCamera();
    }
    void ChangeCamera()
    {
        switch (changeCameraNum)
        {
            case 1:
                if (gameObject.tag == "P2Camera" || gameObject.tag == "P3Camera" || gameObject.tag == "P4Camera")
                {
                    gameObject.GetComponent<Camera>().enabled = false;
                    gameObject.GetComponent<AudioListener>().enabled = false;
                }
                else
                {
                    gameObject.GetComponent<Camera>().enabled = true;
                    gameObject.GetComponent<AudioListener>().enabled = true;
                }
                break;

            case 2:
                if (gameObject.tag == "P1Camera" || gameObject.tag == "P3Camera" || gameObject.tag == "P4Camera")
                {
                    gameObject.GetComponent<Camera>().enabled = false;
                    gameObject.GetComponent<AudioListener>().enabled = false;
                }
                else
                {
                    gameObject.GetComponent<Camera>().enabled = true;
                    gameObject.GetComponent<AudioListener>().enabled = true;
                }
                break;

            case 3:
                if (gameObject.tag == "P1Camera" || gameObject.tag == "P2Camera" || gameObject.tag == "P4Camera")
                {
                    gameObject.GetComponent<Camera>().enabled = false;
                    gameObject.GetComponent<AudioListener>().enabled = false;
                }
                else
                {
                    gameObject.GetComponent<Camera>().enabled = true;
                    gameObject.GetComponent<AudioListener>().enabled = true;
                }
                break;

            case 4:
                if (gameObject.tag == "P1Camera" || gameObject.tag == "P2Camera" || gameObject.tag == "P3Camera")
                {
                    gameObject.GetComponent<Camera>().enabled = false;
                    gameObject.GetComponent<AudioListener>().enabled = false;
                }
                else
                {
                    gameObject.GetComponent<Camera>().enabled = true;
                    gameObject.GetComponent<AudioListener>().enabled = true;
                }
                break;
        }
    }
}