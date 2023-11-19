using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerEffectsControl : MonoBehaviour
{
    public GameObject effects;
    public GameObject point

    void Update()
    {
        if (AnimalsPowerControl.isPowerEffects)
        {
            switch (ChangeCameraControl.changeCameraNum)
            {
                case 1:
                    if (gameObject.tag == "P1")
                    {
                        Instantiate(effects, point.transform.position, point.transform.rotation);
                        print("ok");
                        AnimalsPowerControl.isPowerEffects = false;
                    }
                    break;

                case 2:
                    if (gameObject.tag == "P2")
                    {
                        Instantiate(effects, transform.position, transform.rotation);
                    }
                    break;

                case 3:
                    if (gameObject.tag == "P3")
                    {
                        Instantiate(effects, transform.position, transform.rotation);
                    }
                    break;

                case 4:
                    if (gameObject.tag == "P4")
                    {
                        Instantiate(effects, transform.position, transform.rotation);
                    }
                    break;
            }
        }
    }
}
