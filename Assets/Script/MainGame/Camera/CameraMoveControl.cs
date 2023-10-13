using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMoveControl : MonoBehaviour
{
    public static bool isChangeCameraPoint;

    public Transform cameraPointA, cameraPointB, cameraPointC;

    float speed, sensitivity, maxDistance;
    bool isMove, isMovetoPointC;

    void Start()
    {
        speed = 5f;
        sensitivity = 2f;
        maxDistance = 20f;
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
            if (isMovetoPointC)
            {
                transform.position = cameraPointC.position;
                transform.rotation = cameraPointC.rotation;
                isMovetoPointC = false;
            }

            float cameraDistance = Vector3.Distance(transform.position, cameraPointA.position);
            float srollInput = Input.GetAxis("Mouse ScrollWheel");
            if (cameraDistance <= maxDistance)
            {
                transform.Translate(-srollInput * speed * Time.deltaTime, 0, 0);
            }
        }
        else
        {
            transform.position = cameraPointA.position;
            transform.rotation = cameraPointA.rotation;
            isMovetoPointC = true;
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
