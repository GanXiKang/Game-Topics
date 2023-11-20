using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Menu_TutorialControl : MonoBehaviour
{
    public GameObject[] buttonShort = new GameObject[4];
    public GameObject[] buttonLong = new GameObject[4];

    void Start()
    {
        
    }

    void Update()
    {
        
    }

    public void Button_Beside(int i)
    {
        for (int b = 0; b < 4; b++)
        {
            if (b == i)
            {
                buttonShort[i].SetActive(false);
                buttonLong[i].SetActive(true);
            }
            else
            {
                buttonShort[i].SetActive(true);
                buttonLong[i].SetActive(false);
            }
        }
    }
}
