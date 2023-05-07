using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimatorControl : MonoBehaviour
{
    Animator anim;

    void Start()
    {
        anim = GetComponent<Animator>();
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Point")
        {
            anim.SetBool("Walk", false);
            //if (PlayerMoveControl.Award == true)
            //{
            //    StartCoroutine(YesAward());
            //}
            //if (PlayerMoveControl.Award == false)
            //{
            //    StartCoroutine(NoAward());
            //}
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "Point")
        {
            anim.SetBool("Walk", true);
        }
    }
    //IEnumerator YesAward()
    //{
    //    anim.SetBool("Jump", true);
    //    yield return new WaitForSeconds(2f);
    //    anim.SetBool("Walk", false);
    //    anim.SetBool("Jump", false);
    //}
    //IEnumerator NoAward()
    //{
    //    anim.SetBool("Wave", true);
    //    yield return new WaitForSeconds(2f);
    //    anim.SetBool("Walk", false);
    //    anim.SetBool("Wave", false);
    //}
}
