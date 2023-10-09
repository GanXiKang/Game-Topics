using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMoveControl : MonoBehaviour
{
    public Transform cameraOriginalLocation;

    float speed, sensitivity, maxDistance;
    bool isMove;

    void Start()
    {
        speed = 5f;
        sensitivity = 2f;
        maxDistance = 10f;
        isMove = false;
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
        if (DiceUIControl.isDiceUI)
        {
            if (Input.GetMouseButtonDown(1))
            {
                isMove = !isMove;
            }
        }

        if(isMove)
        {
            float cameraDistance = Vector3.Distance(transform.position, cameraOriginalLocation.position);
            float srollInput = Input.GetAxis("Mouse ScrollWheel");
            float mouseX = Input.GetAxis("Mouse X");
            float mouseY = Input.GetAxis("Mouse Y");

            if (cameraDistance <= maxDistance)
            {
                transform.Translate(Vector3.forward * srollInput * speed);
            }

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
