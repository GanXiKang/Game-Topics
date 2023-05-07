using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimatorControl : MonoBehaviour
{
    Animator anim;

    public static bool isMove, isWave;

    void Start()
    {
        anim = GetComponent<Animator>();
    }
    private void FixedUpdate()
    {
        if (isWave)
        {
            anim.SetBool("Wave", true);
        }
        else
        {
            anim.SetBool("Wave", false);
        }

        if (isMove)
        {
            anim.SetBool("Walk", true);
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Point")
        {
            anim.SetBool("Walk", false);
            isMove = false;
        }
    }
}
