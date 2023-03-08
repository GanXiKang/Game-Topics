using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class MoveControl : MonoBehaviour
{
    public float recordNum = 0;            
    public Transform[] p = new Transform[8];

    private float pointNum = 0;

    void Start()
    {
        DOTween.SetTweensCapacity(500, 125);
    }
    void FixedUpdate()
    {
        MovePoint();                        //文字骰子用
        //MoveDicePoint();                 //3D骰子用
    }
    void MovePoint()
    {
        if (Dice.totalNum == 1)
        {
            transform.DOMove(p[1].transform.position, 1);
        }
        if (Dice.totalNum == 2)
        {
            transform.DOMove(p[2].transform.position, 1);
        }
        if (Dice.totalNum == 3)
        {
            transform.DOMove(p[3].transform.position, 3);
        }
        if (Dice.totalNum == 4)
        {
            transform.DOMove(p[4].transform.position, 1);
        }
        if (Dice.totalNum == 5)
        {
            transform.DOMove(p[5].transform.position, 1);
        }
        if (Dice.totalNum == 6)
        {
            transform.DOMove(p[6].transform.position, 1);
        }
        if (Dice.totalNum > 6)
        {
            transform.DOMove(p[7].transform.position, 1);
        }
    }
    void MoveDicePoint()
    {
        if (DiceColliderZoneControl.totalNum == 1)
        {
            transform.DOMove(p[6].transform.position + new Vector3(0, 6, 0), 1);
        }
        if (DiceColliderZoneControl.totalNum == 2)
        {
            transform.DOMove(p[5].transform.position + new Vector3(0, 6, 0), 1);
        }
        if (DiceColliderZoneControl.totalNum == 3)
        {
            transform.DOMove(p[4].transform.position + new Vector3(0, 6, 0), 1);
        }
        if (DiceColliderZoneControl.totalNum == 4)
        {
            transform.DOMove(p[3].transform.position + new Vector3(0, 6, 0), 1);
        }
        if (DiceColliderZoneControl.totalNum == 5)
        {
            transform.DOMove(p[2].transform.position + new Vector3(0, 6, 0), 1);
        }
        if (DiceColliderZoneControl.totalNum == 6)
        {
            transform.DOMove(p[1].transform.position + new Vector3(0, 6, 0), 1);
        }
        if (DiceColliderZoneControl.totalNum > 6)
        {
            transform.DOMove(p[0].transform.position + new Vector3(0, 6, 0), 1);
        }
    }
}
