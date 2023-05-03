using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class P1_MoveControl : MonoBehaviour
{
    GameObject[] p = new GameObject[8];

    public static bool Award;                    //false : Wave , True : Jump

    void Start()
    {
        DOTween.SetTweensCapacity(500, 125);
        
    }
    void Update()
    {
        MovePoint();                        //ÎÄ×Ö÷»×ÓÓÃ
        p[1] = GameObject.FindGameObjectWithTag("Point1");
        p[2] = GameObject.FindGameObjectWithTag("Point2");
        p[3] = GameObject.FindGameObjectWithTag("Point3");
        p[4] = GameObject.FindGameObjectWithTag("Point4");
        p[5] = GameObject.FindGameObjectWithTag("Point5");
        p[6] = GameObject.FindGameObjectWithTag("Point6");
        p[7] = GameObject.FindGameObjectWithTag("Point7");

    }
    void MovePoint()
    {
        if (Dice.P1_totalNum == 0)
        {
            //transform.DOMove(p[0].transform.position, 1);
        }
        if (Dice.P1_totalNum == 1)
        {
            transform.DOMove(p[1].transform.position, 3);
            Award = false;
        }
        if (Dice.P1_totalNum == 2)
        {
            transform.DOMove(p[2].transform.position, 3);
            Award = true;
        }
        if (Dice.P1_totalNum == 3)
        {
            transform.DOMove(p[3].transform.position, 3);
            Award = false;
        }
        if (Dice.P1_totalNum == 4)
        {
            transform.DOMove(p[4].transform.position, 3);
            Award = false;
        }
        if (Dice.P1_totalNum == 5)
        {
            transform.DOMove(p[5].transform.position, 3);
            Award = true;
        }
        if (Dice.P1_totalNum == 6)
        {
            transform.DOMove(p[6].transform.position, 3);
            Award = false;
        }
        if (Dice.P1_totalNum > 6)
        {
            transform.DOMove(p[7].transform.position, 5);
            Award = false;
        }
    }
}
