using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimalsDontDestoryOnLoadControl : MonoBehaviour
{
    void Start()
    {
        DontDestroyOnLoad(this.gameObject);
    }

    void FixedUpdate()
    {
        if (EndInsPlayerControl.isGameSceneDestroy)
        {
            Destroy(gameObject);
        }
    }
}
