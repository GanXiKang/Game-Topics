using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MG6_PlayerMoveControl : MonoBehaviour
{
    Animator ani;
    Rigidbody rb;
    float speed = 25;

    public static int j = 1;

    void Start()
    {
        ani = GetComponent<Animator>();
        rb = GetComponent<Rigidbody>();
    }
    void FixedUpdate()
    {
        rb.AddForce(transform.forward * speed);

        if (MG6_EndControl.back)
        {
            ani.SetBool("Surf", false);
            ani.SetBool("Win", true);
        }
        else 
        {
            ani.SetBool("Surf", true);
        }

    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "JudgmentBox")
        {
            j++;
        }
    }
}
