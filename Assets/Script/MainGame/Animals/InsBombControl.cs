using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InsBombControl : MonoBehaviour
{
    public GameObject bombProps;
    public Transform insBombPoint;
    public static bool isP1InsBomb = false, isP2InsBomb = false, isP3InsBomb = false, isP4InsBomb = false;

    void Update()
    {
        if (BagUIControl.isBomb)
        {
            switch (ChangeCameraControl.changeCameraNum)
            {
                case 1:
                    print("ok");
                    if (gameObject.tag == "P1")
                    {
                        print("1");
                        isP1InsBomb = true;
                        BombPropsControl.pointNum = DiceControl.P1_totalNum;
                        Instantiate(bombProps, insBombPoint.position, insBombPoint.rotation);
                    }
                    break;

                case 2:
                    if (gameObject.tag == "P2")
                    {
                        print("2");
                        isP2InsBomb = true;
                        BombPropsControl.pointNum = DiceControl.P2_totalNum;
                        Instantiate(bombProps, insBombPoint.position, insBombPoint.rotation);
                    }
                    break;

                case 3:
                    if (gameObject.tag == "P3")
                    {
                        print("3");
                        isP3InsBomb = true;
                        BombPropsControl.pointNum = DiceControl.P3_totalNum;
                        Instantiate(bombProps, insBombPoint.position, insBombPoint.rotation);
                    }
                    break;

                case 4:
                    if (gameObject.tag == "P4")
                    {
                        print("4");
                        isP4InsBomb = true;
                        BombPropsControl.pointNum = DiceControl.P4_totalNum; 
                        Instantiate(bombProps, insBombPoint.position, insBombPoint.rotation);
                    }
                    break;
            }
            BagUIControl.isBomb = false;
        }
    }
}
