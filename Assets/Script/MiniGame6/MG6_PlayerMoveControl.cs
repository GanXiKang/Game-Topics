using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MG6_PlayerMoveControl : MonoBehaviour
{
    Animator ani;

    float speed = 35;

    public static int j = 1;

    void Start()
    {
        ani = GetComponent<Animator>();
        ani.SetBool("Surf", true);
    }
    void FixedUpdate()
    {
        if (MG6_UIControl.isStart)
        {
            transform.Translate(speed * Time.deltaTime, 0, 0);

            if (MG6_EndControl.back)
            {
                ani.SetBool("Surf", false);
                ani.SetBool("Win", true);
            }
            if (MG6_BalanceBarControl.gameover)
            {
                ani.SetBool("Surf", false);
                transform.position += new Vector3(0, 0.5f * Time.deltaTime, 0);
            }
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "JudgmentBox")
        {
            j++;
            MG6_JudgmentBoxControl.musia = true;
        }
    }
}
