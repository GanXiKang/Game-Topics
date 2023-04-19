using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MG2_UIControl : MonoBehaviour
{
    public Text GameTime, Score;

    public static float gameTime = 45f;

    void Update()
    {
        if (MG2_StartButtonControl.isStart == true)
        {
            if (gameTime >= 0)
            {
                gameTime -= 1 * Time.deltaTime;
                GameTime.text = "Time : " + gameTime.ToString("f0") + "s";
            }
            Score.text = "Score : " + MG2_CollectScoreControl.score.ToString();
        }
    }
}
