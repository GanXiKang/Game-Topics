using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UI_StopGameControl : MonoBehaviour
{
    GameObject stopGameUI, miniGameUI, OperateUI, doublePlaySpeed;

    public static bool isDoublePlaySpeed;

    bool isFind, isOperate, isCloseDiceUI;

    void Start()
    {
        stopGameUI = GameObject.Find("StopGameUI");
        OperateUI = GameObject.Find("OperateUI");
        doublePlaySpeed = GameObject.Find("DoublePlaySpeed");
       
        stopGameUI.SetActive(false);
        isOperate = false;
        isDoublePlaySpeed = false;
        PlaySpeed();
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

        if (Input.GetKeyDown(KeyCode.S))
        {
            isDoublePlaySpeed = !isDoublePlaySpeed;
            PlaySpeed();
        }
    }

    public void ContinueGame()
    {
        PlaySpeed();
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
        EndInsPlayerControl.isGameSceneDestroy = true;
        stopGameUI.SetActive(false);
        isOperate = false;
        DataManagement();
    }
    public void Operate()
    {
        isOperate = !isOperate;
    }

    void DataManagement()
    {
        OrdinaryColliderControl.P1_Enter = true;
        OrdinaryColliderControl.P2_Enter = true;
        OrdinaryColliderControl.P3_Enter = true;
        OrdinaryColliderControl.P4_Enter = true;

        ChestColliderControl.P1_EnterBox = true;
        ChestColliderControl.P2_EnterBox = true;
        ChestColliderControl.P3_EnterBox = true;
        ChestColliderControl.P4_EnterBox = true;

        StoreColliderControl.P1_EnterStore = true;
        StoreColliderControl.P2_EnterStore = true;
        StoreColliderControl.P3_EnterStore = true;
        StoreColliderControl.P4_EnterStore = true;

        MiniGameColliderControl.P1_playGame = true;
        MiniGameColliderControl.P2_playGame = true;
        MiniGameColliderControl.P3_playGame = true;
        MiniGameColliderControl.P4_playGame = true;
        MiniGameColliderControl.isMiniGame = false;

        EventControl.P1_EnterEvent = true;
        EventControl.P2_EnterEvent = true;
        EventControl.P3_EnterEvent = true;
        EventControl.P4_EnterEvent = true;
        EventControl.isStopP1 = false;
        EventControl.isStopP2 = false;
        EventControl.isStopP3 = false;
        EventControl.isStopP4 = false;
    }
    void PlaySpeed()
    {
        if (isDoublePlaySpeed)
        {
            Time.timeScale = 2f;
            doublePlaySpeed.SetActive(true);
        }
        else
        {
            Time.timeScale = 1f;
            doublePlaySpeed.SetActive(false);
        }
    }
}
