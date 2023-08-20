using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraControl : MonoBehaviour
{
    void Update()
    {
        if (MiniGameColliderControl.isMiniGame || GameEndControl.isEnd || DiceUIControl.isDiceScene)
        {
            gameObject.GetComponent<Camera>().enabled = false;
            gameObject.GetComponent<AudioListener>().enabled = false;
        }
        else
        {
            switch (ChangeCameraControl.changeCameraNum)
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
}