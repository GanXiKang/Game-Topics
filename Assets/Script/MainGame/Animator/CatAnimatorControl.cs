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
            StartCoroutine(Timing());
        }
        else 
        {
            ani.SetBool("Happy", false);
        }

        if (isSad)
        {
            ani.SetBool("Sad", true);
            StartCoroutine(Timing());
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
            StartCoroutine(Timing());
        }
        else
        {
            ani.SetBool("Bye", false);
        }
    }
    IEnumerator Timing()
    {
        yield return new WaitForSeconds(0.5f);
        isHappy = false;
        isSad = false;
        isBye = false;
    }
}
