using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MG5_PlayerMoveControl : MonoBehaviour
{
    float x, speed = 20;
    void Update()
    {
        x = transform.position.x;

        if (MG5_UIControl.gameTime > 0)
        {
            if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow))
            {
                if (MG5_HookControl.isFishing == false && x >= -66)
                {
                    transform.Translate(-speed * Time.deltaTime, 0, 0);
                }
            }
            if (Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow))
            {
                if (MG5_HookControl.isFishing == false && x <= 66)
                {
                    transform.Translate(speed * Time.deltaTime, 0, 0);
                }
            }
        }
    }
}
