using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MG5_UIControl : MonoBehaviour
{
    public GameObject startUI;
    public Text timer, score;
    public AudioSource BGM;
    public AudioClip button, throwM, receiveM, move;

    public static float gameTime = 45f;
    public static bool isStart = false;

    public void Button_Start()
    {
        startUI.SetActive(false);
        isStart = true;
        BGM.PlayOneShot(button);
    }
    void Update()
    {
        if (gameTime >= 0)
        {
            gameTime -= 1 * Time.deltaTime;
            timer.text = "Time:" + gameTime.ToString("f0") + "s";

            if (MG5_PlayerMoveControl.throwMusia)
            {
                BGM.PlayOneShot(throwM);
                MG5_PlayerMoveControl.throwMusia = false;
            }
            if (MG5_PlayerMoveControl.receiveMusia)
            {
                BGM.PlayOneShot(receiveM);
                MG5_PlayerMoveControl.receiveMusia = false;
            }
            if (MG5_PlayerMoveControl.moveMusia)
            {
                BGM.PlayOneShot(move);
                MG5_PlayerMoveControl.moveMusia = false;
            }
        }

        score.text = "Score:" + MG5_HookControl.score;
    }
}
