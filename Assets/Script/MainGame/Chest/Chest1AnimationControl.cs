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
        if (ChestColliderControl.isOpen1 == true)
        {
            ani.Play("Open");
            ChestColliderControl.isOpen1 = false;
        }
    }
}
