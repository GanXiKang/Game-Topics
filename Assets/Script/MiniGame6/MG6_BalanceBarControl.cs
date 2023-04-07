using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MG6_BalanceBarControl : MonoBehaviour
{
    void Start()
    {
        
    }
    void Update()
    {
        if (Input.GetMouseButton(0))
        {
            print("0");
        }
        if (Input.GetMouseButtonDown(1))
        {
            print("1");
        }
        if (Input.GetMouseButtonUp(0))
        {
            print("no 1");
        }
    }
}
