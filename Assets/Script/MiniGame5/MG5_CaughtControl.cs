using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MG5_CaughtControl : MonoBehaviour
{
    float speed = 25;
    bool isCaught;
    void Update()
    {
        if (isCaught == true)
        {
            transform.position += new Vector3(0, speed * Time.deltaTime, 0);
            Destroy(gameObject, 2f);
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
