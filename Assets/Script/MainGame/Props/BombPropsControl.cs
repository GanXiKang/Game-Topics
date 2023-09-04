using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BombPropsControl : MonoBehaviour
{
    void FixedUpdate()
    {
        transform.Rotate(0, -1, 0);
    }

    private void OnTriggerEnter(Collider other)
    {

    }
}
