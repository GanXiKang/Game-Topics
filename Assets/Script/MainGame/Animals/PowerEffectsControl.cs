using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerEffectsControl : MonoBehaviour
{
    public GameObject effects;

    void Update()
    {
        switch (ChangeCameraControl.changeCameraNum)
        {
            case 1:
                if (gameObject.tag == "P1")
                {
                    
                }
                break;

            case 2:
                if (gameObject.tag == "P2")
                {

                }
                break;

            case 3:
                if (gameObject.tag == "P3")
                {

                }
                break;

            case 4:
                if (gameObject.tag == "P4")
                {

                }
                break;
        }
    }
}
