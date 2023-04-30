using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MG4_AIControl : MonoBehaviour
{
    Rigidbody rb;
    Animator ani;

    float speed = 14;
    float jump = 12;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        ani = GetComponent<Animator>();
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
            ani.SetBool("Jump", true);
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "RoadBlock")
        {
            ani.SetBool("Jump", false);
        }
    }
}
