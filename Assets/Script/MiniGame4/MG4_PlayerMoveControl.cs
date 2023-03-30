using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MG4_PlayerMoveControl : MonoBehaviour
{
    Rigidbody rb;

    float speed = 5;
    float jump = 12;
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }
    void Update()
    {
        rb.AddForce(speed * transform.forward);
        if (Input.GetKeyDown("w"))
        {
            rb.velocity = Vector3.up * jump;
        }
    }
}
