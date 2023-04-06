using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MG5_HookControl : MonoBehaviour
{
    Rigidbody rb;
    float depth, distance, value;
    Vector3 target;
    bool hookDown;

    public static bool math = false;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }
    void Update()
    {
        if (MG5_CameraControl.watchPlayer == false)
        {
            if (math == true)
            {
                depth = 300 * MG5_PowerBarControl.value / 5;
                print("d:" + depth);
                distance = transform.position.y - depth;
                print("D:" + distance);
                target = new Vector3(transform.position.x, distance, transform.position.z);
                print("t:" + target);
                hookDown = true;
                math = false;
            }
        }
    }
    void FixedUpdate()
    {
        if (hookDown == true)
        {
            rb.MovePosition(target);
        }
    }
}
