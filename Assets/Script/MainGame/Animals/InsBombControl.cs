using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InsBombControl : MonoBehaviour
{
    public GameObject bombProps;
    public Transform insBombPoint;

    void Update()
    {
        if (BagUIControl.isBomb)
        {
            switch (ChangeCameraControl.changeCameraNum)
            {
                case 1:
                    if (gameObject.tag == "P1")
                    {
                        DiceControl.P1_totalNum = BombPropsControl.pointNum;
                        Instantiate(bombProps, insBombPoint.position, insBombPoint.rotation);
                    }
                    break;

                case 2:
                    if (gameObject.tag == "P2")
                    {
                        DiceControl.P2_totalNum = BombPropsControl.pointNum;
                        Instantiate(bombProps, insBombPoint.position, insBombPoint.rotation);
                    }
                    break;

                case 3:
                    if (gameObject.tag == "P3")
                    {
                        DiceControl.P3_totalNum = BombPropsControl.pointNum;
                        Instantiate(bombProps, insBombPoint.position, insBombPoint.rotation);
                    }
                    break;

                case 4:
                    if (gameObject.tag == "P4")
                    {
                        DiceControl.P4_totalNum = BombPropsControl.pointNum;
                        Instantiate(bombProps, insBombPoint.position, insBombPoint.rotation);
                    }
                    break;
            }
            BagUIControl.isBomb = false;
        }
    }
}
