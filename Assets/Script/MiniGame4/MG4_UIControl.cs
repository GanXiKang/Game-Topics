using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MG4_UIControl : MonoBehaviour
{
    public GameObject startUI;

    public static bool isStart;

    public void Button_Start()
    {
        startUI.SetActive(false);
        isStart = true;
    }

    void Update()
    {
        
    }
}
