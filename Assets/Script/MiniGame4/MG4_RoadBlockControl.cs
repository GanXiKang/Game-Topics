using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MG4_RoadBlockControl : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name == "RoadBlock")
        {
            print("aaaa");
        }
    }
}
