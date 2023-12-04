using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UI_LoadingControl : MonoBehaviour
{
    GameObject LoadingUI;

    void Start()
    {
        LoadingUI = GameObject.Find("Loading");
        Invoke("LoadingNow", 1.2f);
    }

    void LoadingNow()
    {
        LoadingUI.SetActive(false);
    }
}
