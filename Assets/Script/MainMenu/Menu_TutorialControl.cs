using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Menu_TutorialControl : MonoBehaviour
{
    AudioSource BGM;

    public AudioClip onClick;
    public GameObject frontPage, animals, scene, mg, props, story;
    public GameObject[] buttonShort = new GameObject[5];
    public GameObject[] buttonLong = new GameObject[5];

    public static int insNum;
    public static bool isRenewUI;

    int buttonNum;
    bool isButtonDisable;

    void Start()
    {
        BGM = GetComponent<AudioSource>();
        insNum = 0;
        Tutorial_Props.isDestory = false;
        Tutorial_AnimalsControl.isDestory = false;
    }
    void Update()
    {
        if (isButtonDisable)
        {
            for (int b = 0; b < 5; b++)
            {
                if (b == buttonNum)
                {
                    buttonShort[b].SetActive(false);
                    buttonLong[b].SetActive(true);
                }
                else
                {
                    buttonShort[b].SetActive(true);
                    buttonLong[b].SetActive(false);
                }
            }
            MenuDisable();
            frontPage.SetActive(false);
            isButtonDisable = false;
        }
    }

    public void Button_Beside(int i)
    {
        buttonNum = i;
        isRenewUI = true;
        isButtonDisable = true;
        BGM.PlayOneShot(onClick);
    }

    void MenuDisable()
    {
        switch (buttonNum)
        {
            case 0:
                animals.SetActive(true);
                scene.SetActive(false);
                mg.SetActive(false);
                props.SetActive(false);
                story.SetActive(false);
                break;

            case 1:
                animals.SetActive(false);
                scene.SetActive(true);
                mg.SetActive(false);
                props.SetActive(false);
                story.SetActive(false);
                break;

            case 2:
                animals.SetActive(false);
                scene.SetActive(false);
                mg.SetActive(true);
                props.SetActive(false);
                story.SetActive(false);
                break;

            case 3:
                animals.SetActive(false);
                scene.SetActive(false);
                mg.SetActive(false);
                props.SetActive(true);
                story.SetActive(false);
                break;

            case 4:
                animals.SetActive(false);
                scene.SetActive(false);
                mg.SetActive(false);
                props.SetActive(false);
                story.SetActive(true);
                break;
        }
    }
}
