using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Chest2AnimationControl : MonoBehaviour
{
    Animation ani;

    void Start()
    {
        ani = GetComponent<Animation>();
    }
    void Update()
    {
        if (ChestColliderControl.isOpen2 == true)
        {
            ani.Play("Open");
            ChestColliderControl.isOpen2 = false;
        }
    }
}
