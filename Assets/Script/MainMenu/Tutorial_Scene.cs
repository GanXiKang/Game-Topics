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

    void Update()
    {
        Limit();
    }

    public void Button_Map(int m)
    {
        num = m;
        menu1.SetActive(false);
        menuMap.SetActive(true);
        BGM.PlayOneShot(onClick);
    }
    public void Button_Point(int p)
    {
        num = p;
        menu1.SetActive(false);
        menuMap.SetActive(true);
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
        BGM.PlayOneShot(onClick);
    }
    public void Button_Right()
    {
        num++;
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
