using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MG6_DolphinControl : MonoBehaviour
{
    public Animator anim;

    float speed = -45;

    void Update()
    {
        if (MG6_UIControl.isStart && !MG6_EndControl.back)
        {
            transform.Translate(0, 0, speed * Time.deltaTime);
        }

        if (MG6_PlayerMoveControl.dolphinHappy)
        {
            StartCoroutine(DolphinAnimator());
        }
        if (MG6_BalanceBarControl.gameover)
        {
            anim.SetBool("Lose", true);
        }
    }

    IEnumerator DolphinAnimator()
    {
        anim.SetBool("Win", true);
        MG6_PlayerMoveControl.dolphinHappy = false;
        yield return new WaitForSeconds(1f);
        anim.SetBool("Win", false);
    }
}
