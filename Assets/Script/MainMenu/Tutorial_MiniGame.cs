using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tutorial_MiniGame : MonoBehaviour
{
    public AudioSource BGM;
    public AudioClip onClick;
    public GameObject menu1, menu2;
    public GameObject[] game = new GameObject[7];

    int num;
    bool isFind;

    void Update()
    {
        if (Menu_TutorialControl.isRenewUI)
        {
            menu1.SetActive(true);
            menu2.SetActive(false);
        }
        if (isFind)
        {
            Limit();
            for (int a = 1; a < 7; a++)
            {
                if (a == num)
                {
                    game[a].SetActive(true);
                }
                else
                {
                    game[a].SetActive(false);
                }
            }
            isFind = false;
        }
    }

    public void Button_Game(int g)
    {
        num = g;
        isFind = true;
        menu1.SetActive(false);
        menu2.SetActive(true);
        BGM.PlayOneShot(onClick);
    }
    public void Button_Back()
    {
        menu1.SetActive(true);
        menu2.SetActive(false);
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
