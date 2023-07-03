using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DiceControl : MonoBehaviour
{
    Rigidbody rb;

    public Vector3 rotationForce;

    bool isRoll;
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        isRoll = true;
    }
    void FixedUpdate()
    {
        if (isRoll)
        {
            rb.AddTorque(rotationForce);
        }
        else
        {
            
        }

        if(Input.GetMouseButtonDown(0))
        {
            isRoll = false;
        }
    }
}
