using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MG5_HookControl : MonoBehaviour
{
    Rigidbody rb;
    Vector3 originalLocation;

    float speed = 20, y;
    bool hookDown, hookUp;

    void Start()
    { 
        rb = GetComponent<Rigidbody>();
        originalLocation = transform.position;
    }
    void Update()
    {
        y = transform.position.y;

        if (Input.GetMouseButton(0))
        {
            hookDown = true;
        }
        if (Input.GetMouseButtonUp(0))
        {
            hookDown = false;
        }
        if (Input.GetMouseButton(1))
        {
            hookUp = true;
        }
        if (Input.GetMouseButtonUp(1))
        {
            hookUp = false;
        }
    }
    void FixedUpdate()
    {
        if (hookDown == true)
        {
            if (y > 72)
            {
                transform.position = new Vector3(transform.position.x, y - speed * Time.deltaTime, transform.position.z);
            }
        }
        if (hookUp == true)
        {
            if (y < 155)
            {
                transform.position = new Vector3(transform.position.x, y + speed * Time.deltaTime, transform.position.z);
            }
        }
    }
}
