using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class MoveControl : MonoBehaviour
{
    public Transform p1;
    public Transform p2;
    public Transform p3;
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
            
        }
    }
}
