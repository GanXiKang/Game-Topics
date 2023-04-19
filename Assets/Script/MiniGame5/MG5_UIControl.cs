using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MG5_UIControl : MonoBehaviour
{
    public Text timer, score;
    public static float gameTime = 45f;
    
    void Update()
    {
        if (gameTime >= 0)
        {
            gameTime -= 1 * Time.deltaTime;
            timer.text = "Time:" + gameTime.ToString("f0") + "s";
        }

        score.text = "Score:" + MG5_HookControl.score;
    }
}
