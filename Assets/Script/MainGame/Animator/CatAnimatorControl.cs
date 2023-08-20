using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CatAnimatorControl : MonoBehaviour
{
    Animator ani;

    public static bool isHappy = false;
    public static bool isSad = false;
    public static bool isWave = false;
    public static bool isBye = false;

    void Start()
    {
        ani = GetComponent<Animator>();
    }

    void Update()
    {
        if (isHappy)
        {
            ani.SetBool("Happy", true);
            isHappy = false;
        }
        else 
        {
            ani.SetBool("Happy", false);
        }

        if (isSad)
        {
            ani.SetBool("Sad", true);
            isSad = false;
        }
        else
        {
            ani.SetBool("Sad", false);
        }

        if (isWave)
        {
            ani.SetBool("Wave", true);
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
