using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PointJudgeControl : MonoBehaviour
{
    public static bool changeScene = false;

    GameObject[] p = new GameObject[11];

    int a, b, c, d;

    void Start()
    {
        TransformPoint();
    }
    void Update()
    {
        RecordPoint();

        if (changeScene)
        {
            for (int i = 0; i < 5; i++)
            {
                if (gameObject.tag == "P1")
                {
                    transform.position = p[a].transform.position;
                }
                if (gameObject.tag == "P2")
                {
                    transform.position = p[b].transform.position;
                }
                if (gameObject.tag == "P3")
                {
                    transform.position = p[c].transform.position;
                }
                if (gameObject.tag == "P4")
                {
                    transform.position = p[d].transform.position;
                }
            }
            changeScene = false;
        }
    }
    void TransformPoint()
    {
        p[1] = GameObject.Find("Point1");
        p[2] = GameObject.Find("Point2");
        p[3] = GameObject.Find("Point3");
        p[4] = GameObject.Find("Point4");
        p[5] = GameObject.Find("Point5");
        p[6] = GameObject.Find("Point6");
        p[7] = GameObject.Find("Point7");
        p[8] = GameObject.Find("Point8");
        p[9] = GameObject.Find("Point9");
        p[10] = GameObject.Find("Point10");
    }
    void RecordPoint()
    {
        a = Dice.P1_totalNum;
        b = Dice.P2_totalNum;
        c = Dice.P3_totalNum;
        d = Dice.P4_totalNum;
    }
}
