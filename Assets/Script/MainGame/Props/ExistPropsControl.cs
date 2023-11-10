using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExistPropsControl : MonoBehaviour
{
    public float speed = 2f;

    void Start()
    {
        Invoke("DestoryProps", 2f);
    }
    void FixedUpdate()
    {
        transform.position += Vector3.up * speed * Time.deltaTime;
    }

    void DestoryProps()
    {
        Destroy(this.gameObject);
    }
}
