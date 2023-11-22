using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tutorial_PerfabControl : MonoBehaviour
{
    Animator anim;
    AudioSource BGM;

    void Start()
    {
        if (gameObject.tag == "Animals")
        {
            anim.GetComponent<Animator>();
            BGM.GetComponent<AudioSource>();
            print("1");
        }
    }

    void FixedUpdate()
    {
        if (gameObject.tag == "Props")
        {
            transform.Rotate(0, 2, 0);
        }
    }

    void Update()
    {
        if (Tutorial_AnimalsControl.isDestory || Tutorial_Props.isDestory)
        {
            Destroy(gameObject);
            Tutorial_AnimalsControl.isDestory = false;
            Tutorial_Props.isDestory = false;
        }

        if (gameObject.tag == "Animals")
        {
            print("2");
            if (Tutorial_AnimalsControl.isAnimator)
            {
                anim.SetBool("Wave", true);
                Tutorial_AnimalsControl.isAnimator = false;
            }
            else
            {
                anim.SetBool("Wave", false);
            }

            if (Tutorial_AnimalsControl.isCall)
            {
                BGM.Play();
                Tutorial_AnimalsControl.isCall = false;
            }
        }
    }
}
