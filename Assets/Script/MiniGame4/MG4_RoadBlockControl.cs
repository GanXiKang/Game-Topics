using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MG4_RoadBlockControl : MonoBehaviour
{
    public static float combo = 0;

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "RoadBlock")
        {
            combo = 0;
            print(combo);
        }
        if (other.tag == "RecordJump")
        {
            combo++;
            print(combo);
        }
    }
}
