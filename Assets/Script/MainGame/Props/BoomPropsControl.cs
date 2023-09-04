using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoomPropsControl : MonoBehaviour
{
    void FixedUpdate()
    {
        transform.Rotate(0, -1, 0);
    }

    private void OnTriggerEnter(Collider other)
    {
        
    }
}
