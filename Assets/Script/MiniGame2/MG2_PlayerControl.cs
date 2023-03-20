using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MG2_PlayerControl : MonoBehaviour
{
    void Start()
    {
        
    }

    void Update()
    {
        if (Input.GetKey("a"))
        {
            transform.Translate(-3, 0, 0);
        }
        if (Input.GetKey("d"))
        {
            transform.Translate(3, 0, 0);
        }
    }
}
