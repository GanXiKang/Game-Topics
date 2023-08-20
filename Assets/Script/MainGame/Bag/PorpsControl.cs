using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PorpsControl : MonoBehaviour
{
    public static int[] P1Porps = new int[7];
    public static int[] P2Porps = new int[7];
    public static int[] P3Porps = new int[7];
    public static int[] P4Porps = new int[7];

    void Start()
    {
        Initial();
    }

    void Update()
    {
        
    }
    void Initial()
    {
        P1Porps[0] = 0;
        P1Porps[1] = 0;
        P1Porps[2] = 0;
        P1Porps[3] = 0;
        P1Porps[4] = 0;
        P1Porps[5] = 0;
        P1Porps[6] = 0;
        P2Porps[0] = 0;
        P2Porps[1] = 0;
        P2Porps[2] = 0;
        P2Porps[3] = 0;
        P2Porps[4] = 0;
        P2Porps[5] = 0;
        P2Porps[6] = 0;
        P3Porps[0] = 0;
        P3Porps[1] = 0;
        P3Porps[2] = 0;
        P3Porps[3] = 0;
        P3Porps[4] = 0;
        P3Porps[5] = 0;
        P3Porps[6] = 0;
        P4Porps[0] = 0;
        P4Porps[1] = 0;
        P4Porps[2] = 0;
        P4Porps[3] = 0;
        P4Porps[4] = 0;
        P4Porps[5] = 0;
        P4Porps[6] = 0;
    }
}
