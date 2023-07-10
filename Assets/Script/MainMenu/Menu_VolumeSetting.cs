using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Menu_VolumeSetting : MonoBehaviour
{
    public Slider sliderBGM;
    public Dropdown quality;

    public static float VolumeBGM = 0.7f;

    AudioSource audio;

    void Start()
    {
        audio = GetComponent<AudioSource>();

        sliderBGM.value = VolumeBGM;
    }
    public void Volume_BGM()
    {
        VolumeBGM = sliderBGM.value;
        audio.volume = VolumeBGM;
    }
    public void Quality(int index)
    {
        QualitySettings.SetQualityLevel(index);
    }
    public void FullScreen(bool isFullScreen)
    {
        Screen.fullScreen = isFullScreen;
    }
}
