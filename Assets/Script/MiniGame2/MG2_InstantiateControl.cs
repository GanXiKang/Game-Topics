using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MG2_InstantiateControl : MonoBehaviour
{
    public GameObject apple;
    public GameObject boom;

    float x;
    void Start()
    {
        
    }
    void Update()
    {
        x = Random.Range(-60, 60);
        Instantiate(apple, new Vector3(x, 33.8f, 0), transform.rotation);
    }
}
