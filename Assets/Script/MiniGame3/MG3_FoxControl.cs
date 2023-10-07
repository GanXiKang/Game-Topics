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
            Invoke("FalseByisGuessCup", 1f);
        }
        else 
        {
            anim.SetBool("Win", false);
        }

        if (isLose)
        {
            anim.SetBool("Lose", true);
            Invoke("FalseByisGuessCup", 1f);
        }
        else
        {
            anim.SetBool("Lose", false);
        }

        if (isBye)
        {
            anim.SetBool("Bye", true);
            Invoke("FalseByisBye", 5f);
        }
        else
        {
            anim.SetBool("Bye", false);
        }
    }
    void FalseByisGuessCup()
    {
        isWin = false;
        isLose = false;
    }
    void FalseByisBye()
    {
        isBye = false;
    }
}
