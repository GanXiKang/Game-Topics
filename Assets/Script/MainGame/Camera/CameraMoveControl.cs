using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMoveControl : MonoBehaviour
{
    public Transform cameraOriginalLocation;

    float speed = 5f;
    float sensitivity = 2f;
    bool isMove = false;

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
        if (Input.GetMouseButtonDown(1))
        {
            isMove = !isMove;
        }

        if(isMove)
        { 
            float srollInput = Input.GetAxis("Mouse ScrollWheel");
            float mouseX = Input.GetAxis("Mouse X");
            float mouseY = Input.GetAxis("Mouse Y");

            transform.Translate(Vector3.forward * srollInput * speed);
            transform.Rotate(Vector3.up * mouseX * sensitivity);
            transform.Rotate(Vector3.left * mouseY * sensitivity);

            DiceUIControl.isDiceUI = false;
        }
        else
        {
            transform.position = cameraOriginalLocation.position;
            transform.rotation = cameraOriginalLocation.rotation;

            DiceUIControl.isDiceUI = true;
        }
    }
}
