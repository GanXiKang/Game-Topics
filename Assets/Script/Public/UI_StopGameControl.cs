using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UI_StopGameControl : MonoBehaviour
{
    public GameObject stopGameUI;
    void Start()
    {
        stopGameUI.SetActive(false);
    }
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Time.timeScale = 0f;
            stopGameUI.SetActive(true);
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
