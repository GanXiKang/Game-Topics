using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MG2_SlothControl : MonoBehaviour
{
    Animator anim;

    void Start()
    {
        anim = GetComponent<Animator>();
    }

    void Update()
    {
        if (MG2_GameResultControl.win)
        {
            anim.SetBool("Win", true);
        }
        if (MG2_GameResultControl.lose)
        {
            anim.SetBool("Lose", true);
        }
    }
}
