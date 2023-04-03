using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MG4_AIControl : MonoBehaviour
{
    Rigidbody rb;

    float speed = 15;
    float jump = 10;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }
    void FixedUpdate()
    {
        rb.AddForce(transform.forward * speed);
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "RoadBlock")
        {
            rb.velocity = Vector3.up * jump;
        }
    }
}
