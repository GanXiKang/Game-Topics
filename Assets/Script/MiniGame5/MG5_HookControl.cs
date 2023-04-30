using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MG5_HookControl : MonoBehaviour
{
    Animator ani;
    public GameObject fishingLine;
    public static bool isFishing = false;
    public static float score = 0;

    float y, speed = 20;
    bool hookDown, hookUp, takeBack;

    void Start()
    {
        ani.GetComponent<Animator>();
    }
    void Update()
    {
        y = transform.position.y;

        if (MG5_UIControl.gameTime > 0)
        {
            if (Input.GetMouseButton(0))
            {
                hookDown = true;
                isFishing = true;
                ani.SetBool("Throw", true);
            }
            if (Input.GetMouseButtonUp(0))
            {
                hookDown = false;
                ani.SetBool("Throw", false);
            }
            if (Input.GetMouseButton(1))
            {
                hookUp = true;
                ani.SetBool("Receive", true);
            }
            if (Input.GetMouseButtonUp(1))
            {
                hookUp = false;
                ani.SetBool("Receive", false);
            }
        }
    }
    void FixedUpdate()
    {
        if (hookDown == true && takeBack == false)
        {
            if (y > 72)
            {
                transform.Translate(0, 0, speed * Time.deltaTime);
                fishingLine.transform.Translate(0, -10 * Time.deltaTime, 0);
                fishingLine.transform.localScale += new Vector3(0, 0.065f, 0);
            }
        }
        if (hookUp == true && takeBack == false)
        {
            if (y < 155)
            {
                transform.Translate(0, 0, -speed * Time.deltaTime);
                fishingLine.transform.Translate(0, 10 * Time.deltaTime, 0);
                fishingLine.transform.localScale -= new Vector3(0, 0.065f, 0);
            }
        }
        if (takeBack == true)
        {
            if (y < 155)
            {
                transform.Translate(0, 0, -speed * 2 * Time.deltaTime);
                fishingLine.transform.Translate(0, 10 * 2 * Time.deltaTime, 0);
                fishingLine.transform.localScale -= new Vector3(0, 0.065f * 2, 0);
            }
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "SmallFish")
        {
            takeBack = true;
            ani.SetBool("Receive", true);
            score++;
        }
        else if (other.tag == "MidFish")
        {
            takeBack = true;
            ani.SetBool("Receive", true);
            score += 3;
        }
        else if (other.tag == "BigFish")
        {
            takeBack = true;
            ani.SetBool("Receive", true);
            score += 5;
        }
        else if (other.tag == "Rubbish")
        {
            takeBack = true;
            ani.SetBool("Receive", true);
            score -= 3;
        }
    }
    private void OnTriggerStay(Collider other)
    {
        if (other.tag == "Finish")
        {
            takeBack = false;
            isFishing = false;
            ani.SetBool("Receive", false);
        }
    }
}
