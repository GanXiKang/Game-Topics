using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MG3_BoxMoveControl : MonoBehaviour
{
    public static float PlayGameNum = 0;

    public GameObject box1;
    public GameObject box2;
    public GameObject box3;

    public Transform boxPoint1;
    public Transform boxPoint2;
    public Transform boxPoint3;

    void Update()
    {
        if (PlayGameNum == 1)
        {
            DownAllBox();
            MoveBox();
        }
    }
    void DownAllBox()
    {
        box1.transform.position = boxPoint1.transform.position;
        box2.transform.position = boxPoint2.transform.position;
        box3.transform.position = boxPoint3.transform.position;
    }
    void MoveBox()
    {
        box1.transform.position = boxPoint2.transform.position;
        box2.transform.position = boxPoint1.transform.position;
    }
}

