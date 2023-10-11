using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FishAnimatorControl : MonoBehaviour
{
    Animator anim;

    void Start()
    {
        anim = GetComponent<Animator>();
        anim.SetBool("Jump", true);
        Invoke("FalseByAnimator", 1f);
    }

    void FalseByAnimator()
    {
        anim.SetBool("Jump", false);
    }
}
