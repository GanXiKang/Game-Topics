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
        transform.Translate(speed * Time.deltaTime, 0, 0);

        ani.SetBool("Surf", true);
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "JudgmentBox")
        {
            j++;
        }
    }
}
