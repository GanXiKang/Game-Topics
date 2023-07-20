using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MG_AudioVolumeControl : MonoBehaviour
{
    AudioSource audio;

    void Start()
    {
        audio = GetComponent<AudioSource>();
    }

    void Update()
    {
        audio.volume = Menu_VolumeSetting.VolumeBGM;
    }
}
