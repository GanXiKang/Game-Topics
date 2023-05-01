using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MG6_UIControl : MonoBehaviour
{
    public GameObject startUI;
    bool isStart;

    public void Button_Start()
    {
        startUI.SetActive(false);
        isStart = true;
    }
}
