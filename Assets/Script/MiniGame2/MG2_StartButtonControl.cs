using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MG2_StartButtonControl : MonoBehaviour
{
    AudioSource BGM;

    public AudioClip button;
    public GameObject startUI;

    public static bool isStart = false;

    void Start()
    {
        BGM = GetComponent<AudioSource>();
    }

    public void Button_Start()
    {
        startUI.SetActive(false);
        isStart = true;
        BGM.PlayOneShot(button);
    }
}
