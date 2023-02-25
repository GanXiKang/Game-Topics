using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveControl : MonoBehaviour
{
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
            transform.position = Vector3.MoveTowards(transform.position, p[1].transform.position, 0.05f);
            Dice.diceNum--;
            Debug.Log(Dice.diceNum);
        }
    }
}
