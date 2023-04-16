using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MG4_UIControl : MonoBehaviour
{
    public GameObject startUI;
    public GameObject comboObject;
    public Text combo;

    public static bool isStart;

    public void Button_Start()
    {
        startUI.SetActive(false);
        isStart = true;
    }

    void Update()
    {
        if (MG4_RoadBlockControl.combo >= 3)
        {
            comboObject.SetActive(true);
            combo.text = MG4_RoadBlockControl.combo + " Combo";
        }
        else
        {
            comboObject.SetActive(false);
        }
    }
}
