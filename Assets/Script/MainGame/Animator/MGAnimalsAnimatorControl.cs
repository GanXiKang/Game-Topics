using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MGAnimalsAnimatorControl : MonoBehaviour
{
    Animator ani;

    public static bool isWave = false;
    public static bool isBye = false;

    void Start()
    {
        ani = GetComponent<Animator>();
    }

    void Update()
    {
        if (isWave)
        {
            ani.SetBool("Wave", true);
            isWave = false;
        }
        else
        {
            ani.SetBool("Wave", false);
        }

        if (isBye)
        {
            ani.SetBool("Bye", true);
            isBye = false;
        }
        else
        {
            ani.SetBool("Bye", false);
        }
    }
}
