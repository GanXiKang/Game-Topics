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
    public static bool isEnd;

    void Start()
    { 
        isEnd = false;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "P1")
        {
            if (DiceControl.P1_totalNum >= endPoint)
            {
                whoWin = 1;
                AnimatorControl.isP1Move = false;
                AnimatorControl.isP1Skill = false;
                AnimatorControl.isP1Win = true;
                AnimatorControl.isP2Lose = true;
                AnimatorControl.isP3Lose = true;
                AnimatorControl.isP4Lose = true;
                StartCoroutine(GOEndScene());
            }
        }
        else if(other.tag == "P2")
        {
            if (DiceControl.P2_totalNum >= endPoint)
            {
                whoWin = 2;
                AnimatorControl.isP2Move = false;
                AnimatorControl.isP2Skill = false;
                AnimatorControl.isP2Win = true;
                AnimatorControl.isP1Lose = true;
                AnimatorControl.isP3Lose = true;
                AnimatorControl.isP4Lose = true;
                StartCoroutine(GOEndScene());
            }
        }
        else if (other.tag == "P3")
        {
            if (DiceControl.P3_totalNum >= endPoint)
            {
                whoWin = 3;
                AnimatorControl.isP3Move = false;
                AnimatorControl.isP3Skill = false;
                AnimatorControl.isP3Win = true;
                AnimatorControl.isP1Lose = true;
                AnimatorControl.isP2Lose = true;
                AnimatorControl.isP4Lose = true;
                StartCoroutine(GOEndScene());
            }
        }
        else if (other.tag == "P4")
        {
            if (DiceControl.P4_totalNum >= endPoint)
            {
                whoWin = 4;
                AnimatorControl.isP4Move = false;
                AnimatorControl.isP4Skill = false;
                AnimatorControl.isP4Win = true;
                AnimatorControl.isP1Lose = true;
                AnimatorControl.isP2Lose = true;
                AnimatorControl.isP3Lose = true;
                StartCoroutine(GOEndScene());
            }
        }
    }
    IEnumerator GOEndScene()
    {
        systemTest.text = "ß[‘ò½YÊø£¡";
        SystemTestTextControl.isTimer = true;
        CameraMoveControl.isChangeCameraPoint = true;
        yield return new WaitForSeconds(3f);
        SceneManager.LoadScene(8);
        isEnd = true;
        FalseByAnimator();
        CameraMoveControl.isChangeCameraPoint = false;
    }
    void FalseByAnimator()
    {
        AnimatorControl.isP1Win = false;
        AnimatorControl.isP2Win = false;
        AnimatorControl.isP3Win = false;
        AnimatorControl.isP4Win = false;
        AnimatorControl.isP1Lose = false;
        AnimatorControl.isP2Lose = false;
        AnimatorControl.isP3Lose = false;
        AnimatorControl.isP4Lose = false;
    }
}
