using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MG5_CaughtControl : MonoBehaviour
{
    bool isCaught;
    void Update()
    {
        
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Hook")
        { 

        }
    }
}
