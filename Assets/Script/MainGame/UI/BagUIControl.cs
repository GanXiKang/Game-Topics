using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BagUIControl : MonoBehaviour
{
    AudioSource BGM;

    public GameObject bagUI;
    public GameObject interactiveUI;
    public Button[] use = new Button[7];

    void Start()
    {
        BGM = GetComponent<AudioSource>();
    }
    public void Button_Bag()
    {
        bagUI.SetActive(true);
        interactiveUI.SetActive(false);
    }
    public void Button_Close()
    {
        bagUI.SetActive(false);
        interactiveUI.SetActive(true);
    }
}
