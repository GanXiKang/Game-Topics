using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InsPropsControl : MonoBehaviour
{
    public GameObject[] props = new GameObject[6];
    public Transform insPropsPoint;

    public static bool isInsAgainDice = false, isInsDoubleDice = false, isInsCustomDice = false;
    public static bool isInsSnatch = false, isInsTrans = false, isInsThief = false;

    void Update()
    {
        switch (ChangeCameraControl.changeCameraNum)
        {
            case 1:
                if (gameObject.tag == "P1")
                {
                    InsProps();
                }
                break;

            case 2:
                if (gameObject.tag == "P2")
                {
                    InsProps();
                }
                break;

            case 3:
                if (gameObject.tag == "P3")
                {
                    InsProps();
                }
                break;

            case 4:
                if (gameObject.tag == "P4")
                {
                    InsProps();
                }
                break;
        }
    }

    void InsProps()
    {
        if (isInsAgainDice)
        {
            Instantiate(props[0], insPropsPoint.position, insPropsPoint.rotation);
            isInsAgainDice = false;
        }
        else if (isInsDoubleDice)
        {
            Instantiate(props[1], insPropsPoint.position, insPropsPoint.rotation);
            isInsDoubleDice = false;
        }
        else if (isInsCustomDice)
        {
            Instantiate(props[2], insPropsPoint.position, insPropsPoint.rotation);
            isInsCustomDice = false;
        }
        else if (isInsSnatch)
        {
            Instantiate(props[3], insPropsPoint.position, insPropsPoint.rotation);
            isInsSnatch = false;
        }
        else if (isInsTrans)
        {
            Instantiate(props[4], insPropsPoint.position, insPropsPoint.rotation);
            isInsTrans = false;
        }
        else if (isInsThief)
        {
            Instantiate(props[5], insPropsPoint.position, insPropsPoint.rotation);
            isInsThief = false;
        }
    }
}
