using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Menu_AnimalsTagControl : MonoBehaviour
{
    Animator anim;
    void Start()
    {
        anim = GetComponent<Animator>();

        StartCoroutine(AnimatorControl());
    }
    void Update()
    {
        
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
    IEnumerator AnimatorControl()
    {
        anim.SetBool("Wave", true);
        yield return new WaitForSeconds(2f);
        anim.SetBool("Wave", false);
    }
}
