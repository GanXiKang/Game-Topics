using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MG6_PlayerMoveControl : MonoBehaviour
{
    Rigidbody rb;
    float speed = 5;

    public static bool isMove = true;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }
    void FixedUpdate()
    {
        if (isMove == true)
        {
            rb.AddForce(transform.forward * speed);
        }
    }
}
