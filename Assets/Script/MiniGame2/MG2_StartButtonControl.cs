using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MG2_StartButtonControl : MonoBehaviour
{
    public GameObject startUI;
    public static bool isStart = false;

    public void Button_Start()
    {
        startUI.SetActive(false);
        isStart = true;
    }
}
