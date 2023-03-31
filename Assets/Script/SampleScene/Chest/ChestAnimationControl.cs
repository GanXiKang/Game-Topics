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
        if (ChestColliderControl.isOpen == 1)
        {
            ani.Play("Open");
            ChestColliderControl.isOpen = 0;
        }
        if (ChestColliderControl.isOpen == 2)
        {
            ani.Play("Open");
            ChestColliderControl.isOpen = 0;
        }
    }
}
