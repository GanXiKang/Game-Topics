using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MG1_AnimatorControl : MonoBehaviour
{
    Animator ani;
    void Start()
    {
        ani = GetComponent<Animator>();
    }
    void Update()
    {
        if (MG1_GameControl.playerAniWin)
        {
            ani.SetBool("Win", true);
        }
        if (MG1_GameControl.playerAniLose)
        {
            ani.SetBool("Lose", true);
        }
    }
}
