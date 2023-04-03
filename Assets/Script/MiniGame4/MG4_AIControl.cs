using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MG4_AIControl : MonoBehaviour
{
    Rigidbody rb;

    float speed = 18;
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }
    void FixedUpdate()
    {
        rb.AddForce(transform.forward * speed);
    }
}
