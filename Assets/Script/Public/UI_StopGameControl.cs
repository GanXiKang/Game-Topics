using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UI_StopGameControl : MonoBehaviour
{
    GameObject stopGameUI, miniGameUI, OperateUI;

    bool isFind, isOperate, isCloseDiceUI;

    void Start()
    {
        stopGameUI = GameObject.Find("StopGameUI");
        OperateUI = GameObject.Find("OperateUI");
       
        stopGameUI.SetActive(false);
        isOperate = false;
    }
    void Update()
    {
        OperateUI.SetActive(isOperate);

        if (MiniGameColliderControl.isMiniGame || DiceUIControl.isDiceScene)
        {
            if (isFind)
            {
                miniGameUI = GameObject.Find("MGUI");
                isFind = false;
            }

            if (Input.GetKeyDown(KeyCode.Escape))
            {
                Time.timeScale = 0f;
                miniGameUI.SetActive(false);
                stopGameUI.SetActive(true);
            }
        }
        else 
        {
            isFind = true;

            if (Input.GetKeyDown(KeyCode.Escape))
            {
                Time.timeScale = 0f;
                if (DiceUIControl.isDiceUI)
                {
                    DiceUIControl.isDiceUI = false;
                    isCloseDiceUI = true;
                }
                stopGameUI.SetActive(true);
            }
        }
    }

    public void ContinueGame()
    {
        Time.timeScale = 1f;
        stopGameUI.SetActive(false);
        isOperate = false;
        if (MiniGameColliderControl.isMiniGame || DiceUIControl.isDiceScene)
        {
            miniGameUI.SetActive(true);
        }
        if (isCloseDiceUI)
        {
            DiceUIControl.isDiceUI = true;
            isCloseDiceUI = false;
        }
    }
    public void BackToMenu()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene(0);
        stopGameUI.SetActive(false);
        isOperate = false;
    }
    public void Operate()
    {
        isOperate = !isOperate;
    }
}
