using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MG5_HookControl : MonoBehaviour
{
    float depth;
    float target;
    Vector3 originalPosition;

    void Start()
    {
        originalPosition = this.transform.position;
    }
    void Update()
    {
        if (MG5_CameraControl.watchPlayer == false)
        {
            depth = 300 * MG5_PowerBarControl.value / 5;
            print(depth);
            target = transform.position.y - depth;
            print(target);
        }
    }
}
