using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EventImageUIControl : MonoBehaviour
{
    float Timer = 0;

    public GameObject[] eventImage = new GameObject[5];

    public static int eventPointNum, eventAB;
    public static bool isTimer;

    void Update()
    {
        if (isTimer)
        {
            Timer += 1 * Time.deltaTime;

            if (eventPointNum == 2)
            {
                eventImage[0].SetActive(true);
                Timing();
            }
        }
    }
    void Timing()
    {
        if (Timer > 2)
        {
            isTimer = false;
            eventPointNum = 0;
            eventAB = 0;
            for (int i = 0; i < eventImage.Length; i++)
            {
                eventImage[i].SetActive(false);
            }
        }
    }
}