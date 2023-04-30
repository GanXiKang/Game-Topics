using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MG6_PlayerMoveControl : MonoBehaviour
{
    Animator ani;
    float speed = 25;

    public static int j = 1;

    void Start()
    {
        ani = GetComponent<Animator>();
    }
    void FixedUpdate()
    {
        transform.Translate(speed * Time.deltaTime, 0, 0);

        if (MG6_EndControl.back)
        {
            ani.SetBool("Surf", false);
        }
        else 
        {
            ani.SetBool("Surf", true);
        }

    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "JudgmentBox")
        {
            j++;
        }
    }
}
