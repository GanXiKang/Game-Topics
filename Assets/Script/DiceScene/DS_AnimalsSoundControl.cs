using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DS_AnimalsSoundControl : MonoBehaviour
{
    AudioSource BGM;

    public AudioClip animalsSound;

    void Start()
    {
        BGM = GetComponent<AudioSource>();
        Invoke("PlaySound", 1f);
    }

    void PlaySound()
    {
        BGM.PlayOneShot(animalsSound);
    }
}
