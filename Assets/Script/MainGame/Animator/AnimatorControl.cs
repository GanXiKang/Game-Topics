using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimatorControl : MonoBehaviour
{
    Animator anim;

    public static bool isMove, isWave;

    void Start()
    {
        anim = GetComponent<Animator>();
    }
    private void FixedUpdate()
    {
        Wave();

        Move();
    }

    void Wave()
    {
        if (isWave)
        {
            StartCoroutine(NotWave());
        }
        else
        {
            anim.SetBool("Wave", false);
        }
    }
    void Move()
    {
        if (isMove)
        {
            anim.SetBool("Walk", true);
        }
        else
        {
            anim.SetBool("Walk", false);
        }
    }
    IEnumerator NotWave()
    {
        anim.SetBool("Wave", true);
        yield return new WaitForSeconds(4f);
        isWave = false;
    }
}
