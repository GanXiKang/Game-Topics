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
        if (MG2_StartButtonControl.isStart == true)
        {
            if (MG2_UIControl.gameTime > 0)
            {
                float h = Input.GetAxis("Horizontal");
                Vector3 movement = new Vector3(h, 0, 0) * speed * Time.deltaTime;
                transform.position += movement;
            }
        }
    }
}
