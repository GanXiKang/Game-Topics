using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioControl : MonoBehaviour
{
    AudioSource BGM;

    public AudioClip insKickboard, destoryKickboard;
    public AudioClip racoon, sloth, fox, ostrich, bear, dolphin;
    public AudioClip cowSkill, monkeySkill;

    void Start()
    {
        BGM = GetComponent<AudioSource>();
    }

    void Update()
    {
        if (InsKickboardControl.insKickboard)
        {
            BGM.PlayOneShot(insKickboard);
            InsKickboardControl.insKickboard = false;
        }
        if (InsKickboardControl.destoryKickboard)
        {
            BGM.PlayOneShot(destoryKickboard);
            InsKickboardControl.destoryKickboard = false;
        }
        if (MiniGameColliderControl.isRacoonCall || MGFinishAwardControl.isRacoonCall)
        {
            BGM.PlayOneShot(racoon);
            MiniGameColliderControl.isRacoonCall = false;
            MGFinishAwardControl.isRacoonCall = false;
        }
        if (MiniGameColliderControl.isSlothCall || MGFinishAwardControl.isSlothCall)
        {
            BGM.PlayOneShot(sloth);
            MiniGameColliderControl.isSlothCall = false;
            MGFinishAwardControl.isSlothCall = false;
        }
        if (MiniGameColliderControl.isFoxCall || MGFinishAwardControl.isFoxCall)
        {
            BGM.PlayOneShot(fox);
            MiniGameColliderControl.isFoxCall = false;
            MGFinishAwardControl.isFoxCall = false;
        }
        if (MiniGameColliderControl.isOstrichCall || MGFinishAwardControl.isOstrichCall)
        {
            BGM.PlayOneShot(ostrich);
            MiniGameColliderControl.isOstrichCall = false;
            MGFinishAwardControl.isOstrichCall = false;
        }
        if (MiniGameColliderControl.isBearCall || MGFinishAwardControl.isBearCall)
        {
            BGM.PlayOneShot(bear);
            MiniGameColliderControl.isBearCall = false;
            MGFinishAwardControl.isBearCall = false;
        }
        if (MiniGameColliderControl.isDolphinCall || MGFinishAwardControl.isDolphinCall)
        {
            BGM.PlayOneShot(dolphin);
            MiniGameColliderControl.isDolphinCall = false;
            MGFinishAwardControl.isDolphinCall = false;
        }
    }
}
