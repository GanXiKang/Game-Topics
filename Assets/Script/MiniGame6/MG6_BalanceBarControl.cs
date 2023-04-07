using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MG6_BalanceBarControl : MonoBehaviour
{
    void Start()
    {
        
    }
    void FixedUpdate()
    {
        if (Input.GetMouseButton(0))
        {
            print("yes");
        }
        if (Input.GetMouseButtonUp(0))
        {
            print("no");
        }
    }
}
