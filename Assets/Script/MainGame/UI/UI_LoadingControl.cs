using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UI_LoadingControl : MonoBehaviour
{
    GameObject LoadingUI;
    float timer;

    private void Start()
    {
        LoadingUI = GameObject.Find("Loading");
    }
    void Update()
    {
        timer += 1 * Time.deltaTime;

        if (timer >= 3f)                           
        {
            LoadingUI.SetActive(false);
        }
    }
}
