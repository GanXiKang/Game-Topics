using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioControl : MonoBehaviour
{
    AudioSource BGM;

    public AudioClip insKickboard, destoryKickboard;
    public AudioClip racoon, sloth, fox, ostrich, bear, dolphin;

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
    }
}
