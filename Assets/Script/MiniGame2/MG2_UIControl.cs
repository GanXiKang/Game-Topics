using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MG2_UIControl : MonoBehaviour
{
    public Image time;
    public Text Score;
    public GameObject teach;

    public static float timer = 0;
    float t, gameTime = 45;

    void Update()
    {
        if (MG2_StartButtonControl.isStart)
        {
            if (Input.GetKeyDown(KeyCode.A) || Input.GetKeyDown(KeyCode.D) || Input.GetKeyDown(KeyCode.LeftArrow) || Input.GetKeyDown(KeyCode.RightArrow))
            {
                teach.SetActive(false);
            }

            if (timer != gameTime)
            {
                timer += 1 * Time.deltaTime;
                t = timer / gameTime;
                time.fillAmount = 1 - t;

                if (timer > gameTime - 10)
                {
                    time.color = Color.red;
                }
                else
                {
                    time.color = Color.green;
                }
            }
            
            Score.text = "Score : " + MG2_CollectScoreControl.score.ToString();
        }
    }
}
