using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MG4_EndControl : MonoBehaviour
{
    float arriveEnd = 0;
    bool win, clap = true;

    public GameObject gameWinUI, gameLoseUI, camera1, camera2;
    public AudioSource BGM;
    public AudioClip end, gameWin, gameLose, rewards;

    public static bool winPlayer, losePlayer, move;

    void Update()
    {
        if (arriveEnd == 1)
        {
            if (clap)
            {
                clap = false;
                BGM.PlayOneShot(rewards);
            }
            camera1.SetActive(true);
        }
        if (arriveEnd == 2)
        {
            MG4_RoadBlockControl.combo = 0;
            MG4_UIControl.isStart = false;
            move = true;
            camera1.SetActive(false);
            camera2.SetActive(true);

            if (win)
            {
                gameWinUI.SetActive(true);
                BGM.PlayOneShot(gameWin);
                winPlayer = true;
            }
            else 
            {
                gameLoseUI.SetActive(false);
                BGM.PlayOneShot(gameLose);
                losePlayer = true;
            }
            StartCoroutine(BackMainGame());
        }
    }
    private void OnTriggerEnter(Collider other)
    {                                           //判斷誰最后到
        if (other.tag == "Player")              
        {
            win = false;                        //AI先到終點
            arriveEnd++;
            BGM.PlayOneShot(end);
        }
        if (other.tag == "AI")
        {
            win = true;                         //Player先到終點
            arriveEnd++;
            BGM.PlayOneShot(end);
        }
    }
    IEnumerator BackMainGame()
    {
        yield return new WaitForSeconds(5f);
        SceneManager.LoadScene(7);
        winPlayer = false;
        losePlayer = false;
        move = false;
    }
}
