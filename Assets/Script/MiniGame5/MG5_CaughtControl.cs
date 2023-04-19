using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MG5_CaughtControl : MonoBehaviour
{
    bool isCaught;
    float speed = 25;
    void Update()
    {
        if (isCaught == true)
        {
            transform.Translate(0, speed * Time.deltaTime, 0);
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Hook")
        {
            isCaught = true;
        }
    }
}
