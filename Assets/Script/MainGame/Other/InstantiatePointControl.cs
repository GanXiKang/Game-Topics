using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InstantiatePointControl : MonoBehaviour
{
    public GameObject[] insPoint = new GameObject[4];
    public GameObject[] animals = new GameObject[4];

    public static bool isInstantiate = false; 
    void Update()
    {
        if (isInstantiate)
        {
            isInstantiate = false;
        }
    }
}
