using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MG5_HookControl : MonoBehaviour
{
    Rigidbody rb;
    float speed = 100;
    bool hookDown;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }
    void Update()
    {
        if (Input.GetKey(KeyCode.P))
        {
            hookDown = true;
        }
        else 
        {
            hookDown = false;
        }
    }
    void FixedUpdate()
    {
        if (hookDown == true)
        {
            print("yes");
            rb.AddForce(Vector3.down * speed * Time.deltaTime);
        }
        if (hookDown == false)
        {
            print("NO");
            rb.AddForce(Vector3.zero);
        }
    }
}
