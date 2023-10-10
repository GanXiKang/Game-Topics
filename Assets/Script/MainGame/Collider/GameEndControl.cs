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
                AnimatorControl.isP1Win = true;
            }
        }
        else if (other.tag == "P2")
        {
            if (DiceControl.P2_totalNum >= endPoint)
            {
                whoWin = 2;
                AnimatorControl.isP2Win = true;
            }
        }
        else if (other.tag == "P3")
        {
            if (DiceControl.P3_totalNum >= endPoint)
            {
                whoWin = 3;
                AnimatorControl.isP3Win = true;
            }
        }
        else if (other.tag == "P4")
        {
            if (DiceControl.P4_totalNum >= endPoint)
            {
                whoWin = 4;
                AnimatorControl.isP4Win = true;
            }
        }
    }
    IEnumerator BackMainMenu()
    {
        systemTest.text = "ß[‘ò½YÊø£¡";
        SystemTestTextControl.isTimer = true;
        CameraMoveControl.isChangeCameraPoint = true;
        yield return new WaitForSeconds(3f);
        SceneManager.LoadScene(8);
        isEnd = true;
        CameraMoveControl.isChangeCameraPoint = false;
    }
}
