using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MG3_AnimalsAnimatorControl : MonoBehaviour
{
    Animator ani;

    public static bool isWin, isLose;

    void Start()
    {
        ani = GetComponent<Animator>();
    }
    void Update()
    {
        if (isWin)
        {
            ani.SetBool("Win", true);
            Invoke("FalseByAnimator", 0.5f);
        }
        if (isLose)
        {
            ani.SetBool("Lose", true);
            Invoke("FalseByAnimator", 0.5f);
        }
    }
    void FalseByAnimator()
    {
        isWin = false;
        isLose = false;
    }
}
