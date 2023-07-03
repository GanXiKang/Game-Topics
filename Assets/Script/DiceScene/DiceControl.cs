using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DiceControl : MonoBehaviour
{
    Rigidbody rb;

    public float rotationForce;

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
            rb.AddTorque(Random.insideUnitSphere * rotationForce);
        }
        else
        {
            rb.angularVelocity = Vector3.zero;
        }
    }
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
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
