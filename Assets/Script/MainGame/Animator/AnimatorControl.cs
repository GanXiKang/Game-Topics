using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimatorControl : MonoBehaviour
{
    Animator anim;

    public static bool isP1Move, isP2Move, isP3Move, isP4Move, isWave;

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
        if (isP1Move)
        {
            if (gameObject.tag == "P1")
            {
                anim.SetBool("Walk", true);
            }
        }
        else
        {
            anim.SetBool("Walk", false);
        }

        if (isP2Move)
        {
            if (gameObject.tag == "P2")
            {
                anim.SetBool("Walk", true);
            }
        }
        else
        {
            anim.SetBool("Walk", false);
        }

        if (isP3Move)
        {
            if (gameObject.tag == "P3")
            {
                anim.SetBool("Walk", true);
            }
        }
        else
        {
            anim.SetBool("Walk", false);
        }

        if (isP4Move)
        {
            if (gameObject.tag == "P4")
            {
                anim.SetBool("Walk", true);
            }
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
