using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MG5_PlayerMoveControl : MonoBehaviour
{
    float x, speed = 15;
    void Update()
    {
        x = transform.position.x;

        if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow))
        {
            transform.Translate(0, -speed * Time.deltaTime, 0);
        }
        if (Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow))
        {
            transform.Translate(0, speed * Time.deltaTime, 0);
        }
    }
}
