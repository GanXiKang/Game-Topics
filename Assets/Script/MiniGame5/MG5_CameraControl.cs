using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MG5_CameraControl : MonoBehaviour
{
    public GameObject playerCamera;
    public GameObject hookCamera;

    public static bool watchPlayer = true;
    void Update()
    {
        if (watchPlayer == true)
        {
            playerCamera.SetActive(true);
            hookCamera.SetActive(false);
        }
        else
        {
            playerCamera.SetActive(false);
            hookCamera.SetActive(true);
        }
    }
}
