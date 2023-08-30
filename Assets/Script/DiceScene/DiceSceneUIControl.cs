using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DiceSceneUIControl : MonoBehaviour
{
    public GameObject normalUI, renewUI, doubleUI, customUI;

    void Update()
    {
        if (BagUIControl.isDoubleDice)
        {
            doubleUI.SetActive(true);
        }
        if (BagUIControl.isCustomDice)
        {
            customUI.SetActive(true);
            normalUI.SetActive(false);
        }
    }
}
