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
            isWin = false;
        }
        else 
        {
            anim.SetBool("Win", false);
        }

        if (isLose)
        {
            anim.SetBool("Lose", true);
            isLose = false;
        }
        else
        {
            anim.SetBool("Lose", false);
        }

        if (isBye)
        {
            anim.SetBool("Bye", true);
            isBye = false;
        }
        else
        {
            anim.SetBool("Bye", false);
        }
    }
}
