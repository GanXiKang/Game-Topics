using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UI_StopGameControl : MonoBehaviour
{
    public GameObject stopGameUI;

    bool isSettingClose = false;

    void Start()
    {
        stopGameUI.SetActive(false);
    }
    void Update()
    {
        //BackToMainGame();
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Time.timeScale = 0f;
            stopGameUI.SetActive(true);
        }
    }
    void BackToMainGame()
    {
        if (!MiniGameColliderControl.isMiniGame || !Dice.isDiceScene)
        {
            if (isSettingClose)
            {
                stopGameUI.SetActive(false);
                isSettingClose = false;
            }
        }
        else
        {
            isSettingClose = true;
        }
    }
    public void ContinueGame()
    {
        Time.timeScale = 1f;
        stopGameUI.SetActive(false);
    }
    public void BackToMenu()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene(0);
        stopGameUI.SetActive(false);
    }
}
