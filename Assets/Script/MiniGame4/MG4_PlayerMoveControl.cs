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
        if (MG4_UIControl.isStart == true)
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                if (isJump == true)
                {
                    //rb.velocity = Vector3.up * jump;
                    transform.Translate(0, jump * Time.deltaTime, 0);
                    ani.SetBool("Hurldes", true);
                    isJump = false;
                }
            }
        }
    }
    void FixedUpdate()
    {
        if (MG4_UIControl.isStart == true)
        {
            //rb.AddForce(transform.forward * speed);
            transform.Translate(0, 0, speed * Time.deltaTime);
            ani.SetBool("Walk", true);
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