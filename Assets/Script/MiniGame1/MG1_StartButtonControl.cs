using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MG1_StartButtonControl : MonoBehaviour
{
    AudioSource BGM;

    public AudioClip button;
    public GameObject startUI;

    void Start()
    {
        BGM = GetComponent<AudioSource>();
    }

    public void Button_Start()
    {
        startUI.SetActive(false);
        BGM.PlayOneShot(button);
    }
}
