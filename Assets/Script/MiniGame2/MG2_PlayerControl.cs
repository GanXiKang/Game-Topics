using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MG2_PlayerControl : MonoBehaviour
{
    Animator ani;
    float x, speed = 20f;

    void Start()
    {
        ani = GetComponent<Animator>();
    }
    void Update()
    {
        x = transform.position.x;

        if (MG2_StartButtonControl.isStart == true)
        {
            if (MG2_UIControl.gameTime > 0)
            {
                if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow))
                {
                    if (x >= -28)
                    {
                        transform.Translate(speed * Time.deltaTime, 0, 0);
                        ani.SetBool("Walk", true);
                    }
                }
                if (Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow))
                {
                    if (x <= 28)
                    {
                        transform.Translate(-speed * Time.deltaTime, 0, 0);
                        ani.SetBool("Walk", true);
                    }
                }
            }
        }
    }
}
