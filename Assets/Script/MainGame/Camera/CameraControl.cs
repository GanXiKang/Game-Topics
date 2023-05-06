using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraControl : MonoBehaviour
{
    public static bool findCamera;

    bool closeCamera = true;
    void Update()
    {
        if (closeCamera)
        {
            if (gameObject.tag == "P2Camera" || gameObject.tag == "P3Camera" || gameObject.tag == "P4Camera")
            {
                this.gameObject.SetActive(false);
            }

            findCamera = true;
            closeCamera = false;
        }
    }
}