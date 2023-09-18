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
            if (eventPointNum == 6)
            {
                if (eventAB == 1)
                {
                    eventImage[1].SetActive(true);
                }
                else 
                {
                    eventImage[2].SetActive(true);
                }
                Timing();
            }
            if (eventPointNum == 11)
            {
                eventImage[3].SetActive(true);
                Timing();
            }
            if (eventPointNum == 13)
            {
                eventImage[4].SetActive(true);
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