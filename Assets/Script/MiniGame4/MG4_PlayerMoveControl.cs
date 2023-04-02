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
        if (MG4_RoadBlockControl.combo > 2)
        {
            speed += 2;
            print("speed" + speed);
        }
        if (MG4_RoadBlockControl.combo > 4)
        {
            speed += 3;
            print("speed" + speed);
        }
        if (MG4_RoadBlockControl.combo > 7)
        {
            speed += 5;
            print("speed" + speed);
        }
    }
    void FixedUpdate()
    {
        rb.AddForce(transform.forward * speed);
    }
}