using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SceneAnimalsAnimationControl : MonoBehaviour
{
    Animation ani;
    
    void Start()
    {
        ani = GetComponent<Animation>();

        ani.Play("Squirrel_Happy");
    }
}
