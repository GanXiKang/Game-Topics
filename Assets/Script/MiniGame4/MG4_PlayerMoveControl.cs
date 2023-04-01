using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MG4_PlayerMoveControl : MonoBehaviour
{
    Rigidbody rb;
    float jump = 12;
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }
    void FixedUpdate()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            rb.velocity = Vector3.up * jump;
        }
        else
        {
            rb.AddForce(transform.forward); 
        }
    }
}