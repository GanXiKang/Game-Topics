using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
//using UnityEngine.AI;

public class MoveControl : MonoBehaviour
{
    public Transform[] p = new Transform[8];

    public static bool Award;                    //false : Wave , True : Jump

    Rigidbody rb;

    void Start()
    {
        DOTween.SetTweensCapacity(500, 125);
    }
    void Update()
    {
        MovePoint();                        //ÎÄ×Ö÷»×ÓÓÃ
    }
    void MovePoint()
    {
        if (Dice.totalNum == 0)
        {
            transform.DOMove(p[0].transform.position, 1);
        }
        if (Dice.totalNum == 1)
        {
            transform.DOMove(p[1].transform.position, 5);
            Award = false;
        }
        if (Dice.totalNum == 2)
        {
            transform.DOMove(p[2].transform.position, 5);
            Award = true;
        }
        if (Dice.totalNum == 3)
        {
            transform.DOMove(p[3].transform.position, 5);
            Award = false;
        }
        if (Dice.totalNum == 4)
        {
            transform.DOMove(p[4].transform.position, 5);
            Award = false;
        }
        if (Dice.totalNum == 5)
        {
            transform.DOMove(p[5].transform.position, 5);
            Award = true;
        }
        if (Dice.totalNum == 6)
        {
            transform.DOMove(p[6].transform.position, 5);
            Award = false;
        }
        if (Dice.totalNum > 6)
        {
            transform.DOMove(p[7].transform.position, 5);
            Award = false;
        }
    }
}
