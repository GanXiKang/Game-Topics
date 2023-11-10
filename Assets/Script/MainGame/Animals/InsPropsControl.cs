using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InsPropsControl : MonoBehaviour
{
    public GameObject[] props = new GameObject[6];
    public Transform insPropsPoint;

    void Start()
    {
        Instantiate(props[0], insPropsPoint.position, insPropsPoint.rotation);
    }
    void Update()
    {
        
    }
}
