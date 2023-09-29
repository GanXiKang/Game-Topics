using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MG6_PlayerMoveControl : MonoBehaviour
{
    Animator ani;

    float speed = 45;

    public static int j = 1;
    public static bool dolphinHappy = false;

    void Start()
    {
        ani = GetComponent<Animator>();
        ani.SetBool("Surf", true);
    }
    void FixedUpdate()
    {
        if (MG6_UIControl.isStart)
        {
            transform.Translate(0, 0, speed * Time.deltaTime);

            if (MG6_EndControl.back)
            {
                ani.SetBool("Surf", false);
                ani.SetBool("Win", true);
            }
            if (MG6_BalanceBarControl.gameover)
            {
                ani.SetBool("Surf", false);
                transform.Translate(0, -0.5f, 0);
                transform.Rotate(0, 0, -0.5f);
            }
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "JudgmentBox")
        {
            j++;
            dolphinHappy = true;
            MG6_JudgmentBoxControl.musia = true;
        }
    }
}
