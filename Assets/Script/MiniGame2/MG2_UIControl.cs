using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MG2_UIControl : MonoBehaviour
{
    public Image time;
    public Text Score;
    public GameObject teach;

    public static float gameTime = 45f;

    float t, timer;

    void Update()
    {
        if (MG2_StartButtonControl.isStart)
        {
            if (Input.GetKeyDown(KeyCode.A) || Input.GetKeyDown(KeyCode.D) || Input.GetKeyDown(KeyCode.LeftArrow) || Input.GetKeyDown(KeyCode.RightArrow))
            {
                teach.SetActive(false);
            }

            if (gameTime >= 0)
            {
                gameTime -= 1 * Time.deltaTime;
                
            }
            Score.text = "Score : " + MG2_CollectScoreControl.score.ToString();
        }
    }
}
