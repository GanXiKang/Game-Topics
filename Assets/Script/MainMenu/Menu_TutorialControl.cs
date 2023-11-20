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
            print(buttonNum);
            for (int b = 0; b < 4; b++)
            {
                if (b == buttonNum)
                {
                    buttonShort[buttonNum].SetActive(false);
                    buttonLong[buttonNum].SetActive(true);
                }
                else
                {
                    buttonShort[buttonNum].SetActive(true);
                    buttonLong[buttonNum].SetActive(false);
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
