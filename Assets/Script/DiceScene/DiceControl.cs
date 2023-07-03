using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DiceControl : MonoBehaviour
{
    Rigidbody rb;

    public float rotationForce;
    public Vector3 rotationForce3;

    int randomNum;
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
            //rb.AddTorque(Random.insideUnitSphere * rotationForce);
            rb.AddTorque(rotationForce3);
        }
        else
        {
            DiceRandomDice();
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
    void DiceRandomDice()
    {
        rb.angularVelocity = Vector3.zero;
        randomNum = Random.Range(1, 7);
        switch (randomNum)
        {
            case 1:
                transform.rotation = Quaternion.Euler(0f, 270f, 0f);
                break;
            case 2:
                transform.rotation = Quaternion.Euler(0f, 180f, 0f);
                break;
            case 3:
                transform.rotation = Quaternion.Euler(90f, 0f, 0f);
                break;
            case 4:
                transform.rotation = Quaternion.Euler(0f, 0f, 0f);
                break;
            case 5:
                transform.rotation = Quaternion.Euler(270f, 0f, 0f);
                break;
            case 6:
                transform.rotation = Quaternion.Euler(0f, 90f, 0f);
                break;

        }
    }
}
