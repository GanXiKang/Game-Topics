using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Chest1AnimationControl : MonoBehaviour
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
    }
}
