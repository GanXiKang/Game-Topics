using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MG5_HookControl : MonoBehaviour
{
    float depth, distance,speed = 10;
    public static bool math = false;
    Vector3 originalPosition, target;

    void Start()
    {
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
            gameObject.transform.localPosition = Vector3.MoveTowards(originalPosition, target, speed * Time.deltaTime);
        }
    }
}
