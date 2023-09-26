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
        if (gameObject.tag == "P1")
        {
            if (isP1Skill)
            {
                anim.SetBool("Skill", true);
            }
            else
            {
                anim.SetBool("Skill", false);
            }
        }
        else if (gameObject.tag == "P2")
        {
            if (isP2Skill)
            {
                anim.SetBool("Skill", true);
            }
            else
            {
                anim.SetBool("Skill", false);
            }
        }
        else if (gameObject.tag == "P3")
        {
            if (isP3Skill)
            {
                anim.SetBool("Skill", true);
            }
            else
            {
                anim.SetBool("Skill", false);
            }
        }
        else if (gameObject.tag == "P4")
        {
            if (isP4Skill)
            {
                anim.SetBool("Skill", true);
            }
            else
            {
                anim.SetBool("Skill", false);
            }
        }
    }
    void Dizziness()
    {
        if (gameObject.tag == "P1")
        {
            if (isP1Dizziness)
            {
                anim.SetBool("Dizziness", true);
                isP1Dizziness = false;
            }
            else
            {
                anim.SetBool("Dizziness", false);
            }
        }
        else if (gameObject.tag == "P2")
        {
            if (isP2Dizziness)
            {
                anim.SetBool("Dizziness", true);
                isP2Dizziness = false;
            }
            else
            {
                anim.SetBool("Dizziness", false);
            }
        }
        else if (gameObject.tag == "P3")
        {
            if (isP3Dizziness)
            {
                anim.SetBool("Dizziness", true);
                isP3Dizziness = false;
            }
            else
            {
                anim.SetBool("Dizziness", false);
            }
        }
        else if (gameObject.tag == "P4")
        {
            if (isP4Dizziness)
            {
                anim.SetBool("Dizziness", true);
                isP4Dizziness = false;
            }
            else
            {
                anim.SetBool("Dizziness", false);
            }
        }
    }
    IEnumerator NotWave()
    {
        anim.SetBool("Wave", true);
        yield return new WaitForSeconds(4f);
        isWave = false;
    }
}
