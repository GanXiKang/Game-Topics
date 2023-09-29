using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MG6_DolphinControl : MonoBehaviour
{
    Animator anim;

    float speed = 45;

    void Start()
    {
        anim = GetComponent<Animator>();
    }

    void Update()
    {
        if (MG6_UIControl.isStart && !MG6_EndControl.back)
        {
            transform.Translate(0, 0, speed * Time.deltaTime);
        }

        if (MG6_PlayerMoveControl.dolphinHappy)
        {
            anim.SetBool("Win", true);
            MG6_PlayerMoveControl.dolphinHappy = false;
            anim.SetBool("Win", false);
        }
    }
}
