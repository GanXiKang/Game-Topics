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

    bool throwMusia = true, receiveMusia = true, moveMusia = true ;
    public void Button_Start()
    {
        startUI.SetActive(false);
        isStart = true;
        BGM.PlayOneShot(button);
    }
    void Update()
    {
        if (isStart)
        {
            if (gameTime >= 0)
            {
                gameTime -= 1 * Time.deltaTime;
                timer.text = "Time:" + gameTime.ToString("f0") + "s";

                if (MG5_HookControl.isFishing && throwMusia)
                {
                    BGM.PlayOneShot(throwM);
                    throwMusia = false;
                }
                if (MG5_HookControl.isFishing == false && throwMusia == false)
                {
                    throwMusia = true;
                }
                if (MG5_HookControl.takeBack && receiveMusia)
                {
                    BGM.PlayOneShot(receiveM);
                    receiveMusia = false;
                }
                if (MG5_HookControl.takeBack == false && receiveMusia == false)
                {
                    receiveMusia = true;
                }
                if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.LeftArrow) || Input.GetKey(KeyCode.RightArrow))
                {
                    if (moveMusia)
                    {
                        BGM.PlayOneShot(move);
                        moveMusia = false;
                    }
                }
                else
                {
                    moveMusia = true;
                }
            }
            score.text = "Score:" + MG5_HookControl.score;
        }
    }
}
