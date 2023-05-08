using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Dice : MonoBehaviour
{
    int diceNum = 0, who;
    public static int P1_totalNum = 0, P2_totalNum = 0, P3_totalNum = 0, P4_totalNum = 0, round;
    public static bool isDiceUI = true;

    public int min = 1;
    public int max = 7;

    public GameObject diceUI;
    public Text systemText;
    public AudioSource BGM;
    public AudioClip dice;

    void Update()
    {
        print("Dice" + isDiceUI);
        if (isDiceUI)
        {
            diceUI.SetActive(true);
        }
        else
        {
            diceUI.SetActive(false);
        }
    }
    public void Button_Dice()
    {
        diceNum = Random.Range(min, max);
        BGM.PlayOneShot(dice);
        isDiceUI = false;

        systemText.text = " " + diceNum;
        systemText.color = Color.green;
        SystemTestTextControl.isTimer = true;

        AnimatorControl.isMove = true;

        who = round % Menu_ChoosePlayer.whoPlay;
        who++;
        ChangeCameraControl.changeCameraNum = who;
        switch (who)
        {
            case 1:
                P1_totalNum += diceNum;
                break;

            case 2:
                P2_totalNum += diceNum;
                break;

            case 3:
                P3_totalNum += diceNum;
                break;

            case 4:
                P4_totalNum += diceNum;
                break;
        }
        round++;
    }
}