using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveControl : MonoBehaviour
{
    public float pointNum = 0;

    public Transform point1;
    public Transform point2;
    public Transform point3;
    public Transform point4;
    public Transform point5;
    public Transform point6;
    //Transform[] point = new Transform[7];

    void Start()
    {
        
    }
    void Update()
    {
        while(DiceColliderZoneControl.diceNumber > 0)
        {
            pointNum++;

            if (pointNum == 1)
            {
                transform.position = Vector3.MoveTowards(transform.position, point1.transform.position + new Vector3(0, 6, 0), 0.05f);
                DiceColliderZoneControl.diceNumber--;
            }
            if (pointNum == 2)
            {
                transform.position = Vector3.MoveTowards(transform.position, point2.transform.position + new Vector3(0, 6, 0), 0.05f);
                DiceColliderZoneControl.diceNumber--;
            }
            if (pointNum == 3)
            {
                transform.position = Vector3.MoveTowards(transform.position, point3.transform.position + new Vector3(0, 6, 0), 0.05f);
                DiceColliderZoneControl.diceNumber--;
            }
            if (pointNum == 4)
            {
                transform.position = Vector3.MoveTowards(transform.position, point4.transform.position + new Vector3(0, 6, 0), 0.05f);
                DiceColliderZoneControl.diceNumber--;
            }
            if (pointNum == 5)
            {
                transform.position = Vector3.MoveTowards(transform.position, point5.transform.position + new Vector3(0, 6, 0), 0.05f);
                DiceColliderZoneControl.diceNumber--;
            }
            if (pointNum == 6)
            {
                transform.position = Vector3.MoveTowards(transform.position, point6.transform.position + new Vector3(0, 6, 0), 0.05f);
                DiceColliderZoneControl.diceNumber--;
            }
        }
        
    }
}
