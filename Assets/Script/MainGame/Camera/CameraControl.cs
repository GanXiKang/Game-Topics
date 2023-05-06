using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraControl : MonoBehaviour
{
    void Start()
    {
            if (gameObject.tag == "P2Camera")
            {
                gameObject.SetActive(false);
            }

    }
}