using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MG5_PlayerMoveControl : MonoBehaviour
{
    Animator ani;
    float x, speed = 20;
    void Start()
    {
        ani = GetComponent<Animator>();
    }
    void Update()
    {
        x = transform.position.x;
        ani.SetBool("Boat", true);

        if (MG5_UIControl.gameTime > 0)
        {
            if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow))
            {
                if (MG5_HookControl.isFishing == false && x >= -66)
                {
                    transform.Translate(speed * Time.deltaTime, 0, 0);
                }
            }
            if (Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow))
            {
                if (MG5_HookControl.isFishing == false && x <= 66)
                {
                    transform.Translate(-speed * Time.deltaTime, 0, 0);
                }
            }
            if (Input.GetMouseButton(0))
            {
                ani.SetBool("Throw", true);
            }
            if (Input.GetMouseButtonUp(0))
            {
                ani.SetBool("Throw", false);
            }
            if (Input.GetMouseButton(1))
            {
                ani.SetBool("Receive", true);
            }
            if (Input.GetMouseButtonUp(1))
            {
                ani.SetBool("Receive", false);
            }

            if (MG5_HookControl.takeBack)
            {
                ani.SetBool("Receive", true);
            }
            else
            {
                ani.SetBool("Receive", false);
            }
        }
        else
        {
            ani.SetBool("Boat", false);
            if (MG5_HookControl.score >= 15)
            {
                ani.SetBool("Win", true);
            }
            else
            {
                ani.SetBool("Lose", true);
            }
            ani.SetBool("Win", false);
            ani.SetBool("Lose", false);
        }
    }
}
