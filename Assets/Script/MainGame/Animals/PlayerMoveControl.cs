using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class PlayerMoveControl : MonoBehaviour
{
    NavMeshAgent agent;

    GameObject[] p = new GameObject[61];

    public static bool isMove = true;

    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
        TransformPoint();
    }
    void Update()
    {
        if (!MiniGameColliderControl.isMiniGame || isMove)
        {
            if (gameObject.tag == "P1")
            {
                P1MovePoint();
            }
            else if (gameObject.tag == "P2")
            {
                P2MovePoint();
            }
            else if (gameObject.tag == "P3")
            {
                P3MovePoint();
            }
            else if (gameObject.tag == "P4")
            {
                P4MovePoint();
            }
        }
    }
    void P1MovePoint()
    {
        for (int i = 1; i < p.Length; i++)
        {
            if (DiceControl.P1_totalNum == i)
            {
                agent.SetDestination(p[i].transform.position);
            }
        }

        if (DiceControl.P1_totalNum < 1)
        {
            agent.SetDestination(p[1].transform.position);
        }
        if (DiceControl.P1_totalNum > 60)
        {
            agent.SetDestination(p[60].transform.position);
        }
    }
    void P2MovePoint()
    {
        for (int i = 1; i < p.Length; i++)
        {
            if (DiceControl.P2_totalNum == i)
            {
                agent.SetDestination(p[i].transform.position);
            }
        }

        if (DiceControl.P2_totalNum < 1)
        {
            agent.SetDestination(p[1].transform.position);
        }
        if (DiceControl.P2_totalNum > 60)
        {
            agent.SetDestination(p[60].transform.position);
        }
    }
    void P3MovePoint()
    {
        for (int i = 1; i < p.Length; i++)
        {
            if (DiceControl.P3_totalNum == i)
            {
                agent.SetDestination(p[i].transform.position);
            }
        }

        if (DiceControl.P3_totalNum < 1)
        {
            agent.SetDestination(p[1].transform.position);
        }
        if (DiceControl.P3_totalNum > 60)
        {
            agent.SetDestination(p[60].transform.position);
        }
    }
    void P4MovePoint()
    {
        for (int i = 1; i < p.Length; i++)
        {
            if (DiceControl.P4_totalNum == i)
            {
                agent.SetDestination(p[i].transform.position);
            }
        }

        if (DiceControl.P4_totalNum < 1)
        {
            agent.SetDestination(p[1].transform.position);
        }
        if (DiceControl.P4_totalNum > 60)
        {
            agent.SetDestination(p[60].transform.position);
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
        p[11] = GameObject.Find("Point11");
        p[12] = GameObject.Find("Point12");
        p[13] = GameObject.Find("Point13");
        p[14] = GameObject.Find("Point14");
        p[15] = GameObject.Find("Point15");
        p[16] = GameObject.Find("Point16");
        p[17] = GameObject.Find("Point17");
        p[18] = GameObject.Find("Point18");
        p[19] = GameObject.Find("Point19");
        p[20] = GameObject.Find("Point20");
        p[21] = GameObject.Find("Point21");
        p[22] = GameObject.Find("Point22");
        p[23] = GameObject.Find("Point23");
        p[24] = GameObject.Find("Point24");
        p[25] = GameObject.Find("Point25");
        p[26] = GameObject.Find("Point26");
        p[27] = GameObject.Find("Point27");
        p[28] = GameObject.Find("Point28");
        p[29] = GameObject.Find("Point29");
        p[30] = GameObject.Find("Point30");
        p[31] = GameObject.Find("Point31");
        p[32] = GameObject.Find("Point32");
        p[33] = GameObject.Find("Point33");
        p[34] = GameObject.Find("Point34");
        p[35] = GameObject.Find("Point35");
        p[36] = GameObject.Find("Point36");
        p[37] = GameObject.Find("Point37");
        p[38] = GameObject.Find("Point38");
        p[39] = GameObject.Find("Point39");
        p[40] = GameObject.Find("Point40");
        p[41] = GameObject.Find("Point41");
        p[42] = GameObject.Find("Point42");
        p[43] = GameObject.Find("Point43");
        p[44] = GameObject.Find("Point44");
        p[45] = GameObject.Find("Point45");
        p[46] = GameObject.Find("Point46");
        p[47] = GameObject.Find("Point47");
        p[48] = GameObject.Find("Point48");
        p[49] = GameObject.Find("Point49");
        p[50] = GameObject.Find("Point50");
        p[51] = GameObject.Find("Point51");
        p[52] = GameObject.Find("Point52");
        p[53] = GameObject.Find("Point53");
        p[54] = GameObject.Find("Point54");
        p[55] = GameObject.Find("Point55");
        p[56] = GameObject.Find("Point56");
        p[57] = GameObject.Find("Point57");
        p[58] = GameObject.Find("Point58");
        p[59] = GameObject.Find("Point59");
        p[60] = GameObject.Find("Point60");
    }
}
