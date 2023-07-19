using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UI_LoadingControl : MonoBehaviour
{
    GameObject LoadingUI;

    void Start()
    {
        LoadingUI = GameObject.Find("Loading");
        StartCoroutine(LoadingNow());
    }

    IEnumerator LoadingNow()
    {
        yield return new WaitForSeconds(3f);
        LoadingUI.SetActive(false);
    }
}
