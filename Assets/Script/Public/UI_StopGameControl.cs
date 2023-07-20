using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UI_StopGameControl : MonoBehaviour
{
    GameObject stopGameUI, mainGameUI, miniGameUI;

    void Start()
    {
        mainGameUI = GameObject.Find("UI");
        stopGameUI = GameObject.Find("StopGameUI");
        stopGameUI.SetActive(false);
        print(stopGameUI);
        print(mainGameUI);
    }
    void Update()
    {
        if (MiniGameColliderControl.isMiniGame)
        {
            miniGameUI = GameObject.Find("MGUI");

            if (Input.GetKeyDown(KeyCode.Escape))
            {
                Time.timeScale = 0f;
                miniGameUI.SetActive(false);
                stopGameUI.SetActive(true);
            }
        }
        else 
        {
            if (Input.GetKeyDown(KeyCode.Escape))
            {
                Time.timeScale = 0f;
                mainGameUI.SetActive(false);
                stopGameUI.SetActive(true);
            }
        }
    }
    public void ContinueGame()
    {
        Time.timeScale = 1f;
        stopGameUI.SetActive(false);

        if (MiniGameColliderControl.isMiniGame)
        {
                miniGameUI.SetActive(true);
        }
        else
        {
                mainGameUI.SetActive(true);
        }
    }
    public void BackToMenu()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene(0);
        stopGameUI.SetActive(false);
    }
}
