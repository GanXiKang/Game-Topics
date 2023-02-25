using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class MoveControl : MonoBehaviour
{
    public float recordNum = 0;            

    public GameObject[] p;

    void Start()
    {
        p = GameObject.FindGameObjectsWithTag("Point");
        DOTween.SetTweensCapacity(500, 125);
    }
    void Update()
    {
        MovePoint();
    }
    void MovePoint()
    {
        if (Dice.diceNum == 1)
        {
            transform.DOMove(p[5].transform.position + new Vector3(0, 6, 0), 1);
        }
        if (Dice.diceNum == 2)
        {
            transform.DOMove(p[4].transform.position + new Vector3(0, 6, 0), 1);
        }
        if (Dice.diceNum == 3)
        {
            transform.DOMove(p[3].transform.position + new Vector3(0, 6, 0), 1);
        }
        if (Dice.diceNum == 4)
        {
            transform.DOMove(p[2].transform.position + new Vector3(0, 6, 0), 1);
        }
        if (Dice.diceNum == 5)
        {
            transform.DOMove(p[1].transform.position + new Vector3(0, 6, 0), 1);
        }
        if (Dice.diceNum == 6)
        {
            transform.DOMove(p[0].transform.position + new Vector3(0, 6, 0), 1);
        }
    }
}
