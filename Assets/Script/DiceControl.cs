using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DiceControl : MonoBehaviour
{
    static Rigidbody rb;
    public static Vector3 diceVelocity;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }
    void Update()
    {
        diceVelocity = rb.velocity;

        if (Input.GetKeyDown("space"))
        {
            float dirX = Random.Range(500, 1000);
            float dirY = Random.Range(500, 1000);
            float dirZ = Random.Range(500, 1000);
            
            transform.rotation = Quaternion.identity;
            rb.AddForce(transform.up * 1000);
            rb.AddTorque(dirX, dirY, dirZ);
        }
    }
}
