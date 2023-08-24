using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MG1_AIAnimatorControl : MonoBehaviour
{
    Animator ani;

    public static bool isWin = false;
    public static bool isLose = false;

    void Start()
    {
        ani = GetComponent<Animator>();
    }

    void Update()
    {
        if (isWin)
        {
            ani.SetBool("Win", true);
            isWin = false;
        }
        else
        {
            ani.SetBool("Win", false);
        }

        if (isLose)
        {
            ani.SetBool("Lose", true);
            isLose = false;
        }
        else
        {
            ani.SetBool("Lose", false);
        }
    }
}
