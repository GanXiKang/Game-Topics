using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MG6_PlayerMoveControl : MonoBehaviour
{
    Animator ani;
    Rigidbody rb;
    float speed = 5;

    public static bool isMove = true;
    public static int j = 1;

    void Start()
    {
        ani = GetComponent<Animator>();
        rb = GetComponent<Rigidbody>();
    }
    void FixedUpdate()
    {
        ani.SetBool("Surf", true);
        if (isMove == true)
        {
            rb.AddForce(transform.forward * speed);
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
