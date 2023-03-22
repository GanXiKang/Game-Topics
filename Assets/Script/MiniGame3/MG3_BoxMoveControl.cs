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
        }
    }
    void DownAllBox()
    {
        box1.transform.position = new Vector3(-6, 2.5f, -5);
        box2.transform.position = new Vector3(0, 2.5f, -5);
        box3.transform.position = new Vector3(6, 2.5f, -5);
    }
}
