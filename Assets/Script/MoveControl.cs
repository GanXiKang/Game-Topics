using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveControl : MonoBehaviour
{
    public float recordNum = 0;

    public GameObject[] p;

    void Start()
    {
        p = GameObject.FindGameObjectsWithTag("Point");
    }
    void Update()
    {
        
    }
}
