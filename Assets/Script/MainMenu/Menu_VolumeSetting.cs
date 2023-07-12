using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Menu_VolumeSetting : MonoBehaviour
{
    public Slider sliderBGM;
    public Dropdown quality;

    public static int index_record;
    public static bool isFullS_record;
    public static float VolumeBGM = 0.7f;
    
    AudioSource audio;

    void Start()
    {
        audio = GetComponent<AudioSource>();

        sliderBGM.value = VolumeBGM;
        QualitySettings.SetQualityLevel(index_record);
        Screen.fullScreen = isFullS_record;
    }
    public void Volume_BGM()
    {
        VolumeBGM = sliderBGM.value;
        audio.volume = VolumeBGM;
    }
    public void Quality(int index)
    {
        QualitySettings.SetQualityLevel(index);
        index_record = index;
    }
    public void FullScreen(bool isFullScreen)
    {
        Screen.fullScreen = isFullScreen;
        isFullS_record = isFullScreen;
    }
}
