using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BagUIControl : MonoBehaviour
{
    AudioSource BGM;

    public GameObject bagUI;
    public GameObject interactiveUI;

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
