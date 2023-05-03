using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MG6_UIControl : MonoBehaviour
{
    public GameObject startUI;
    public AudioSource BGM;
    public AudioClip button;
    public static bool isStart = false;
    

    public void Button_Start()
    {
        startUI.SetActive(false);
        isStart = true;
        BGM.PlayOneShot(button);
    }
}
