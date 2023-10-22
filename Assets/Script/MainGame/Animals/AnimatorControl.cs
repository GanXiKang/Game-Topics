using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimatorControl : MonoBehaviour
{
    Animator anim;

    public static bool isP1Move, isP2Move, isP3Move, isP4Move;
    public static bool isP1Wave, isP2Wave, isP3Wave, isP4Wave;
    public static bool isP1Jump, isP2Jump, isP3Jump, isP4Jump;
    public static bool isP1Win, isP2Win, isP3Win, isP4Win;
    public static bool isP1Lose, isP2Lose, isP3Lose, isP4Lose;
    public static bool isP1Skill, isP2Skill, isP3Skill, isP4Skill;
    public static bool isP1Dizziness, isP2Dizziness, isP3Dizziness, isP4Dizziness;
    public static bool isP1Confusion, isP2Confusion, isP3Confusion, isP4Confusion;

    public static bool isDragonFlyWalk;

    void Start()
    {
        anim = GetComponent<Animator>();
    }
    void Update()
    {
        Move();
        Wave();
        Jump();
        Win();
        Lose();
        Skill();
        Dizziness();
        Confusion();
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
    void Wave()
    {
        if (gameObject.tag == "P1")
        {
            if (isP1Wave)
            {
                anim.SetBool("Wave", true);
            }
            else
            {
                anim.SetBool("Wave", false);
            }
        }
        else if (gameObject.tag == "P2")
        {
            if (isP2Wave)
            {
                anim.SetBool("Wave", true);
            }
            else
            {
                anim.SetBool("Wave", false);
            }
        }
        else if (gameObject.tag == "P3")
        {
            if (isP3Wave)
            {
                anim.SetBool("Wave", true);
            }
            else
            {
                anim.SetBool("Wave", false);
            }
        }
        else if (gameObject.tag == "P4")
        {
            if (isP4Wave)
            {
                anim.SetBool("Wave", true);
            }
            else
            {
                anim.SetBool("Wave", false);
            }
        }
    }
    void Jump()
    {
        if (gameObject.tag == "P1")
        {
            if (isP1Jump)
            {
                anim.SetBool("Jump", true);
            }
            else
            {
                anim.SetBool("Jump", false);
            }
        }
        else if (gameObject.tag == "P2")
        {
            if (isP2Jump)
            {
                anim.SetBool("Jump", true);
            }
            else
            {
                anim.SetBool("Jump", false);
            }
        }
        else if (gameObject.tag == "P3")
        {
            if (isP3Jump)
            {
                anim.SetBool("Jump", true);
            }
            else
            {
                anim.SetBool("Jump", false);
            }
        }
        else if (gameObject.tag == "P4")
        {
            if (isP4Jump)
            {
                anim.SetBool("Jump", true);
            }
            else
            {
                anim.SetBool("Jump", false);
            }
        }
    }
    void Win()
    {
        if (gameObject.tag == "P1")
        {
            if (isP1Win)
            {
                anim.SetBool("Win", true);
            }
            else
            {
                anim.SetBool("Win", false);
            }
        }
        else if (gameObject.tag == "P2")
        {
            if (isP2Win)
            {
                anim.SetBool("Win", true);
            }
            else
            {
                anim.SetBool("Win", false);
            }
        }
        else if (gameObject.tag == "P3")
        {
            if (isP3Win)
            {
                anim.SetBool("Win", true);
            }
            else
            {
                anim.SetBool("Win", false);
            }
        }
        else if (gameObject.tag == "P4")
        {
            if (isP4Win)
            {
                anim.SetBool("Win", true);
            }
            else
            {
                anim.SetBool("Win", false);
            }
        }
    }
    void Lose()
    {
        if (gameObject.tag == "P1")
        {
            if (isP1Lose)
            {
                anim.SetBool("Lose", true);
            }
            else
            {
                anim.SetBool("Lose", false);
            }
        }
        else if (gameObject.tag == "P2")
        {
            if (isP2Lose)
            {
                anim.SetBool("Lose", true);
            }
            else
            {
                anim.SetBool("Lose", false);
            }
        }
        else if (gameObject.tag == "P3")
        {
            if (isP3Lose)
            {
                anim.SetBool("Lose", true);
            }
            else
            {
                anim.SetBool("Lose", false);
            }
        }
        else if (gameObject.tag == "P4")
        {
            if (isP4Lose)
            {
                anim.SetBool("Lose", true);
            }
            else
            {
                anim.SetBool("Lose", false);
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
                switch (Menu_ChoosePlayer.whyP1)
                {
                    case 5:
                        DragonPowerFlyWalk();
                        break;

                    case 7:
                        HorsePowerGO();
                        break;
                }
            }
            else
            {
                anim.SetBool("Skill", false);
                switch (Menu_ChoosePlayer.whyP1)
                {
                    case 2:
                        AnimalsPowerControl.cowUsePower = false;
                        break;

                    case 4:
                        AnimalsPowerControl.rabbitUsePower = false;
                        break;

                    case 7:
                        AnimalsPowerControl.horseUsePower = false;
                        HorsePowerGO();
                        break;
                }
            }
        }
        else if (gameObject.tag == "P2")
        {
            if (isP2Skill)
            {
                anim.SetBool("Skill", true);
                switch (Menu_ChoosePlayer.whyP1)
                {
                    case 5:
                        DragonPowerFlyWalk();
                        break;

                    case 7:
                        HorsePowerGO();
                        break;
                }
            }
            else
            {
                anim.SetBool("Skill", false);
                switch (Menu_ChoosePlayer.whyP2)
                {
                    case 2:
                        AnimalsPowerControl.cowUsePower = false;
                        break;

                    case 4:
                        AnimalsPowerControl.rabbitUsePower = false;
                        break;

                    case 7:
                        AnimalsPowerControl.horseUsePower = false;
                        HorsePowerGO();
                        break;
                }
            }
        }
        else if (gameObject.tag == "P3")
        {
            if (isP3Skill)
            {
                anim.SetBool("Skill", true);
                switch (Menu_ChoosePlayer.whyP1)
                {
                    case 5:
                        DragonPowerFlyWalk();
                        break;

                    case 7:
                        HorsePowerGO();
                        break;
                }
            }
            else
            {
                anim.SetBool("Skill", false);
                switch (Menu_ChoosePlayer.whyP3)
                {
                    case 2:
                        AnimalsPowerControl.cowUsePower = false;
                        break;

                    case 4:
                        AnimalsPowerControl.rabbitUsePower = false;
                        break;

                    case 7:
                        AnimalsPowerControl.horseUsePower = false;
                        HorsePowerGO();
                        break;
                }
            }
        }
        else if (gameObject.tag == "P4")
        {
            if (isP4Skill)
            {
                anim.SetBool("Skill", true);
                switch (Menu_ChoosePlayer.whyP1)
                {
                    case 5:
                        DragonPowerFlyWalk();
                        break;

                    case 7:
                        HorsePowerGO();
                        break;
                }
            }
            else
            {
                anim.SetBool("Skill", false);
                switch (Menu_ChoosePlayer.whyP4)
                {
                    case 2:
                        AnimalsPowerControl.cowUsePower = false;
                        break;

                    case 4:
                        AnimalsPowerControl.rabbitUsePower = false;
                        break;

                    case 7:
                        AnimalsPowerControl.horseUsePower = false;
                        HorsePowerGO();
                        break;
                }
            }
        }
    }
    void DragonPowerFlyWalk()
    {
        if (isDragonFlyWalk)
        {
            anim.SetBool("FlyWalk", true);
        }
        else
        {
            anim.SetBool("FlyWalk", false);
        }
    }
    void HorsePowerGO()
    {
        if (AnimalsPowerControl.horseUsePower)
        {
            anim.SetBool("GO", true);
        }
        else
        {
            anim.SetBool("GO", false);
        }
    }
    void Dizziness()
    {
        if (gameObject.tag == "P1")
        {
            if (isP1Dizziness)
            {
                StartCoroutine(DizzinessAnimator());
            }
        }
        else if (gameObject.tag == "P2")
        {
            if (isP2Dizziness)
            {
                StartCoroutine(DizzinessAnimator());
            }
        }
        else if (gameObject.tag == "P3")
        {
            if (isP3Dizziness)
            {
                StartCoroutine(DizzinessAnimator());
            }
        }
        else if (gameObject.tag == "P4")
        {
            if (isP4Dizziness)
            {
                StartCoroutine(DizzinessAnimator());
            }
        }
    }
    void Confusion()
    {
        if (gameObject.tag == "P1")
        {
            if (isP1Confusion)
            {
                anim.SetBool("Confusion", true);
            }
            else
            {
                anim.SetBool("Confusion", false);
            }
        }
        else if (gameObject.tag == "P2")
        {
            if (isP2Confusion)
            {
                anim.SetBool("Confusion", true);
            }
            else
            {
                anim.SetBool("Confusion", false);
            }
        }
        else if (gameObject.tag == "P3")
        {
            if (isP3Confusion)
            {
                anim.SetBool("Confusion", true);
            }
            else
            {
                anim.SetBool("Confusion", false);
            }
        }
        else if (gameObject.tag == "P4")
        {
            if (isP4Confusion)
            {
                anim.SetBool("Confusion", true);
            }
            else
            {
                anim.SetBool("Confusion", false);
            }
        }
    }

    IEnumerator DizzinessAnimator()
    {
        anim.SetBool("Dizziness", true);
        if (isP1Dizziness)
        {
            isP1Dizziness = false;
        }
        else if (isP2Dizziness)
        {
            isP2Dizziness = false;
        }
        else if (isP3Dizziness)
        {
            isP3Dizziness = false;
        }
        else if (isP4Dizziness)
        {
            isP4Dizziness = false;
        }
        yield return new WaitForSeconds(2f);
        anim.SetBool("Dizziness", false);
    }
}
