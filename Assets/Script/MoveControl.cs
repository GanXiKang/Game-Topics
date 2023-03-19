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
    //NavMeshAgent agent;

    void Start()
    {
        DOTween.SetTweensCapacity(500, 125);
        //agent = GetComponent<NavMeshAgent>();
    }
    void Update()
    {
        MovePoint();                        //文字骰子用
        //MoveDicePoint();                 //3D骰子用
    }
    void MovePoint()
    {
        if (Dice.totalNum == 0)
        {
            transform.DOMove(p[0].transform.position, 1);
        }
        if (Dice.totalNum == 1)
        {
            //agent.SetDestination(p[1].transform.position);
            transform.DOMove(p[1].transform.position, 10);
            Award = false;
        }
        if (Dice.totalNum == 2)
        {
            transform.DOMove(p[2].transform.position, 10);
            Award = true;
        }
        if (Dice.totalNum == 3)
        {
            transform.DOMove(p[3].transform.position, 10);
            Award = false;
        }
        if (Dice.totalNum == 4)
        {
            transform.DOMove(p[4].transform.position, 10);
            Award = false;
        }
        if (Dice.totalNum == 5)
        {
            transform.DOMove(p[5].transform.position, 10);
            Award = true;
        }
        if (Dice.totalNum == 6)
        {
            transform.DOMove(p[6].transform.position, 10);
            Award = false;
        }
        if (Dice.totalNum > 6)
        {
            transform.DOMove(p[7].transform.position, 10);
            Award = false;
        }
    }
    //void MoveDicePoint()
    //{
    //    if (DiceColliderZoneControl.totalNum == 1)
    //    {
    //        transform.DOMove(p[6].transform.position, 2);
    //    }
    //    if (DiceColliderZoneControl.totalNum == 2)
    //    {
    //        transform.DOMove(p[5].transform.position, 2);
    //    }
    //    if (DiceColliderZoneControl.totalNum == 3)
    //    {
    //        transform.DOMove(p[4].transform.position, 2);
    //    }
    //    if (DiceColliderZoneControl.totalNum == 4)
    //    {
    //        transform.DOMove(p[3].transform.position, 2);
    //    }
    //    if (DiceColliderZoneControl.totalNum == 5)
    //    {
    //        transform.DOMove(p[2].transform.position, 2);
    //    }
    //    if (DiceColliderZoneControl.totalNum == 6)
    //    {
    //        transform.DOMove(p[1].transform.position, 2);
    //    }
    //    if (DiceColliderZoneControl.totalNum > 6)
    //    {
    //        transform.DOMove(p[0].transform.position, 2);
    //    }
    //}
}
