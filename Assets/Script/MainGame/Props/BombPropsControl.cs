using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BombPropsControl : MonoBehaviour
{
    public static int pointNum;

    void FixedUpdate()
    {
        transform.Rotate(0, -1, 0);
    }

    private void OnTriggerEnter(Collider other)
    {
        
    }
}
