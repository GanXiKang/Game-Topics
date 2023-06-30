using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Menu_AnimalsTagControl : MonoBehaviour
{
    Rigidbody rb;
    Animator anim;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        anim = GetComponent<Animator>();

        StartCoroutine(AnimatorWaveControl());
    }
    void Update()
    {
        if (gameObject.tag == "P1")
        {
            if (Menu_ChoosePlayer.isDestoryP1)
            {
                //Destroy(this.gameObject);
                Menu_ChoosePlayer.isDestoryP1 = false;
            }
            else if(Menu_ChoosePlayer.isOkP1)
            {
                Menu_ChoosePlayer.isOkP1 = false;
                StartCoroutine(AnimatorJumpControl());
            }
        }
        else if (gameObject.tag == "P2")
        {
            if (Menu_ChoosePlayer.isDestoryP2)
            {
                Destroy(this.gameObject);
                Menu_ChoosePlayer.isDestoryP2 = false;
            }
            else if (Menu_ChoosePlayer.isOkP2)
            {
                Menu_ChoosePlayer.isOkP2 = false;
                StartCoroutine(AnimatorJumpControl());
            }
        }
        else if (gameObject.tag == "P3")
        {
            if (Menu_ChoosePlayer.isDestoryP3)
            {
                Destroy(this.gameObject);
                Menu_ChoosePlayer.isDestoryP3 = false;
            }
            else if (Menu_ChoosePlayer.isOkP3)
            {
                Menu_ChoosePlayer.isOkP3 = false;
                StartCoroutine(AnimatorJumpControl());
            }
        }
        else if (gameObject.tag == "P4")
        {
            if (Menu_ChoosePlayer.isDestoryP4)
            {
                Destroy(this.gameObject);
                Menu_ChoosePlayer.isDestoryP4 = false;
            }
            else if (Menu_ChoosePlayer.isOkP4)
            {
                Menu_ChoosePlayer.isOkP4 = false;
                StartCoroutine(AnimatorJumpControl());
            }
        }
    }
    void Jump()
    {
        rb.AddForce(Vector3.up * 5, ForceMode.Impulse);
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "P1InsPoint")
        {
            gameObject.tag = "P1";
        }
        if (other.tag == "P2InsPoint")
        {
            gameObject.tag = "P2";
        }
        if (other.tag == "P3InsPoint")
        {
            gameObject.tag = "P3";
        }
        if (other.tag == "P4InsPoint")
        {
            gameObject.tag = "P4";
        }
    }
    IEnumerator AnimatorWaveControl()
    {
        anim.SetBool("Wave", true);
        yield return new WaitForSeconds(1f);
        anim.SetBool("Wave", false);
    }
    IEnumerator AnimatorJumpControl()
    {
        Jump();
        anim.SetBool("Jump", true);
        yield return new WaitForSeconds(1f);
        anim.SetBool("Jump", false);
    }
}
