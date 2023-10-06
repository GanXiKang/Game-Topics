using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MG3_ButtonControl : MonoBehaviour
{ 
    public GameObject startUI, B_Next, B_Cup1, B_Cup2, B_Cup3;
    public AudioSource BGM;
    public AudioClip button, openCup, closeCup;

    public static int openWhyCup;
    public static bool isGuess = false, isOpenCup = false;

    bool startActive;

    public void Button_Start()
    {
        startUI.SetActive(false);
        MG3_GameControl.round++;
        Invoke("DownCup", 1f);
    }
    public void NextRound()
    {
        B_Next.SetActive(false);
        MG3_GameControl.round++;
        Invoke("DownCup", 0.5f);
    }
    public void OpenWhyCup(int i)
    {
        isGuess = false;
        isOpenCup = true;
        openWhyCup = i;
    }
    
    void Update()
    {
        if (isGuess)
        {
            B_Cup1.SetActive(true);
            B_Cup2.SetActive(true);
            B_Cup3.SetActive(true);
        }
        else
        {
            B_Cup1.SetActive(false);
            B_Cup2.SetActive(false);
            B_Cup3.SetActive(false);
        }
    }

    void DownCup()
    {
        MG3_GameControl.DownCup = true;
    }
}
