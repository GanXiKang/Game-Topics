using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Menu_TutorialControl : MonoBehaviour
{
    public GameObject[] buttonShort = new GameObject[4];
    public GameObject[] buttonLong = new GameObject[4];
    public GameObject frontPage, animals, scene, mg, props;

    int buttonNum;
    bool isButtonDisable;

    void Update()
    {
        if (isButtonDisable)
        {
            for (int b = 0; b < 4; b++)
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
        isButtonDisable = true;
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
                break;

            case 1:
                animals.SetActive(false);
                scene.SetActive(true);
                mg.SetActive(false);
                props.SetActive(false);
                break;

            case 2:
                animals.SetActive(false);
                scene.SetActive(false);
                mg.SetActive(true);
                props.SetActive(false);
                break;

            case 3:
                animals.SetActive(false);
                scene.SetActive(false);
                mg.SetActive(false);
                props.SetActive(true);
                break;
        }
    }
}
