using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Menu_TutorialControl : MonoBehaviour
{
    public GameObject[] buttonShort = new GameObject[4];
    public GameObject[] buttonLong = new GameObject[4];

    int buttonNum;
    bool isButtonDisable;

    void Start()
    {
        
    }

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
            isButtonDisable = false;

        }
    }

    public void Button_Beside(int i)
    {
        buttonNum = i;
        isButtonDisable = true;
    }
}
