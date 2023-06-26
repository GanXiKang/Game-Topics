using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndAnimalsAnimatorControl : MonoBehaviour
{
    Animator anim;
    void Start()
    {
        anim = GetComponent<Animator>();
    }
    void Update()
    {
        if (gameObject.tag == "P1")
        {
            if (GameEndControl.whoWin == 1)
            {
                Win();
            }
            else 
            {
                Lose();
            }
        }
        if (gameObject.tag == "P2")
        {
            if (GameEndControl.whoWin == 2)
            {
                Win();
            }
            else
            {
                Lose();
            }
        }
        if (gameObject.tag == "P3")
        {
            if (GameEndControl.whoWin == 3)
            {
                Win();
            }
            else
            {
                Lose();
            }
        }
        if (gameObject.tag == "P4")
        {
            if (GameEndControl.whoWin == 4)
            {
                Win();
            }
            else
            {
                Lose();
            }
        }
    }
    void Win()
    {
        anim.SetBool("Win", true);
    }
    void Lose()
    {
        anim.SetBool("Lose", true);
    }
}
