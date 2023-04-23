using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MG5_CaughtControl : MonoBehaviour
{
    Collider col;

    bool isCaught;
    float speed = 35;
    void Start()
    {
        col = GetComponent<Collider>();
    }
    void Update()
    {
        if (isCaught == true)
        {
            transform.Translate(0, speed * Time.deltaTime, 0);
            Destroy(gameObject, 3f);
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Hook")
        {
            isCaught = true;
            col.enabled = false;
        }
    }
}
