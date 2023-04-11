using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MG2_PlayerControl : MonoBehaviour
{
    Rigidbody rb;
    public float speed = 20f;
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        if (MG2_UIControl.gameTime > 0)
        {
            if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow))
            {
                transform.Translate(-speed * Time.deltaTime, 0, 0);
            }
            if (Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow))
            {
                transform.Translate(speed * Time.deltaTime, 0, 0);
            }
        }
    }
}
