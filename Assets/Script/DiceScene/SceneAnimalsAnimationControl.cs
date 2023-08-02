using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SceneAnimalsAnimationControl : MonoBehaviour
{
    Animator anim;

    void Start()
    {
        anim = GetComponent<Animator>();
        anim.SetBool("Happy", true);
    }
}
