using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BagUIControl : MonoBehaviour
{
    public GameObject bagUI;
    public GameObject interactiveUI;

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
