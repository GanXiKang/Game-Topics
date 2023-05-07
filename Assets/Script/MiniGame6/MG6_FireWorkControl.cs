using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MG6_FireWorkControl : MonoBehaviour
{
    public GameObject fireWork;

    void Update()
    {
        if (MG6_EndControl.back)
        {
            Instantiate(fireWork, transform.position, transform.rotation);
        }
    }
}
