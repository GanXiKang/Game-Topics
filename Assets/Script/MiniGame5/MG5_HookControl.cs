using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MG5_HookControl : MonoBehaviour
{
    Rigidbody rb;
    float speed = 20, y;
    bool hookDown;

    void Start()
    { 
        rb = GetComponent<Rigidbody>();
    }
    void Update()
    {
        y = transform.position.y;
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
            if (y >= 72)
            {
                transform.position = new Vector3(transform.position.x, y - speed * Time.deltaTime, transform.position.z);
            }
        }
    }
}
