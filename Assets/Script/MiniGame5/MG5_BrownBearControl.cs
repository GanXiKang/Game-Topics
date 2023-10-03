using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MG5_BrownBearControl : MonoBehaviour
{
    Animator anim;

    public static bool isWin, isLose;

    void Start()
    {
        anim = GetComponent<Animator>();
    }

    void Update()
    {
        if (isWin)
        {
            anim.SetBool("Win", true);
            Invoke("FalseByAnimator", 0.5f);
        }

        if (isLose)
        {
            anim.SetBool("Lose", true);
            Invoke("FalseByAnimator", 0.5f);
        }
    }

    void FalseByAnimator()
    {
        isWin = false;
        isLose = false;
    }
}
