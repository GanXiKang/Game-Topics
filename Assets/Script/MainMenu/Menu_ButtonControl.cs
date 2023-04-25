using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Menu_ButtonControl : MonoBehaviour
{
    public GameObject menu1;
    public GameObject menu2;
    public GameObject menu3;
    public GameObject menu_t;

    public void B_Start()
    {
        menu1.SetActive(false);
        menu2.SetActive(true);
    }
    public void B_Tutorial()
    {
        menu1.SetActive(false);
        menu_t.SetActive(true);
    }
    public void B_Setting()
    {
        menu1.SetActive(false);
        menu_t.SetActive(true);
    }
    public void B_Exit()
    {
        Application.Quit();
    }
    public void B_Close()
    {
        menu1.SetActive(true);
        menu2.SetActive(false);
        menu_t.SetActive(false);
    }
    public void B_2p()
    {
        Menu_ChoosePlayer.whoPlay = 2;
        menu2.SetActive(false);
        menu3.SetActive(true);
    }
    public void B_3p()
    {
        Menu_ChoosePlayer.whoPlay = 3;
        menu2.SetActive(false);
        menu3.SetActive(true);
    }
    public void B_4p()
    {
        Menu_ChoosePlayer.whoPlay = 4;
        menu2.SetActive(false);
        menu3.SetActive(true);
    }
    public void B_OK()
    {
        Menu_ChoosePlayer.confirm = true;
    }
    public void B_Cancel()
    {
        Menu_ChoosePlayer.confirm = false;
    }
    public void B_Left()
    {
        Menu_ChoosePlayer.p++;
    }
    public void B_Right()
    {
        Menu_ChoosePlayer.p--;
    }
}
