using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MG4_AIControl : MonoBehaviour
{
    Rigidbody rb;
    Animator ani;

    float speed = 14;
    float jump = 12;

    public Transform point;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        ani = GetComponent<Animator>();

        ani.SetBool("Run", true);
    }
    void FixedUpdate()
    {
        if (MG4_UIControl.isStart == true)
        {
            rb.AddForce(transform.forward * speed);
        }
        else
        {
            if (MG4_EndControl.move)
            {
                transform.position = point.transform.position;
                if (MG4_EndControl.losePlayer)
                {
                    ani.SetBool("Win", true);
                }
                if (MG4_EndControl.winPlayer)
                {
                    ani.SetBool("Lose", true);
                }
            }
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "RoadBlock")
        {
            rb.velocity = Vector3.up * jump;
            ani.SetBool("Jump", true);
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "RoadBlock")
        {
            ani.SetBool("Jump", false);
        }
    }
}
