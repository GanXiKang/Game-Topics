using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tutorial_AnimalsControl : MonoBehaviour
{
    public AudioSource BGM;
    public AudioClip onClick;
    public GameObject menu1, menu2, insPoint;
    public GameObject[] animals = new GameObject[20];
    public GameObject[] introduce = new GameObject[20];

    public static bool isDestory, isAnimator, isCall;

    int who;
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
            for (int a = 1; a < 20; a++)
            {
                if (a == who)
                {
                    introduce[a].SetActive(true);
                    Instantiate(animals[a], insPoint.transform.position, insPoint.transform.rotation);
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
        isAnimator = true;
        BGM.PlayOneShot(onClick);
    }
    public void Button_Call()
    {
        isCall = true;
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
        BGM.PlayOneShot(onClick);
    }
    public void Button_Right()
    {
        who++;
        isFind = true;
        BGM.PlayOneShot(onClick);
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
    void DestroyObject()
    {
        if (Menu_TutorialControl.insNum != 0)
        {
            isDestory = true;
        }
    }
}
