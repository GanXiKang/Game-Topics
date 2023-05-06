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
            OpeningSet();
            findCamera = true;
            closeCamera = false;
        }
    }
    void OpeningSet()
    {
        if (gameObject.tag == "P2Camera" || gameObject.tag == "P3Camera" || gameObject.tag == "P4Camera")
        {
            gameObject.SetActive(false);
        }
    }
   
}