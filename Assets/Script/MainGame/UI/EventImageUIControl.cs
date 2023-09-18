using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EventImageUIControl : MonoBehaviour
{
    float Timer = 0;

    public GameObject[] eventImage = new GameObject[19];

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
            if (eventPointNum == 20)
            {
                if (eventAB == 1)
                {
                    eventImage[5].SetActive(true);
                }
                else
                {
                    eventImage[6].SetActive(true);
                }
                Timing();
            }
            if (eventPointNum == 22)
            {
                if (eventAB == 1)
                {
                    eventImage[7].SetActive(true);
                }
                else
                {
                    eventImage[8].SetActive(true);
                }
                Timing();
            }
            if (eventPointNum == 26)
            {
                if (eventAB == 1)
                {
                    eventImage[9].SetActive(true);
                }
                else
                {
                    eventImage[10].SetActive(true);
                }
                Timing();
            }
            if (eventPointNum == 34)
            {
                eventImage[11].SetActive(true);
                Timing();
            }
            if (eventPointNum == 39)
            {
                eventImage[12].SetActive(true);
                Timing();
            }
            if (eventPointNum == 43)
            {
                eventImage[13].SetActive(true);
                Timing();
            }
            if (eventPointNum == 46)
            {
                if (eventAB == 1)
                {
                    eventImage[14].SetActive(true);
                }
                else
                {
                    eventImage[15].SetActive(true);
                }
                Timing();
            }
            if (eventPointNum == 50)
            {
                eventImage[16].SetActive(true);
                Timing();
            }
            if (eventPointNum == 56)
            {
                if (eventAB == 1)
                {
                    eventImage[17].SetActive(true);
                }
                else
                {
                    eventImage[18].SetActive(true);
                }
                Timing();
            }
        }
    }
    void Timing()
    {
        if (Timer > 2)
        {
            isTimer = false;
            Timer = 0;
            eventPointNum = 0;
            eventAB = 0;
            for (int i = 0; i < eventImage.Length; i++)
            {
                eventImage[i].SetActive(false);
            }
        }
    }
}