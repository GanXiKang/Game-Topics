using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MG4_PlayerMoveControl : MonoBehaviour
{
    Animator ani;
    Rigidbody rb;

    float speed = 10 , jump =12;
    bool isJump;
    void Start()
    {
        ani = GetComponent<Animator>();
        rb = GetComponent<Rigidbody>();
    }
    void Update()
    {
        if (MG4_UIControl.isStart)
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                if (isJump)
                {
                    ani.SetBool("Hurldes", true);
                    rb.velocity = Vector3.up * jump;
                    isJump = false;
                }
            }
        }
    }
    void FixedUpdate()
    {
        if (MG4_UIControl.isStart)
        {
            rb.AddForce(transform.forward * speed);
            ani.SetBool("Run", true);
            ComboSpeed();
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Floor")
        {
            isJump = true;
            ani.SetBool("Hurldes", false);
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