using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Menu_ButtonControl : MonoBehaviour
{
    public GameObject menu1;
    public GameObject menu2;

    public void B_Start()
    {
        menu1.SetActive(false);
        menu2.SetActive(true);
    }
    public void B_Tutorial()
    {
        
    }
    public void B_Setting()
    {

    }
    public void B_Exit()
    {
        Application.Quit();
    }
    public void Close()
    {
        menu1.SetActive(true);
        menu2.SetActive(false);
    }
    public void B_2p()
    {
        
    }
    public void B_3p()
    {

    }
    public void B_4p()
    {

    }
}
