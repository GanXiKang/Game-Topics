using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChestAnimationControl : MonoBehaviour
{
    Animation ani;

    void Start()
    {
        ani = GetComponent<Animation>();
    }
    void Update()
    {
        if (ChestColliderControl.isOpen == true)
        {
            ani.Play("Open");
        }
    }
}
