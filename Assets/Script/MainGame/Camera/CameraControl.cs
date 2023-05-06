using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraControl : MonoBehaviour
{
    GameObject[] PlayerCamera = new GameObject[5];

    bool closeCamera = true;

    void Update()
    {
        if (closeCamera)
        {
            if (gameObject.tag == "P2Camera"|| gameObject.tag == "P3Camera"|| gameObject.tag == "P4Camera")
            {
                gameObject.SetActive(false);
                closeCamera = false;
            }
        }
    }
}