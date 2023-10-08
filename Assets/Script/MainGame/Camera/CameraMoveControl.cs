using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMoveControl : MonoBehaviour
{
    Transform originalLocation, originalRotation;

    void Start()
    {
        originalLocation.position = transform.position;
        originalRotation.rotation = transform.rotation;
    }

    void FixedUpdate()
    {
        switch (ChangeCameraControl.changeCameraNum)
        {
            case 1:
                if (gameObject.tag == "P1Camera")
                {
                    
                }
                break;

            case 2:
                if (gameObject.tag == "P2Camera")
                {

                }
                break;

            case 3:
                if (gameObject.tag == "P3Camera")
                {

                }
                break;

            case 4:
                if (gameObject.tag == "P4Camera")
                {

                }
                break;
        }
    }
}
