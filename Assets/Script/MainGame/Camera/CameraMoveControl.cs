using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMoveControl : MonoBehaviour
{
    public static bool isChangeCameraPoint;

    public Transform cameraPointA;
    public Transform cameraPointB;

    float speed, sensitivity, maxDistance;
    bool isMove;

    void Start()
    {
        speed = 5f;
        sensitivity = 2f;
        maxDistance = 10f;
        isMove = false;
        isChangeCameraPoint = false;
    }

    void Update()
    {
        switch (ChangeCameraControl.changeCameraNum)
        {
            case 1:
                if (gameObject.tag == "P1Camera")
                {
                    CameraMove();
                    ChangeCameraPoint();
                }
                break;

            case 2:
                if (gameObject.tag == "P2Camera")
                {
                    CameraMove();
                    ChangeCameraPoint();
                }
                break;

            case 3:
                if (gameObject.tag == "P3Camera")
                {
                    CameraMove();
                    ChangeCameraPoint();
                }
                break;

            case 4:
                if (gameObject.tag == "P4Camera")
                {
                    CameraMove();
                    ChangeCameraPoint();
                }
                break;
        }
    }
    void CameraMove()
    {
        if (Input.GetMouseButtonDown(1))
        {
            if (DiceUIControl.isDiceUI)
            {
                isMove = true;
                DiceUIControl.isDiceUI = false;
            }
            else if (isMove)
            {
                isMove = false;
                DiceUIControl.isDiceUI = true;
            }
        }

        if (isMove)
        {
            float cameraDistance = Vector3.Distance(transform.position, cameraPointA.position);
            float srollInput = Input.GetAxis("Mouse ScrollWheel");
            float mouseX = Input.GetAxis("Mouse X");
            float mouseY = Input.GetAxis("Mouse Y");

            if (cameraDistance <= maxDistance)
            {
                transform.Translate(Vector3.forward * srollInput * speed);
            }

            transform.Rotate(Vector3.up * mouseX * sensitivity);
            transform.Rotate(Vector3.left * mouseY * sensitivity);
        }
        else
        {
            transform.position = cameraPointA.position;
            transform.rotation = cameraPointA.rotation;
        }
    }
    void ChangeCameraPoint()
    {
        if (isChangeCameraPoint)
        {
            transform.position = cameraPointB.position;
            transform.rotation = cameraPointB.rotation;
        }
        else if (!isChangeCameraPoint && !isMove)
        {
            transform.position = cameraPointA.position;
            transform.rotation = cameraPointA.rotation;
        }
    }
}
