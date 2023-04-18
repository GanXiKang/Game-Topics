using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MG5_HookControl : MonoBehaviour
{
    Rigidbody rb;
    GameObject fishingLine;

    float speed = 20, y;
    bool hookDown, hookUp, takeBack;

    void Start()
    { 
        rb = GetComponent<Rigidbody>();
    }
    void Update()
    {
        y = transform.position.y;

        if (Input.GetMouseButton(0))
        {
            hookDown = true;
        }
        if (Input.GetMouseButtonUp(0))
        {
            hookDown = false;
        }
        if (Input.GetMouseButton(1))
        {
            hookUp = true;
        }
        if (Input.GetMouseButtonUp(1))
        {
            hookUp = false;
        }
    }
    void FixedUpdate()
    {
        if (hookDown == true)
        {
            if (y > 72)
            {
                transform.position = new Vector3(transform.position.x, y - speed * Time.deltaTime, transform.position.z);
            }
        }
        if (hookUp == true)
        {
            if (y < 155)
            {
                transform.position = new Vector3(transform.position.x, y + speed * Time.deltaTime, transform.position.z);
            }
        }
        if (takeBack == true)
        {
            if (y < 155)
            {
                transform.position = new Vector3(transform.position.x, y + speed * 2 * Time.deltaTime, transform.position.z);
            }
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "SmallFish" || other.tag == "MidFish" || other.tag == "BigFish" || other.tag == "Rubbish")
        {
            takeBack = true;
        }
        if (other.tag == "Finish")
        {
            takeBack = false;
        }
    }
}
