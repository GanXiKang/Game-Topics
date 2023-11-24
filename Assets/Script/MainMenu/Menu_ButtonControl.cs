using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Menu_ButtonControl : MonoBehaviour
{
    AudioSource BGM;
    public AudioClip onClick, close;

    public GameObject[] menu = new GameObject[5];
    public GameObject cam;

    void Start()
    {
        BGM = GetComponent<AudioSource>();

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
        cam.SetActive(true);
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
        cam.SetActive(false);
        menu[0].SetActive(true);
        menu[1].SetActive(false);
        menu[3].SetActive(false);
        menu[4].SetActive(false);
        BGM.PlayOneShot(close);
    }
    public void B_p(int p)
    {
        Menu_ChoosePlayer.whoPlay = p;
        menu[1].SetActive(false);
        menu[2].SetActive(true);
        BGM.PlayOneShot(onClick);
        Tutorial_Props.isDestory = true;
    }
}
