using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Dice : MonoBehaviour
{
    public static bool isDiceUI = true, isDiceScene = false;

    public int min;
    public int max;

    public GameObject diceUI;
    public Text systemText;
    public AudioSource BGM;
    public AudioClip dice;

    void Update()
    {
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
        BGM.PlayOneShot(dice);
        isDiceUI = false;

        SceneManager.LoadScene(9);
        isDiceScene = true;

        //TestUse();
    }

    void TestUse()
    {
        diceNum = Random.Range(min, max);
        BGM.PlayOneShot(dice);
        isDiceUI = false;

        systemText.text = " " + diceNum;
        systemText.color = Color.green;
        SystemTestTextControl.isTimer = true;

        Calculate();
    }
    void Calculate()
    {
        who = round % Menu_ChoosePlayer.whoPlay;
        who++;
        ChangeCameraControl.changeCameraNum = who;
        switch (who)
        {
            case 1:
                P1_totalNum += diceNum;
                AnimatorControl.isP1Move = true;
                break;

            case 2:
                P2_totalNum += diceNum;
                AnimatorControl.isP2Move = true;
                break;

            case 3:
                P3_totalNum += diceNum;
                AnimatorControl.isP3Move = true;
                break;

            case 4:
                P4_totalNum += diceNum;
                AnimatorControl.isP4Move = true;
                break;
        }
        round++;
    }
}