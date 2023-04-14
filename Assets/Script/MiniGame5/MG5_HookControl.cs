using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MG5_HookControl : MonoBehaviour
{
    Rigidbody rb;
    float speed = 10;
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
            rb.AddForce(Vector3.down * speed * Time.deltaTime);
            //transform.position = new Vector3(transform.position.x, transform.position.y - speed * Time.deltaTime, transform.position.z);
        }
        else 
        {
            //transform.position = new Vector3(transform.position.x, transform.position.y, transform.position.z);
        }
    }
}
