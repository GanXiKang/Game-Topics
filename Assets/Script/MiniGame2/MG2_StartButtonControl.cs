using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MG2_StartButtonControl : MonoBehaviour
{
    public GameObject startUI;
    public static bool isStart = false;

    public AudioSource BGM;
    public AudioClip button;

    public void Button_Start()
    {
        startUI.SetActive(false);
        isStart = true;
        BGM.PlayOneShot(button);
    }
}
