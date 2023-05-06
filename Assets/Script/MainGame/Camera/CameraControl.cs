using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraControl : MonoBehaviour
{
    public static bool findCamera, closeCamera;

    void Update()
    {
        print("yes");
        if (closeCamera)
        {
            if (gameObject.tag == "P2Camera" || gameObject.tag == "P3Camera" || gameObject.tag == "P4Camera")
            {
                print("false");
                this.gameObject.SetActive(false);
            }

            findCamera = true;
            closeCamera = false;
        }
    }
}