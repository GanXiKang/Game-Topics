using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimalsAudioSourceControl : MonoBehaviour
{
    AudioSource BGM;

    bool isPlayP1, isPlayP2, isPlayP3, isPlayP4;

    void Start()
    {
        BGM = GetComponent<AudioSource>();
        isPlayP1 = true;
        isPlayP2 = false;
        isPlayP3 = false;
        isPlayP4 = false;
    }

    void Update()
    {
        switch (ChangeCameraControl.changeCameraNum)
        {
            case 1:
                if (gameObject.tag == "P1")
                {
                    if (isPlayP1)
                    {
                        BGM.Play();
                        isPlayP1 = false;
                        Sounds();
                    }
                }
                break;

            case 2:
                if (gameObject.tag == "P2")
                {
                    if (isPlayP2)
                    {
                        BGM.Play();
                        isPlayP2 = false;
                        Sounds();
                    }
                }
                break;

            case 3:
                if (gameObject.tag == "P3")
                {
                    if (isPlayP3)
                    {
                        BGM.Play();
                        isPlayP3 = false;
                        Sounds();
                    }
                }
                break;

            case 4:
                if (gameObject.tag == "P4")
                {
                    if (isPlayP4)
                    {
                        BGM.Play();
                        isPlayP4 = false;
                        Sounds();
                    }
                }
                break;
        }
    }

    void Sounds()
    {
        switch (ChangeCameraControl.changeCameraNum)
        {
            case 1:
                isPlayP2 = true;
                break;

            case 2:
                if (Menu_ChoosePlayer.whoPlay >= 3)
                {
                    isPlayP3 = true;
                }
                else
                {
                    isPlayP1 = true;
                }
                break;

            case 3:
                if (Menu_ChoosePlayer.whoPlay == 4)
                {
                    isPlayP4 = true;
                }
                else
                {
                    isPlayP1 = true;
                }
                break;

            case 4:
                isPlayP1 = true;
                break;
        }
    }
}
