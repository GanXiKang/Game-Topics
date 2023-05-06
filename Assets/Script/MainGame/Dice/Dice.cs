using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Dice : MonoBehaviour
{
    int diceNum = 0, who;
    public static int P1_totalNum = 0, P2_totalNum = 0, P3_totalNum = 0, P4_totalNum = 0, round;

    public int min = 1;
    public int max = 7;

    public GameObject Interactive_UI;
    public Text systemText;
    public AudioSource BGM;
    public AudioClip dice;

    public void Button_Dice()
    {
        diceNum = Random.Range(min, max);

        Interactive_UI.SetActive(false);
        systemText.text = " " + diceNum;
        BGM.PlayOneShot(dice);

        who = round % Menu_ChoosePlayer.whoPlay;
        who++;

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
        CameraControl.changeCamera++;
    }
}