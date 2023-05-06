using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraControl : MonoBehaviour
{
    GameObject[] PlayerCamera = new GameObject[5];

    bool closeCamera = true, findCamera = false;

    void Update()
    {
        if (closeCamera)
        {
            if (gameObject.tag == "P2Camera"|| gameObject.tag == "P3Camera"|| gameObject.tag == "P4Camera")
            {
                gameObject.SetActive(false);
                closeCamera = false;
                //findCamera = true;
            }
        }

        //if (findCamera)
        //{
            PlayerCamera[1] = GameObject.FindGameObjectWithTag("P1Camera");
            PlayerCamera[2] = GameObject.FindGameObjectWithTag("P2Camera");
            PlayerCamera[3] = GameObject.FindGameObjectWithTag("P3Camera");
            PlayerCamera[4] = GameObject.FindGameObjectWithTag("P4Camera");
        //    findCamera = false;
        //}
        print(PlayerCamera[1].tag);
        if (Input.GetKeyDown(KeyCode.C))
        {
            PlayerCamera[1].SetActive(false);
            PlayerCamera[2].SetActive(true);
        }
    }
}