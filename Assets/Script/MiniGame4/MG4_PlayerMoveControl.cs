using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MG4_PlayerMoveControl : MonoBehaviour
{
    Rigidbody rb;

    float speed = 10 , jump =12;
    bool isJump;
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }
    void Update()
    {
        if (MG4_UIControl.isStart == true)
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                if (isJump == true)
                {
                    rb.velocity = Vector3.up * jump;
                    isJump = false;
                }
            }
        }
    }
    void FixedUpdate()
    {
        if (MG4_UIControl.isStart == true)
        {
            rb.AddForce(transform.forward * speed);

            ComboSpeed();
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Floor")
        {
            isJump = true;
        }
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