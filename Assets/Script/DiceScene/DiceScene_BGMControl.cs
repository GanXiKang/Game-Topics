using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DiceScene_BGMControl : MonoBehaviour
{
    AudioSource BGM;

    public AudioClip[] region = new AudioClip[6];

    public static int isWhyRegion;

    void Start()
    {
        BGM = GetComponent<AudioSource>();
    }

    
    void Update()
    {
        
    }
}
