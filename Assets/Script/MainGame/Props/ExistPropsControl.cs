using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExistPropsControl : MonoBehaviour
{
    public float s = 2f;

    void Start()
    {
        Invoke("DestoryProps", 2f);
    }
    void FixedUpdate()
    {
        transform.position += Vector3.up * s * Time.deltaTime;
        transform.Rotate(0, s, 0);
    }

    void DestoryProps()
    {
        Destroy(this.gameObject);
    }
}
