using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InsPropsControl : MonoBehaviour
{
    public GameObject[] props = new GameObject[6];
    public Transform insPropsPoint;

    public static bool[] isInsProps;

    void Start()
    {
        isInsProps[0] = false;
        isInsProps[1] = false;
        isInsProps[2] = false;
        isInsProps[3] = false;
        isInsProps[4] = false;
        isInsProps[5] = false;
    }
    void Update()
    {
        if (isInsProps[0])
        {
            Instantiate(props[0], insPropsPoint.position, insPropsPoint.rotation);
            isInsProps[0] = false;
        }
        else if (isInsProps[1])
        {
            Instantiate(props[1], insPropsPoint.position, insPropsPoint.rotation);
            isInsProps[1] = false;
        }
        else if (isInsProps[2])
        {
            Instantiate(props[2], insPropsPoint.position, insPropsPoint.rotation);
            isInsProps[2] = false;
        }
        else if (isInsProps[3])
        {
            Instantiate(props[3], insPropsPoint.position, insPropsPoint.rotation);
            isInsProps[3] = false;
        }
        else if (isInsProps[4])
        {
            Instantiate(props[4], insPropsPoint.position, insPropsPoint.rotation);
            isInsProps[4] = false;
        }
        else if (isInsProps[5])
        {
            Instantiate(props[5], insPropsPoint.position, insPropsPoint.rotation);
            isInsProps[5] = false;
        }
    }
}
