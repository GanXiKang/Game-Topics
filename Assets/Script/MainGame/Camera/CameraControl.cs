using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraControl : MonoBehaviour
{
    public static GameObject[] PlayerCamera = new GameObject[5];

    bool closeCamera = true, findCamera = true;
    void Update()
    {
        if (closeCamera)
        {
            if (gameObject.tag == "P2Camera" || gameObject.tag == "P3Camera" || gameObject.tag == "P4Camera")
            {
                this.gameObject.SetActive(false);
            }

            if (findCamera)
            {
                PlayerCamera[1] = GameObject.FindGameObjectWithTag("P1Camera");
                PlayerCamera[2] = GameObject.FindGameObjectWithTag("P2Camera");
                PlayerCamera[3] = GameObject.FindGameObjectWithTag("P3Camera");
                PlayerCamera[4] = GameObject.FindGameObjectWithTag("P4Camera");

                print(PlayerCamera[1].tag);
                print(PlayerCamera[2].tag);
                print(PlayerCamera[3].tag);
                print(PlayerCamera[4].tag);
                findCamera = false;
            }
            closeCamera = false;
        }
    }
}