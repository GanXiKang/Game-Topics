using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimatorControl : MonoBehaviour
{
    Animator anim;

    void Start()
    {
        anim = GetComponent<Animator>();
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Point")
        {
            anim.SetBool("Walk", false);
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "Point")
        {
            anim.SetBool("Walk", true);
        }
    }
}
