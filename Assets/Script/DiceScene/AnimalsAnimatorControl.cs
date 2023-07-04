using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimalsAnimatorControl : MonoBehaviour
{
    Rigidbody rb;
    Animator anim;

    public static bool isJump;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        anim = GetComponent<Animator>();
    }
    void Update()
    {
        if (isJump)
        {
            rb.AddForce(Vector3.up * 5, ForceMode.Impulse);
            anim.SetBool("Jump", true);
            isJump = false;
        }
        else
        {
            anim.SetBool("Jump", false);
        }
    }
}
