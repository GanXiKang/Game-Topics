using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimatorControl : MonoBehaviour
{
    Animator anim;

    public static bool isWave;
    public static bool isP1Move, isP2Move, isP3Move, isP4Move;
    public static bool isP1Skill, isP2Skill, isP3Skill, isP4Skill;
    public static bool isP1Dizziness, isP2Dizziness, isP3Dizziness, isP4Dizziness;


    void Start()
    {
        anim = GetComponent<Animator>();
    }
    void Update()
    {
        Wave();
        Move();
        Skill();
        Dizziness();
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
        if (gameObject.tag == "P1")
        {
            if (isP1Move)
            {
                anim.SetBool("Walk", true);
            }
            else
            {
                anim.SetBool("Walk", false);
            }
        }
        else if (gameObject.tag == "P2")
        {
            if (isP2Move)
            {
                anim.SetBool("Walk", true);
            }
            else
            {
                anim.SetBool("Walk", false);
            }
        }
        else if (gameObject.tag == "P3")
        {
            if (isP3Move)
            {
                anim.SetBool("Walk", true);
            }
            else
            {
                anim.SetBool("Walk", false);
            }
        }
        else if (gameObject.tag == "P4")
        {
            if (isP4Move)
            {
                anim.SetBool("Walk", true);
            }
            else
            {
                anim.SetBool("Walk", false);
            }
        }
    }
    void Skill()
    {
        
    }
    void Dizziness()
    {
        
    }
    IEnumerator NotWave()
    {
        anim.SetBool("Wave", true);
        yield return new WaitForSeconds(4f);
        isWave = false;
    }
}
