using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MG5_HookControl : MonoBehaviour
{
    public Transform hookInSitu;
    float depth;

    void Update()
    {
        if (MG5_CameraControl.watchPlayer == false)
        {
            depth = 300 * MG5_PowerBarControl.value / 5;
            print(depth);
        }
    }
}
