using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Menu_ButtonControl : MonoBehaviour
{
    public GameObject[] menu = new GameObject[5];

    public AudioSource BGM;
    public AudioClip onClick, close;

    void Start()
    {
        menu[0].SetActive(true);
        menu[1].SetActive(false);
        menu[2].SetActive(false);
        menu[3].SetActive(false);
        menu[4].SetActive(false);
    }
    public void B_Start()
    {
        menu[0].SetActive(false);
        menu[1].SetActive(true);
        BGM.PlayOneShot(onClick);
    }
    public void B_Tutorial()
    {
        menu[0].SetActive(false);
        menu[3].SetActive(true);
        BGM.PlayOneShot(onClick);
    }
    public void B_Setting()
    {
        menu[0].SetActive(false);
        menu[4].SetActive(true);
        BGM.PlayOneShot(onClick);
    }
    public void B_Exit()
    {
        BGM.PlayOneShot(onClick);
        Application.Quit();
    }
    public void B_Close()
    {
        menu[0].SetActive(true);
        menu[1].SetActive(false);
        menu[3].SetActive(false);
        menu[4].SetActive(false);
        BGM.PlayOneShot(close);
    }
    public void B_2p()
    {
        Menu_ChoosePlayer.whoPlay = 2;
        menu[1].SetActive(false);
        menu[2].SetActive(true);
        BGM.PlayOneShot(onClick);
    }
    public void B_3p()
    {
        Menu_ChoosePlayer.whoPlay = 3;
        menu[1].SetActive(false);
        menu[2].SetActive(true);
        BGM.PlayOneShot(onClick);
    }
    public void B_4p()
    {
        Menu_ChoosePlayer.whoPlay = 4;
        menu[1].SetActive(false);
        menu[2].SetActive(true);
        BGM.PlayOneShot(onClick);
    }
}
