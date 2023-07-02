using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class PlayerMoveControl : MonoBehaviour
{
    NavMeshAgent agent;
    Rigidbody rb;

    GameObject[] p = new GameObject[11];

    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
        rb = GetComponent<Rigidbody>();

        TransformPoint();
    }
    void Update()
    {
        if (!MiniGameColliderControl.isMiniGame)
        {
            if (gameObject.tag == "P1")
            {
                P1MovePoint();
            }
            if (gameObject.tag == "P2")
            {
                P2MovePoint();
            }
            if (gameObject.tag == "P3")
            {
                P3MovePoint();
            }
            if (gameObject.tag == "P4")
            {
                P4MovePoint();
            }
        }
        if (Input.GetKeyDown(KeyCode.Space))
        {
            print("Yes");
            rb.AddForce(Vector3.up * 5, ForceMode.Impulse);
        }
    }
    void P1MovePoint()
    {
        for (int i = 1; i < p.Length; i++)
        {
            if (Dice.P1_totalNum == i)
            {
                agent.SetDestination(p[i].transform.position);
            }
        }

        if (Dice.P1_totalNum > 10)
        {
            agent.SetDestination(p[10].transform.position);
        }
    }
    void P2MovePoint()
    {
        for (int i = 1; i < p.Length; i++)
        {
            if (Dice.P2_totalNum == i)
            {
                agent.SetDestination(p[i].transform.position);
            }
        }

        if (Dice.P2_totalNum > 10)
        {
            agent.SetDestination(p[10].transform.position);
        }
    }
    void P3MovePoint()
    {
        for (int i = 1; i < p.Length; i++)
        {
            if (Dice.P3_totalNum == i)
            {
                agent.SetDestination(p[i].transform.position);
            }
        }

        if (Dice.P3_totalNum > 10)
        {
            agent.SetDestination(p[10].transform.position);
        }
    }
    void P4MovePoint()
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
