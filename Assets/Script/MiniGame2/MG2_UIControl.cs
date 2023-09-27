using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MG2_UIControl : MonoBehaviour
{
    public Image time;
    public Text Score;
    public GameObject teach;

    

    float t, timer, gameTime = 45f;

    void Update()
    {
        if (MG2_StartButtonControl.isStart)
        {
            if (Input.GetKeyDown(KeyCode.A) || Input.GetKeyDown(KeyCode.D) || Input.GetKeyDown(KeyCode.LeftArrow) || Input.GetKeyDown(KeyCode.RightArrow))
            {
                teach.SetActive(false);
            }

            timer += 1 * Time.deltaTime;
            t = timer / gameTime;
            
            Score.text = "Score : " + MG2_CollectScoreControl.score.ToString();
        }
    }
}
