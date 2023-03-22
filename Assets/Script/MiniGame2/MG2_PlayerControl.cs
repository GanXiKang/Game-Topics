using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MG2_PlayerControl : MonoBehaviour
{
    Rigidbody rb;
    public float speed = 100f;
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        if (MG2_UIControl.gameTime > 0)
        {
            float h = Input.GetAxis("Horizontal");

            Vector3 push = new Vector3(h, 0, 0) * speed;
            rb.AddForce(push * Time.deltaTime);
        }
    }
}
