using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PropsControl : MonoBehaviour
{
    public static int[] P1Props = new int[7];
    public static int[] P2Props = new int[7];
    public static int[] P3Props = new int[7];
    public static int[] P4Props = new int[7];

    void Start()
    {
        Initial();
    }

    void Update()
    {

    }
    void Initial()
    {
        P1Props[0] = 0;
        P1Props[1] = 0;
        P1Props[2] = 0;
        P1Props[3] = 0;
        P1Props[4] = 0;
        P1Props[5] = 0;
        P1Props[6] = 0;
        P2Props[0] = 0;
        P2Props[1] = 0;
        P2Props[2] = 0;
        P2Props[3] = 0;
        P2Props[4] = 0;
        P2Props[5] = 0;
        P2Props[6] = 0;
        P3Props[0] = 0;
        P3Props[1] = 0;
        P3Props[2] = 0;
        P3Props[3] = 0;
        P3Props[4] = 0;
        P3Props[5] = 0;
        P3Props[6] = 0;
        P4Props[0] = 0;
        P4Props[1] = 0;
        P4Props[2] = 0;
        P4Props[3] = 0;
        P4Props[4] = 0;
        P4Props[5] = 0;
        P4Props[6] = 0;
    }
}
