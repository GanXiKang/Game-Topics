using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tutorial_Scene : MonoBehaviour
{
    public AudioSource BGM;
    public AudioClip onClick;
    public GameObject menu1, menuMap, menuPoint;
    public GameObject[] map = new GameObject[7];
    public GameObject[] point = new GameObject[7];

    int num;
    bool isFind;

    void Update()
    {
        if (isFind)
        {
            Limit();
            for (int a = 1; a < 20; a++)
            {
                if (a == num)
                {
                    map[a].SetActive(true);
                    point[a].SetActive(true);
                }
                else
                {
                    map[a].SetActive(false);
                    point[a].SetActive(false);
                }
            }
            isFind = false;
        }
    }

    public void Button_Map(int m)
    {
        num = m;
        isFind = true;
        menu1.SetActive(false);
        menuMap.SetActive(true);
        BGM.PlayOneShot(onClick);
    }
    public void Button_Point(int p)
    {
        num = p;
        isFind = true;
        menu1.SetActive(false);
        menuPoint.SetActive(true);
        BGM.PlayOneShot(onClick);
    }
    public void Button_Back()
    {
        menu1.SetActive(true);
        menuMap.SetActive(false);
        menuPoint.SetActive(false);
        BGM.PlayOneShot(onClick);
    }
    public void Button_Left()
    {
        num--;
        isFind = true;
        BGM.PlayOneShot(onClick);
    }
    public void Button_Right()
    {
        num++;
        isFind = true;
        BGM.PlayOneShot(onClick);
    }

    void Limit()
    {
        if (num > 6)
        {
            num = 1;
        }
        if (num < 1)
        {
            num = 6;
        }
    }
}
