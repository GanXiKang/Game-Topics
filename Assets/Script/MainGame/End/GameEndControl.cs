using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameEndControl : MonoBehaviour
{
    public Text systemTest;

    private void OnTriggerEnter(Collider other)
    {
        StartCoroutine(BackMainMenu());
    }
    IEnumerator BackMainMenu()
    {
        systemTest.text = "ÓÎ‘ò½YÊø£¡";
        systemTest.color = Color.blue;
        SystemTestTextControl.isTimer = true;
        yield return new WaitForSeconds(5f);
        SceneManager.LoadScene(0);
        Menu_ChoosePlayer.whoPlay = 0;
        Dice.P1_totalNum = 0;
        Dice.P2_totalNum = 0;
        Dice.P3_totalNum = 0;
        Dice.P4_totalNum = 0;
        Dice.round = 0;
        DontDestroyOnLoadControl.newGame = true;
    }
}
