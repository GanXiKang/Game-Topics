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
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            rb.velocity = Vector3.up * jump;
        }
    }
    void FixedUpdate()
    {
        rb.AddForce(transform.forward * speed);

        ComboSpeed();
    }
    void ComboSpeed()
    {
        if (MG4_RoadBlockControl.combo < 3)
        {
            speed = 10;
        }
        if (MG4_RoadBlockControl.combo >= 3 && MG4_RoadBlockControl.combo < 5)
        {
            speed = 15;
        }
        if (MG4_RoadBlockControl.combo >= 5 && MG4_RoadBlockControl.combo < 8)
        {
            speed = 18;
        }
        if (MG4_RoadBlockControl.combo >= 8)
        {
            speed = 20;
        }
    }
}