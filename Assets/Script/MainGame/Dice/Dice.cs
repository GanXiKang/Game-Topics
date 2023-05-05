using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dice : MonoBehaviour
{
    float diceNum = 0, who;
    public static float P1_totalNum = 0, P2_totalNum = 0, P3_totalNum = 0, P4_totalNum = 0, round;
    public static bool isThrow;

    public int min = 1;
    public int max = 7;

    public AudioSource BGM;
    public AudioClip dice;

    public void Button_Dice()
    {

        BGM.PlayOneShot(dice);
        diceNum = Random.Range(min, max);
        isThrow = true;
        Debug.Log(diceNum);

        who = round % Menu_ChoosePlayer.whoPlay;
        who++;

        //who = 1;
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