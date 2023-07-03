using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DiceControl : MonoBehaviour
{
    Rigidbody rb;

    public float rotationForce;
    public Vector3 rotationForce3;

    Quaternion stopQ;
    Quaternion[] q = new Quaternion[7];

    int randomNum;
    bool isRoll, result;
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
            result = true;
        }
        else
        {
            if (result)
            {
                DiceRandomDice();
            }
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
        result = false;
        stopQ = transform.rotation;
        rb.angularVelocity = Vector3.zero;
        randomNum = Random.Range(1, 7);
        print(randomNum);
        switch (randomNum)
        {
            case 1:
                transform.rotation = Quaternion.Slerp(stopQ, q[1], 5f);
                //transform.rotation = Quaternion.Euler(0f, 270f, 0f);
                break;
            case 2:
                transform.rotation = Quaternion.Slerp(stopQ, q[2], 5f);
                //transform.rotation = Quaternion.Euler(0f, 180f, 0f);
                break;
            case 3:
                transform.rotation = Quaternion.Slerp(stopQ, q[3], 5f);
                //transform.rotation = Quaternion.Euler(90f, 0f, 0f);
                break;
            case 4:
                transform.rotation = Quaternion.Slerp(stopQ, q[4], 5f);
                //transform.rotation = Quaternion.Euler(270f, 0f, 0f);
                break;
            case 5:
                transform.rotation = Quaternion.Slerp(stopQ, q[5], 5f);
                //transform.rotation = Quaternion.Euler(0f, 0f, 0f);
                break;
            case 6:
                transform.rotation = Quaternion.Slerp(stopQ, q[6], 5f);
                //transform.rotation = Quaternion.Euler(0f, 90f, 0f);
                break;
        }
    }
    void FindQuaternionEuler()
    {
        q[1] = Quaternion.Euler(0f, 270f, 0f);
        q[2] = Quaternion.Euler(0f, 180f, 0f);
        q[3] = Quaternion.Euler(90f, 0f, 0f);
        q[4] = Quaternion.Euler(270f, 0f, 0f);
        q[5] = Quaternion.Euler(0f, 0f, 0f);
        q[6] = Quaternion.Euler(0f, 90f, 0f);
    }
}
