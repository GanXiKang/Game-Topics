using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveControl : MonoBehaviour
{
    public Transform p0;
    public Transform p1;
    public Transform p2;
    public Transform p3;
    public Transform p4;
    public Transform p5;
    public Transform p6;
    public Transform p7;
    public Transform p8;
    public Transform p9;
    public Transform p10;
    public Transform p11;
    public Transform p12;

    public float recordNum = 0;

    Transform[] p = new Transform[13];

    void Start()
    {
        //p[0] = GameObject.Find("0");          //BUG
        //for (int i = 0, i < 13, i++)          //BUG
        //{ 
        //}
        p[1] = p1;
        p[2] = p2;
        p[3] = p3;
        p[4] = p4;
        p[5] = p5;
        p[6] = p6;
        p[7] = p7;
        p[8] = p8;
        p[9] = p9;
        p[10] = p10;
        p[11] = p11;
        p[12] = p12;
    }
    void Update()
    {
        if (Dice.diceNum > 0)
        {
            recordNum++;
            Debug.Log(recordNum);
            if (recordNum == 1)
            {
                transform.position = Vector3.MoveTowards(transform.position, p[1].transform.position + new Vector3(0, 6, 0), 0.05f);
            }
            if (recordNum == 2)
            {
                transform.position = Vector3.MoveTowards(transform.position, p[2].transform.position + new Vector3(0, 6, 0), 0.05f);
            }
            if (recordNum == 3)
            {
                transform.position = Vector3.MoveTowards(transform.position, p[3].transform.position + new Vector3(0, 6, 0), 0.05f);
            }
            if (recordNum == 4)
            {
                transform.position = Vector3.MoveTowards(transform.position, p[4].transform.position + new Vector3(0, 6, 0), 0.05f);
            }
            if (recordNum == 5)
            {
                transform.position = Vector3.MoveTowards(transform.position, p[5].transform.position + new Vector3(0, 6, 0), 0.05f);
            }
            if (recordNum == 6)
            {
                transform.position = Vector3.MoveTowards(transform.position, p[6].transform.position + new Vector3(0, 6, 0), 0.05f);
            }
            Dice.diceNum--;
        }
        //float n = DiceColliderZoneControl.diceNumber;
        ////pointNum += n;                                    //每次更新太快了
        ////print(pointNum);
        //if (n == 1)
        //{
        //    transform.position = Vector3.MoveTowards(transform.position, point1.transform.position + new Vector3(0, 6, 0), 0.05f);
            
        //}
        //if (n == 2)
        //{
        //    transform.position = Vector3.MoveTowards(transform.position, point2.transform.position + new Vector3(0, 6, 0), 0.05f);
            
        //}
        //if (n == 3)
        //{
        //    transform.position = Vector3.MoveTowards(transform.position, point3.transform.position + new Vector3(0, 6, 0), 0.05f);
            
        //}
        //if (n == 4)
        //{
        //    transform.position = Vector3.MoveTowards(transform.position, point4.transform.position + new Vector3(0, 6, 0), 0.05f);
            
        //}
        //if (n == 5)
        //{
        //    transform.position = Vector3.MoveTowards(transform.position, point5.transform.position + new Vector3(0, 6, 0), 0.05f);
            
        //}
        //if (n == 6)
        //{
        //    transform.position = Vector3.MoveTowards(transform.position, point6.transform.position + new Vector3(0, 6, 0), 0.05f);
            
        //}
    }
}
