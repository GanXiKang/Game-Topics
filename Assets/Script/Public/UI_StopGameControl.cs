using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UI_StopGameControl : MonoBehaviour
{
    GameObject stopGameUI, MainGameUI, MiniGameUI;

    void Start()
    {
        MainGameUI = GameObject.Find("UI");
        stopGameUI = GameObject.Find("StopGameUI");
        stopGameUI.SetActive(false);
    }
    void Update()
    {
        if (MiniGameColliderControl.isMiniGame)
        {
            MiniGameUI = GameObject.Find("MGUI");

            if (Input.GetKeyDown(KeyCode.Escape))
            {
                Time.timeScale = 0f;
                MiniGameUI.SetActive(false);
                stopGameUI.SetActive(true);
            }
        }
        else 
        {
            if (Input.GetKeyDown(KeyCode.Escape))
            {
                Time.timeScale = 0f;
                MainGameUI.SetActive(false);
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
                MiniGameUI.SetActive(true);
        }
        else
        {
                MainGameUI.SetActive(true);
        }
    }
    public void BackToMenu()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene(0);
        stopGameUI.SetActive(false);
    }
}
