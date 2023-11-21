using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Tutorial_AnimalsControl : MonoBehaviour
{
    public AudioSource BGM;
    public AudioClip onClick;
    public GameObject menu1, menu2;
    public GameObject[] introduce = new GameObject[20];

    int who;
    bool isFind;

    void Update()
    {
        if (isFind)
        {
            Limit();
            for (int a = 1; a < 20; a++)
            {
                if (a == who)
                {
                    introduce[a].SetActive(true);
                }
                else
                {
                    introduce[a].SetActive(false);
                }
            }
            isFind = false;
        }
    }
    public void Button_Animals(int i)
    {
        who = i;
        isFind = true;
        menu1.SetActive(false);
        menu2.SetActive(true);
        BGM.PlayOneShot(onClick);
    }
    public void Button_Animator()
    {
        BGM.PlayOneShot(onClick);
    }
    public void Button_Call()
    {
        
    }
    public void Button_Back()
    {
        menu1.SetActive(true);
        menu2.SetActive(false);
        BGM.PlayOneShot(onClick);
    }
    public void Button_Left()
    {
        who--;
        isFind = true;
    }
    public void Button_Right()
    {
        who++;
        isFind = true;
    }

    void Limit()
    {
        if (who > 19)
        {
            who = 1;
        }
        if (who < 1)
        {
            who = 19;
        }
    }
}
