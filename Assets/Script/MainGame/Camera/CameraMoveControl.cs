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
                    CameraRotate();
                    CameraMove();
                }
                break;

            case 2:
                if (gameObject.tag == "P2Camera")
                {
                    CameraRotate();
                    CameraMove();
                }
                break;

            case 3:
                if (gameObject.tag == "P3Camera")
                {
                    CameraRotate();
                    CameraMove();
                }
                break;

            case 4:
                if (gameObject.tag == "P4Camera")
                {
                    CameraRotate();
                    CameraMove();
                }
                break;
        }
    }
    void CameraRotate()
    {
        if (Input.GetMouseButton(1))
        {
            float mouseX = Input.GetAxis("Mouse X");
            float mouseY = Input.GetAxis("Mouse Y");

            transform.Rotate(Vector3.up * mouseX * sensitivity);
            transform.Rotate(Vector3.left * mouseY * sensitivity);
        }
        else
        {
            transform.rotation = cameraOriginalLocation.rotation;
        }
    }

    void CameraMove()
    {
        if (Input.GetKeyDown(KeyCode.LeftControl))
        {
            isMove = !isMove;
        }

        if (isMove)
        {
            float h = Input.GetAxis("Horizontal");
            float v = Input.GetAxis("Vertical");

            Vector3 moveDirection = new Vector3(h, 0, v);

            if (Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.UpArrow))
            {
                transform.Translate(moveDirection * speed * Time.deltaTime);
            }
            if (Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.DownArrow))
            {
                transform.Translate(-moveDirection * speed * Time.deltaTime);
            }
            if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow))
            {
                transform.Translate(-transform.right * speed * Time.deltaTime);
            }
            if (Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow))
            {
                transform.Translate(transform.right * speed * Time.deltaTime);
            }
            DiceUIControl.isDiceUI = false;
        }
        else
        {
            transform.position = cameraOriginalLocation.position;
            DiceUIControl.isDiceUI = true;
        }
    }
}
