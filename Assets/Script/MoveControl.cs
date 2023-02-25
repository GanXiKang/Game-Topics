using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class MoveControl : MonoBehaviour
{
    public Transform p1;
    public float recordNum = 0;            

    public GameObject[] p;

    void Start()
    {
        p = GameObject.FindGameObjectsWithTag("Point");
    }
    void Update()
    {
        MovePoint();
    }
    void MovePoint()
    {
        if (Dice.diceNum == 1)
        {
            transform.DOMove(p1.transform.position + new Vector3(0, 6, 0), 1);
        }
    }
}
