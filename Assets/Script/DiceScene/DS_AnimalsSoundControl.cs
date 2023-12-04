using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DS_AnimalsSoundControl : MonoBehaviour
{
    AudioSource BGM;

    public AudioClip animalsSound;

    //bool isOnce;

    void Start()
    {
        BGM = GetComponent<AudioSource>();
        Invoke("PlaySound", 1f);
        //isOnce = true;
    }

    //void Update()
    //{
    //    if (isOnce)
    //    {
    //        Invoke("PlaySound", 1f);
    //        isOnce = false;
    //    }
        
    //}
    void PlaySound()
    {
        BGM.PlayOneShot(animalsSound);
    }
}
