using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MG3_BoxMoveControl : MonoBehaviour
{
    public GameObject box1, box2,box3;

    public static bool openBox1, openBox2, openBox3;

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
                openBox1 = false;
            }
            if (openBox2 == true)
            {
                box2.transform.position = new Vector3(0, 6, -5);
                openBox2 = false;
            }
            if (openBox3 == true)
            {
                box3.transform.position = new Vector3(6, 6, -5);
                openBox3 = false;
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

