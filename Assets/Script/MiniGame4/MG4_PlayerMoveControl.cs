using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MG4_PlayerMoveControl : MonoBehaviour
{
    Rigidbody rb;
    float speed = 10;
    float jump = 12;
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }
    void FixedUpdate()
    {
        rb.AddForce(transform.forward * 20);
    }
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            rb.velocity = Vector3.up * jump;
        }
    }

}