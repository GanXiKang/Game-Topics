using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MonkeyPowerControl : MonoBehaviour
{
    public GameObject banana;
    public Transform insBananaPoint;
    public static bool isP1InsBanana = false, isP2InsBanana = false, isP3InsBanana = false, isP4InsBanana = false;

    void Update()
    {
        if (BagUIControl.isBomb)
        {
            switch (ChangeCameraControl.changeCameraNum)
            {
                case 1:
                    if (gameObject.tag == "P1")
                    {
                        isP1InsBanana = true;
                        BananaControl.pointNum = DiceControl.P1_totalNum;
                        Instantiate(banana, insBananaPoint.position, insBananaPoint.rotation);
                    }
                    break;

                case 2:
                    if (gameObject.tag == "P2")
                    {
                        isP2InsBanana = true;
                        BananaControl.pointNum = DiceControl.P2_totalNum;
                        Instantiate(banana, insBananaPoint.position, insbananaPoint.rotation);
                    }
                    break;

                case 3:
                    if (gameObject.tag == "P3")
                    {
                        isP3InsBanana = true;
                        BananaControl.pointNum = DiceControl.P3_totalNum;
                        Instantiate(banana, insBananaPoint.position, insBananaPoint.rotation);
                    }
                    break;

                case 4:
                    if (gameObject.tag == "P4")
                    {
                        isP4InsBanana = true;
                        BananaControl.pointNum = DiceControl.P4_totalNum;
                        Instantiate(banana, insBananaPoint.position, insBananaPoint.rotation);
                    }
                    break;
            }
            //BagUIControl.isBomb = false;
        }
    }
}
