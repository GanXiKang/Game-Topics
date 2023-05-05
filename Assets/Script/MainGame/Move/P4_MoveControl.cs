using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class P4_MoveControl : MonoBehaviour
{
    NavMeshAgent agent;
    GameObject[] p = new GameObject[11];

    public static bool Award;

    void Start()
    {
        agent = GetComponent<NavMeshAgent>();

        TransformPoint();
    }
    void Update()
    {
        MovePoint();
    }
    void MovePoint()
    {
        for (int i = 1; i < p.Length; i++)
        {
            if (Dice.P4_totalNum == i)
            {
                agent.SetDestination(p[i].transform.position);
            }
        }

        if (Dice.P4_totalNum > 10)
        {
            agent.SetDestination(p[10].transform.position);
        }
    }
    void TransformPoint()
    {
        p[1] = GameObject.Find("Point1");
        p[2] = GameObject.Find("Point2");
        p[3] = GameObject.Find("Point3");
        p[4] = GameObject.Find("Point4");
        p[5] = GameObject.Find("Point5");
        p[6] = GameObject.Find("Point6");
        p[7] = GameObject.Find("Point7");
        p[8] = GameObject.Find("Point8");
        p[9] = GameObject.Find("Point9");
        p[10] = GameObject.Find("Point10");
    }
}
