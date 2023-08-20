using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class DiceUIControl : MonoBehaviour
{
    public static int who;
    public static bool isDiceUI = true, isDiceScene = false;

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
        StartCoroutine(GoDiceScene());
    }
    IEnumerator GoDiceScene()
    {
        BGM.PlayOneShot(dice);
        isDiceUI = false;

        who = DiceControl.round % Menu_ChoosePlayer.whoPlay;
        who++;
        yield return new WaitForSeconds(0.2f);
        SceneManager.LoadScene(9);
        isDiceScene = true;
    }
}
