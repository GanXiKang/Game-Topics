using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameEndControl : MonoBehaviour
{
    public Text systemTest;
    public int endPoint;

    public static int whoWin;
    public static bool isEnd = false;
    
    private void OnTriggerEnter(Collider other)
    {
        StartCoroutine(BackMainMenu());
        if (other.tag == "P1")
        {
            if (DiceControl.P1_totalNum >= endPoint)
            {
                whoWin = 1;
            }
        }
        else if (other.tag == "P2")
        {
            if (DiceControl.P2_totalNum >= endPoint)
            {
                whoWin = 2;
            }
        }
        else if (other.tag == "P3")
        {
            if (DiceControl.P3_totalNum >= endPoint)
            {
                whoWin = 3;
            }
        }
        else if (other.tag == "P4")
        {
            if (DiceControl.P4_totalNum >= endPoint)
            {
                whoWin = 4;
            }
        }
    }
    IEnumerator BackMainMenu()
    {
        systemTest.text = "ÓÎ‘ò½YÊø£¡";
        systemTest.color = Color.blue;
        SystemTestTextControl.isTimer = true;
        yield return new WaitForSeconds(3f);
        SceneManager.LoadScene(8);
        isEnd = true;
        Menu_ChoosePlayer.whoPlay = 0;
        DiceControl.P1_totalNum = 0;
        DiceControl.P2_totalNum = 0;
        DiceControl.P3_totalNum = 0;
        DiceControl.P4_totalNum = 0;
    }
}
