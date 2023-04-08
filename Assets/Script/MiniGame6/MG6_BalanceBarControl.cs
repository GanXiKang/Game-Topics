using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MG6_BalanceBarControl : MonoBehaviour
{
    public Image power;

    float timer, value = 0;
    bool isJudgment, isAdd = false;

    void Update()
    {
        if (value <= 0)
        {
            value = 0;
        }
        if (value >= 8)
        {
            value = 8;
        }
        if (Input.GetMouseButton(0))
        {
            isAdd = true;
        }
        if (Input.GetMouseButtonUp(0))
        {
            isAdd = false;
        }
        power.rectTransform.localScale = new Vector3(value, 0.5f, 1);
    }
    void FixedUpdate()
    {
        if (isAdd == true)
        {
            value += 0.2f;
        }
        else
        {
            value -= 0.5f;
        }

        Judgment();
        GameControl();
    }
    void Judgment()
    {
        if (value >= 2 && value <= 6)
        {
            isJudgment = true;
        }
        else
        {
            isJudgment = false;
        }
    }
    void GameControl()
    {
        timer += Time.deltaTime;
        if (isJudgment == false)
        {
            if (timer > 3)
            {
                print("GameOver");
            }
        }
        else 
        {
            timer = 0;
        }
    }
}
