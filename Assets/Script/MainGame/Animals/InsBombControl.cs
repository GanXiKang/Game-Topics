using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InsBombControl : MonoBehaviour
{
    public GameObject bombProps;
    public Transform insBombPoint;
    public static bool isP1InsBomb = false, isP2InsBomb = false, isP3InsBomb = false, isP4InsBomb = false;

    bool isInsOnce = true;

    void Update()
    {
        switch (ChangeCameraControl.changeCameraNum)
        {
            case 1:
                if (gameObject.tag == "P1")
                {
                    if (isP1InsBomb)
                    {
                        if (isInsOnce)
                        {
                            BombPropsControl.pointNum = DiceControl.P1_totalNum;
                            Instantiate(bombProps, insBombPoint.position, insBombPoint.rotation);
                            isInsOnce = false;
                            Invoke("TrueByIns", 5f);
                        }
                    }
                }
                break;

            case 2:
                if (gameObject.tag == "P2")
                {
                    if (isP2InsBomb)
                    {
                        if (isInsOnce)
                        {
                            BombPropsControl.pointNum = DiceControl.P2_totalNum;
                            Instantiate(bombProps, insBombPoint.position, insBombPoint.rotation);
                            isInsOnce = false;
                            Invoke("TrueByIns", 5f);
                        }
                    }
                }
                break;

            case 3:
                if (gameObject.tag == "P3")
                {
                    if (isP3InsBomb)
                    {
                        if (isInsOnce)
                        {
                            BombPropsControl.pointNum = DiceControl.P3_totalNum;
                            Instantiate(bombProps, insBombPoint.position, insBombPoint.rotation);
                            isInsOnce = false;
                            Invoke("TrueByIns", 5f);
                        }
                    }
                }
                break;

            case 4:
                if (gameObject.tag == "P4")
                {
                    if (isP4InsBomb)
                    {
                        if (isInsOnce)
                        {
                            BombPropsControl.pointNum = DiceControl.P4_totalNum;
                            Instantiate(bombProps, insBombPoint.position, insBombPoint.rotation);
                            isInsOnce = false;
                            Invoke("TrueByIns", 5f);
                        }
                    }
                }
                break;
        }
    }

    void TrueByIns()
    {
        isInsOnce = true;
    }
}
