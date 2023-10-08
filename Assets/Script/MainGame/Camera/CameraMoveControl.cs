using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMoveControl : MonoBehaviour
{
    Vector3 originalLocation;
    Quaternion originalRotation;

    void Start()
    {
        originalLocation = transform.position;
        originalRotation = transform.rotation;
    }

    void FixedUpdate()
    {
        switch (ChangeCameraControl.changeCameraNum)
        {
            case 1:
                if (gameObject.tag == "P1Camera")
                {
                    CameraMove();
                }
                break;

            case 2:
                if (gameObject.tag == "P2Camera")
                {
                    CameraMove();
                }
                break;

            case 3:
                if (gameObject.tag == "P3Camera")
                {
                    CameraMove();
                }
                break;

            case 4:
                if (gameObject.tag == "P4Camera")
                {
                    CameraMove();
                }
                break;
        }
    }
    void CameraMove()
    {
        if (Input.GetMouseButton(1))
        {
            
        }
        else
        {
            transform.position = originalLocation;
            transform.rotation = originalRotation;
        }
    }
}
