using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tutorial_Props : MonoBehaviour
{
    public AudioSource BGM;
    public AudioClip onClick;
    public GameObject menu1, menu2, insPoint;
    public GameObject[] props = new GameObject[9];
    public GameObject[] introduce = new GameObject[9];

    public static bool isDestory;

    int num;
    bool isFind;

    void Update()
    {
        if (Menu_TutorialControl.isRenewUI)
        {
            menu1.SetActive(true);
            menu2.SetActive(false);
            Menu_TutorialControl.isRenewUI = false;
        }
        if (isFind)
        {
            Limit();
            DestroyObject();
            for (int a = 1; a < 9; a++)
            {
                if (a == num)
                {
                    introduce[a].SetActive(true);
                    Instantiate(props[a], insPoint.transform.position, insPoint.transform.rotation);
                    Menu_TutorialControl.insNum++;
                }
                else
                {
                    introduce[a].SetActive(false);
                }
            }
            isFind = false;
        }
    }

    public void Button_Game(int p)
    {
        num = p;
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
        if (num > 8)
        {
            num = 1;
        }
        if (num < 1)
        {
            num = 8;
        }
    }
    void DestroyObject()
    {
        if (Menu_TutorialControl.insNum != 0)
        {
            isDestory = true;
        }
    }
}
