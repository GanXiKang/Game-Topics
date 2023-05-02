using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class P2_MoveControl : MonoBehaviour
{
    public Transform[] p = new Transform[8];

    public static bool Award;                    //false : Wave , True : Jump

    void Start()
    {
        DOTween.SetTweensCapacity(500, 125);
    }
    void Update()
    {
        MovePoint();                        //����������
    }
    void MovePoint()
    {
        if (Dice.P2_totalNum == 0)
        {
            //transform.DOMove(p[0].transform.position, 1);
        }
        if (Dice.P2_totalNum == 1)
        {
            transform.DOMove(p[1].transform.position, 3);
            Award = false;
        }
        if (Dice.P2_totalNum == 2)
        {
            transform.DOMove(p[2].transform.position, 3);
            Award = true;
        }
        if (Dice.P2_totalNum == 3)
        {
            transform.DOMove(p[3].transform.position, 3);
            Award = false;
        }
        if (Dice.P2_totalNum == 4)
        {
            transform.DOMove(p[4].transform.position, 3);
            Award = false;
        }
        if (Dice.P2_totalNum == 5)
        {
            transform.DOMove(p[5].transform.position, 3);
            Award = true;
        }
        if (Dice.P2_totalNum == 6)
        {
            transform.DOMove(p[6].transform.position, 3);
            Award = false;
        }
        if (Dice.P2_totalNum > 6)
        {
            transform.DOMove(p[7].transform.position, 3);
            Award = false;
        }
    }
}
