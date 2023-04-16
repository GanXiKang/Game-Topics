using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MG4_AIControl : MonoBehaviour
{
    Rigidbody rb;

    float speed = 14;
    float jump = 10;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }
    void FixedUpdate()
    {
        if (MG4_UIControl.isStart == true)
        {
            rb.AddForce(transform.forward * speed);
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "RoadBlock")
        {
            rb.velocity = Vector3.up * jump;
        }
    }
}
