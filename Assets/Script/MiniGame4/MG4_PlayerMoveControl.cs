using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MG4_PlayerMoveControl : MonoBehaviour
{
    Rigidbody rb;

    float speed = 20;
    float jump = 12;
    bool isFloor;
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }
    void Update()
    {
        if (isFloor == true)
        {
            rb.AddForce(transform.forward);
            if (Input.GetKeyDown(KeyCode.Space))
            {
                transform.Translate(0, 0, speed * Time.deltaTime);
                rb.velocity = Vector3.up * jump;
            }
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Floor")
        {
            isFloor = true;
        }
        if (other.tag == "End")
        {
            isFloor = false;
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "Floor")
        {
            isFloor = false;
        }
    }
}
