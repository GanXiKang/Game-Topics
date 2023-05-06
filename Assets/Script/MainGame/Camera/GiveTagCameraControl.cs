using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GiveTagCameraControl : MonoBehaviour
{
    void Start()
    {
        if (gameObject.tag == "Mouse")
        {
            if (Menu_ChoosePlayer.whyP1 == 1)
            {
                gameObject.tag = "P1Camera";
            }
            else if (Menu_ChoosePlayer.whyP2 == 1)
            {
                gameObject.tag = "P2Camrea";
            }
            else if (Menu_ChoosePlayer.whyP3 == 1)
            {
                gameObject.tag = "P3Camrea";
            }
            else if (Menu_ChoosePlayer.whyP4 == 1)
            {
                gameObject.tag = "P4Camera";
            }
        }

        if (gameObject.tag == "Cow")
        {
            if (Menu_ChoosePlayer.whyP1 == 2)
            {
                gameObject.tag = "P1Camera";
            }
            else if (Menu_ChoosePlayer.whyP2 == 2)
            {
                gameObject.tag = "P2Camera";
            }
            else if (Menu_ChoosePlayer.whyP3 == 2)
            {
                gameObject.tag = "P3Camera";
            }
            else if (Menu_ChoosePlayer.whyP4 == 2)
            {
                gameObject.tag = "P4Camera";
            }
        }

        if (gameObject.tag == "Tiger")
        {
            if (Menu_ChoosePlayer.whyP1 == 3)
            {
                gameObject.tag = "P1Camera";
            }
            else if (Menu_ChoosePlayer.whyP2 == 3)
            {
                gameObject.tag = "P2Camera";
            }
            else if (Menu_ChoosePlayer.whyP3 == 3)
            {
                gameObject.tag = "P3Camera";
            }
            else if (Menu_ChoosePlayer.whyP4 == 3)
            {
                gameObject.tag = "P4Camera";
            }
        }

        if (gameObject.tag == "Rabbit")
        {
            if (Menu_ChoosePlayer.whyP1 == 4)
            {
                gameObject.tag = "P1Camera";
            }
            else if (Menu_ChoosePlayer.whyP2 == 4)
            {
                gameObject.tag = "P2Camera";
            }
            else if (Menu_ChoosePlayer.whyP3 == 4)
            {
                gameObject.tag = "P3Camera";
            }
            else if (Menu_ChoosePlayer.whyP4 == 4)
            {
                gameObject.tag = "P4Camera";
            }
        }
        //CameraControl.closeCamera = true;
    }
}
