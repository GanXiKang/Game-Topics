using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SceneAnimalsAnimationControl : MonoBehaviour
{
    Animation ani;

    bool once = true;
    void Start()
    {
        ani = GetComponent<Animation>();
    }
    void Update()
    {
        if (once)
        {
            
            once = false;
        }
    }
}
