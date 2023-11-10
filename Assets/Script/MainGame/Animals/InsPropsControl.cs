using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InsPropsControl : MonoBehaviour
{
    public GameObject[] props = new GameObject[6];
    public Transform insPropsPoint;

    public static bool[] isInsprops;

    void Start()
    {
        isInsprops[0] = false;
        isInsprops[1] = false;
        isInsprops[2] = false;
        isInsprops[3] = false;
        isInsprops[4] = false;
        isInsprops[5] = false;
    }
    void Update()
    {
        if (isInsprops[0])
        {
            Instantiate(props[0], insPropsPoint.position, insPropsPoint.rotation);
            isInsprops[0] = false;
        }
        else if (isInsprops[1])
        {
            Instantiate(props[1], insPropsPoint.position, insPropsPoint.rotation);
            isInsprops[1] = false;
        }
        else if (isInsprops[2])
        {
            Instantiate(props[2], insPropsPoint.position, insPropsPoint.rotation);
            isInsprops[2] = false;
        }
        else if (isInsprops[3])
        {
            Instantiate(props[3], insPropsPoint.position, insPropsPoint.rotation);
            isInsprops[3] = false;
        }
        else if (isInsprops[4])
        {
            Instantiate(props[4], insPropsPoint.position, insPropsPoint.rotation);
            isInsprops[4] = false;
        }
        else if (isInsprops[5])
        {
            Instantiate(props[5], insPropsPoint.position, insPropsPoint.rotation);
            isInsprops[5] = false;
        }
    }
}
