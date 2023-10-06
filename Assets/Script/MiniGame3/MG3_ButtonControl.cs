using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MG3_ButtonControl : MonoBehaviour
{ 
    public GameObject startUI, B_Next, B_Cup1, B_Cup2, B_Cup3;
    public Text score;
    public AudioSource BGM;
    public AudioClip button, openCup, closeCup;

    public static int openWhyCup;

    bool startActive;

    public void Button_Start()
    {
        startUI.SetActive(false);
        MG3_GameControl.round++;
        Invoke("DownCup", 0.5f);
    }
    public void NextRound()
    {
        B_Next.SetActive(false);
        MG3_GameControl.round++;
        Invoke("DownCup", 0.3f);
    }
    public void OpenWhyCup(int i)
    {
        B_Cup1.SetActive(false);
        B_Cup2.SetActive(false);
        B_Cup3.SetActive(false);
        openWhyCup = i;
    }
    
    void Update()
    {

    }

    void DownCup()
    {
        MG3_GameControl.DownCup = true;
    }
}
