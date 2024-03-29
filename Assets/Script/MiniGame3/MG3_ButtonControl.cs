using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MG3_ButtonControl : MonoBehaviour
{
    AudioSource BGM;

    public GameObject startUI, B_Next, B_Cup1, B_Cup2, B_Cup3;
    public AudioClip button, openCup, closeCup;

    public static int openWhyCup;
    public static bool isGuess = false, isOpenCup = false, isNextRound = false;

    void Start()
    {
        BGM = GetComponent<AudioSource>();
    }

    public void Button_Start()
    {
        startUI.SetActive(false);
        MG3_GameControl.round++;
        Invoke("DownCup", 1f);
        BGM.PlayOneShot(button);
    }
    public void NextRound()
    {
        isNextRound = false;
        MG3_GameControl.round++;
        Invoke("DownCup", 0.5f);
        BGM.PlayOneShot(button);
    }
    public void OpenWhyCup(int i)
    {
        isGuess = false;
        isOpenCup = true;
        openWhyCup = i;
        BGM.PlayOneShot(openCup);
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

        if (isNextRound)
        {
            B_Next.SetActive(true);
        }
        else
        {
            B_Next.SetActive(false);
        }
    }

    void DownCup()
    {
        MG3_GameControl.isDownCup = true;
        BGM.PlayOneShot(closeCup);
    }
}
