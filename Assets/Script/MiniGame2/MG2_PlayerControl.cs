using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MG2_PlayerControl : MonoBehaviour
{
    float x, speed = 20f;

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
                        transform.position -= new Vector3(speed * Time.deltaTime, 0, 0);
                    }
                }
                if (Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow))
                {
                    if (x <= 28)
                    {
                        transform.Translate(speed * Time.deltaTime, 0, 0);
                    }
                }
            }
        }
    }
}
