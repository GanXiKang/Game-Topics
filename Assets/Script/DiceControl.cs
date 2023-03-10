using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DiceControl : MonoBehaviour
{
    Rigidbody rb;

    public static Vector3 diceVelocity;
    public static bool isThrow;

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
        if (Input.GetKeyDown("d"))
        {
            isThrow = true;

            float dirX = Random.Range(100, 500);
            float dirY = Random.Range(100, 500);
            float dirZ = Random.Range(100, 500);

            transform.rotation = Quaternion.identity;
            rb.AddForce(transform.up * 400);
            rb.AddTorque(dirX, dirY, dirZ);
        }
    }
}
