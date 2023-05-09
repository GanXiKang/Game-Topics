using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIIsMiniGameControl : MonoBehaviour
{
    AudioSource BGM;
    public GameObject UI_MainGame;
    void Start()
    {
        BGM = GetComponent<AudioSource>();
    }
    void Update()
    {
        if (MiniGameColliderControl.isMiniGame)
        {
            UI_MainGame.SetActive(false);
            BGM.Stop();
        }
        else
        {
            UI_MainGame.SetActive(true);
            BGM.Play();
        }
    }
}
