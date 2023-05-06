using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UI_RoundControl : MonoBehaviour
{
    public GameObject b_dice, b_NextR;

    public void Button_NextRound()
    {
        b_dice.SetActive(true);
        b_NextR.SetActive(false);
        ChangeCameraControl.changeCameraNum++;
    }
}
