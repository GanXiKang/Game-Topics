using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Audio;

public class Menu_VolumeSetting : MonoBehaviour
{
    [SerializeField] private Slider sliderBGM;
    [SerializeField] private Slider sliderEffects;

    public static float VolumeBGM = 0.7f, VolumeEffects = 0.7f;

    void Start()
    {
        sliderBGM.value = VolumeBGM;
        sliderEffects.value = VolumeEffects;
    }
    public void Volume_BGM()
    {
        VolumeBGM = sliderBGM.value;
    }
    public void Volume_Effects()
    {
        VolumeEffects = sliderEffects.value;
    }
}
