using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MG4_RoadBlockControl : MonoBehaviour
{
    public static float combo = 0;
    public static bool hit = false;

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "RoadBlock")
        {
            combo = 0;
            hit = true;
            Destroy(other.gameObject, 0.3f);
        }
        if (other.tag == "RecordJump")
        {
            combo++;
        }
    }
}
