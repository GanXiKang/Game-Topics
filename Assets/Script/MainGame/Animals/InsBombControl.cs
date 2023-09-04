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
                        BombPropsControl.pointNum = DiceControl.P1_totalNum;
                        Instantiate(bombProps, insBombPoint.position, insBombPoint.rotation);
                    }
                    break;

                case 2:
                    if (gameObject.tag == "P2")
                    {
                        BombPropsControl.pointNum = DiceControl.P2_totalNum;
                        Instantiate(bombProps, insBombPoint.position, insBombPoint.rotation);
                    }
                    break;

                case 3:
                    if (gameObject.tag == "P3")
                    {
                        BombPropsControl.pointNum = DiceControl.P3_totalNum;
                        Instantiate(bombProps, insBombPoint.position, insBombPoint.rotation);
                    }
                    break;

                case 4:
                    if (gameObject.tag == "P4")
                    {
                        BombPropsControl.pointNum = DiceControl.P4_totalNum; 
                        Instantiate(bombProps, insBombPoint.position, insBombPoint.rotation);
                    }
                    break;
            }
            BagUIControl.isBomb = false;
        }
    }
}
