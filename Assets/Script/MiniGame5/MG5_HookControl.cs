using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MG5_HookControl : MonoBehaviour
{
    Rigidbody rb;
    float depth, distance,speed = 10;
    Vector3 originalPosition, target;

    public static bool math = false;
    
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        originalPosition = this.transform.position;
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
                print("t:" + target);
                target = new Vector3(transform.position.x, distance, transform.position.z);
                
                math = false;
            }
            rb.AddForce(Vector3.down * depth);
            rb.velocity = Vector3.zero;
        }
    }
}
