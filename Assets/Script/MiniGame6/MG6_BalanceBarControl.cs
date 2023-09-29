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
    bool isJudgment, isAdd = false, M1 = true, M2 = true;

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

            if (MG6_EndControl.back)
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
            if (isAdd)
            {
                value += 0.2f;
            }
            else
            {
                value -= 0.4f;
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
            if (!isJudgment && !MG6_EndControl.back)
            {
                if (timer > 2f)
                {
                    gameover = true;
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
        if (M1)
        {
            BGM.PlayOneShot(drowing);
            M1 = false;
        }
        yield return new WaitForSeconds(2f);

        if (MiniGameColliderControl.p == 1)
        {
            for (int i = 1; i <= gameLoseUI.Length; i++)
            {
                if (Menu_ChoosePlayer.whyP1 == i)
                {
                    gameLoseUI[i - 1].SetActive(true);
                }
            }
        }
        else if (MiniGameColliderControl.p == 2)
        {
            for (int i = 1; i <= gameLoseUI.Length; i++)
            {
                if (Menu_ChoosePlayer.whyP2 == i)
                {
                    gameLoseUI[i - 1].SetActive(true);
                }
            }
        }
        else if (MiniGameColliderControl.p == 3)
        {
            for (int i = 1; i <= gameLoseUI.Length; i++)
            {
                if (Menu_ChoosePlayer.whyP3 == i)
                {
                    gameLoseUI[i - 1].SetActive(true);
                }
            }
        }
        else if (MiniGameColliderControl.p == 4)
        {
            for (int i = 1; i <= gameLoseUI.Length; i++)
            {
                if (Menu_ChoosePlayer.whyP4 == i)
                {
                    gameLoseUI[i - 1].SetActive(true);
                }
            }
        }


        if (M2)
        {
            BGM.PlayOneShot(gameLose);
            M2 = false;
        }
    }
}
