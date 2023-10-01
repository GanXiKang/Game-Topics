using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MG2_SlothControl : MonoBehaviour
{
    Animator anim;

    public static bool isWin, isLose;

    void Start()
    {
        anim = GetComponent<Animator>();
        isWin = false;
        isLose = false;
    }

    void Update()
    {
        if (isWin)
        {
            anim.SetBool("Win", true);
        }
        if (isLose)
        {
            anim.SetBool("Lose", true);
        }
    }
}
