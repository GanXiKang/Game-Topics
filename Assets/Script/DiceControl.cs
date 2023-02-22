using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DiceControl : MonoBehaviour
{
    Rigidbody rb;
    public static Vector3 diceVelocity;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }
    void FixedUpdate()
    {
        diceVelocity = rb.velocity;

        RollTheDice();
    }
    void RollTheDice()
    {
        if (Input.GetKeyDown("space"))
        {
            float dirX = Random.Range(0, 1000);
            float dirY = Random.Range(0, 1000);
            float dirZ = Random.Range(0, 1000);

            transform.rotation = Quaternion.identity;
            rb.AddForce(transform.up * 1000);
            rb.AddTorque(dirX, dirY, dirZ);
        }
    }
}
