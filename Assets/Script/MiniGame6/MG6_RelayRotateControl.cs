using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MG6_RelayRotateControl : MonoBehaviour
{
    void FixedUpdate()
    {
        transform.Rotate(0, 15, 0);
    }
}
