using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MG3_FoxControl : MonoBehaviour
{
    Animator anim;

    public static bool isWin, isLose, isBye;

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

        if (isBye)
        {
            anim.SetBool("Bye", true);
            Invoke("FalseByAnimator", 0.5f);
        }
    }

    void FalseByAnimator()
    {
        isWin = false;
        isLose = false;
        isBye = false;
    }
}
