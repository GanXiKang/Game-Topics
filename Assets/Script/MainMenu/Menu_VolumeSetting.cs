using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Audio;

public class Menu_VolumeSetting : MonoBehaviour
{
    [SerializeField] private Slider sliderBGM;
    [SerializeField] private Slider sliderEffects;

    public static float VolumeBGM, VolumeEffects;

    private void Start()
    {
        sliderBGM.value = 70f;
        sliderEffects.value = 70f;
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
