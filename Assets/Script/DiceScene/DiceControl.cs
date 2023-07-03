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
            rb.angularVelocity = Vector3.zero;
        }

        if(Input.GetMouseButtonDown(0))
        {
            print("Yes");
            if (isRoll)
            {
                isRoll = false;
            }
            else 
            {
                isRoll = true;
            }
        }
    }
}
