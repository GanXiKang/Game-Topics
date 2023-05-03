using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MG6_BalanceBarControl : MonoBehaviour
{
    public GameObject balanceBar;
    public GameObject[] gameLoseUI = new GameObject[4];
    public Image power;
    public AudioSource BGM;
    public AudioClip gameLose, drowing;

    float timer, value = 0;
    bool isJudgment, isAdd = false;

    public static bool gameover;

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

        if (MG6_UIControl.isStart)
        {
            if (Input.GetMouseButton(0))
            {
                isAdd = true;
            }
            if (Input.GetMouseButtonUp(0))
            {
                isAdd = false;
            }
            power.rectTransform.localScale = new Vector3(value, 0.5f, 1);

            if (MG6_EndControl.back == true)
            {
                balanceBar.SetActive(false);
            }
            if (gameover) 
            {
                StartCoroutine(GameOver());
            }
        }
    }
    void FixedUpdate()
    {
        if (MG6_UIControl.isStart)
        {
            if (isAdd == true)
            {
                value += 0.2f;
            }
            else
            {
                value -= 0.5f;
            }
        }
        Judgment();
        GameControl();
    }
    void Judgment()
    {
        switch(MG6_PlayerMoveControl.j)
        {
            case 1:
                if (value >= 2 && value <= 6)
                {
                    isJudgment = true;
                    power.color = Color.yellow;
                }
                else
                {
                    isJudgment = false;
                    power.color = Color.red;
                }
                break;

            case 2:
                if (value >= 1 && value <= 4.5f)
                {
                    isJudgment = true;
                    power.color = Color.yellow;
                }
                else
                {
                    isJudgment = false;
                    power.color = Color.red;
                }
                break;

            case 3:
                if (value >= 5 && value <= 8)
                {
                    isJudgment = true;
                    power.color = Color.yellow;
                }
                else
                {
                    isJudgment = false;
                    power.color = Color.red;
                }
                break;

            case 4:
                if (value >= 3.5f && value <= 4.5f)
                {
                    isJudgment = true;
                    power.color = Color.yellow;
                }
                else
                {
                    isJudgment = false;
                    power.color = Color.red;
                }
                break;

            case 5:
                if (value >= 0.5f && value <= 3)
                {
                    isJudgment = true;
                    power.color = Color.yellow;
                }
                else
                {
                    isJudgment = false;
                    power.color = Color.red;
                }
                break;

            case 6:
                if (value >= 6 && value <= 7.5f)
                {
                    isJudgment = true;
                    power.color = Color.yellow;
                }
                else
                {
                    isJudgment = false;
                    power.color = Color.red;
                }
                break;
        }
    }
    void GameControl()
    {
        if (MG6_UIControl.isStart)
        {
            timer += Time.deltaTime;
            if (isJudgment == false)
            {
                if (timer > 2f)
                {
                    gameover = true;
                    BGM.PlayOneShot(drowing);
                }
            }
            else
            {
                timer = 0;
            }
        }
    }
    IEnumerator GameOver()
    {
        yield return new WaitForSeconds(2f);
        if (MG1_BoxColliderControl.p == 1)
        {
            gameLoseUI[0].SetActive(true);
        }
        else if (MG1_BoxColliderControl.p == 2)
        {
            gameLoseUI[1].SetActive(true);
        }
        else if (MG1_BoxColliderControl.p == 3)
        {
            gameLoseUI[2].SetActive(true);
        }
        else if (MG1_BoxColliderControl.p == 4)
        {
            gameLoseUI[3].SetActive(true);
        }
        BGM.PlayOneShot(gameLose);
    }
}
