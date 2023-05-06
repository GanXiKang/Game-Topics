using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraControl : MonoBehaviour
{
    bool closeCamera = true;
    void Update()
    {
        if (gameObject.tag == "P2Camera" && closeCamera || gameObject.tag == "P3Camera" && closeCamera || gameObject.tag == "P4Camera" && closeCamera)
        {
            gameObject.SetActive(false);
            closeCamera = false;
        }

        if (Input.GetKeyDown(KeyCode.C))
        {
            if (gameObject.tag == "P2Camera")
            {
                gameObject.SetActive(true);
            }
            if (gameObject.tag == "P1Camera")
            {
                gameObject.SetActive(false);
            }
        }
    }
}