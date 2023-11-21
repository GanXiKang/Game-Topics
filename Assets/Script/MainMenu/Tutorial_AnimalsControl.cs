using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Tutorial_AnimalsControl : MonoBehaviour
{
    public AudioSource BGM;
    public AudioClip onClick;
    public GameObject menu1, menu2;
    public Image[] introduce = new Image[20];

    public void Button_Animals(int i)
    {
        menu1.SetActive(false);
        menu2.SetActive(true);
    }
    public void Button_Animator()
    {
       
    }
    public void Button_Call()
    {
        
    }
    public void Button_Back()
    {
        menu1.SetActive(true);
        menu2.SetActive(false);
    }
}
