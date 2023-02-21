using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveControl : MonoBehaviour
{ 
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
        float n = DiceColliderZoneControl.diceNumber;




        if (n == 1)
        {
            transform.position = Vector3.MoveTowards(transform.position, point1.transform.position + new Vector3(0, 6, 0), 0.05f);

        }
        if (n == 2)
        {
            transform.position = Vector3.MoveTowards(transform.position, point2.transform.position + new Vector3(0, 6, 0), 0.05f);

        }
        if (n == 3)
        {
            transform.position = Vector3.MoveTowards(transform.position, point3.transform.position + new Vector3(0, 6, 0), 0.05f);

        }
        if (n == 4)
        {
            transform.position = Vector3.MoveTowards(transform.position, point4.transform.position + new Vector3(0, 6, 0), 0.05f);

        }
        if (n == 5)
        {
            transform.position = Vector3.MoveTowards(transform.position, point5.transform.position + new Vector3(0, 6, 0), 0.05f);

        }
        if (n == 6)
        {
            transform.position = Vector3.MoveTowards(transform.position, point6.transform.position + new Vector3(0, 6, 0), 0.05f);

        }
    

    }
}
