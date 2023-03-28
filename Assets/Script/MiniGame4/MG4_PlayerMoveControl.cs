using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MG4_PlayerMoveControl : MonoBehaviour
{
    Rigidbody rb;

    public float speed = 60;
    public float jump = 10;
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }
    void Update()
    {
        transform.Translate(0, 0, speed * Time.deltaTime);
        if (Input.GetKeyDown("w"))
        {
            rb.velocity = Vector3.up * jump;
        }
    }
}
