using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MG5_HookControl : MonoBehaviour
{
    public GameObject fishingLine;
    public static bool isFishing = false;

    Rigidbody rb;
    float y, speed = 20;
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
            isFishing = true;
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
                transform.Translate(0, -speed * Time.deltaTime, 0);
                fishingLine.transform.Translate(0, -10 * Time.deltaTime, 0);
                fishingLine.transform.localScale += new Vector3(0, 0.04f, 0);
            }
        }
        if (hookUp == true)
        {
            if (y < 155)
            {
                transform.Translate(0, speed * Time.deltaTime, 0);
                fishingLine.transform.Translate(0, 10 * Time.deltaTime, 0);
                fishingLine.transform.localScale -= new Vector3(0, 0.04f, 0);
            }
        }
        if (takeBack == true)
        {
            if (y < 155)
            {
                transform.Translate(0, speed * 2 * Time.deltaTime, 0);
                fishingLine.transform.Translate(0, 10 * 2 * Time.deltaTime, 0);
                fishingLine.transform.localScale -= new Vector3(0, 0.04f * 2, 0);
            }
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "SmallFish" || other.tag == "MidFish" || other.tag == "BigFish" || other.tag == "Rubbish")
        {
            takeBack = true;
        }
    }
    private void OnTriggerStay(Collider other)
    {
        if (other.tag == "Finish")
        {
            takeBack = false;
            isFishing = false;
        }
    }
}
