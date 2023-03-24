using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MG3_BoxMoveControl : MonoBehaviour
{
    public GameObject box1;
    public GameObject box2;
    public GameObject box3;

    public static bool openBox1;
    public static bool openBox2;
    public static bool openBox3;

    void Update()
    {
        if (MG3_ButtonControl.round <= 3)
        {
            if (MG3_ButtonControl.downCup == true)
            {
                MG3_ButtonControl.downCup = false;
                DownCup();
            }
            if (openBox1 == true)
            {
                box1.transform.position = new Vector3(-6, 6, -5);
            }
            if (openBox2 == true)
            {
                box2.transform.position = new Vector3(0, 6, -5);
            }
            if (openBox3 == true)
            {
                box3.transform.position = new Vector3(6, 6, -5);
            }
        }
    }
    void DownCup()
    {
        box1.transform.position = new Vector3(-6, 2.5f, -5);
        box2.transform.position = new Vector3(0, 2.5f, -5);
        box3.transform.position = new Vector3(6, 2.5f, -5);
    }
}

