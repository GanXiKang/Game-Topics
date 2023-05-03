using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MG2_GameResultControl : MonoBehaviour
{
    Animator ani;

    public GameObject gameWinUI, gameLoseUI;
    public AudioSource BGM;
    public AudioClip gameWin, gameLose, goodApple, badApple;

    void Start()
    {
        ani = GetComponent<Animator>();
    }
    void Update()
    {
        if (MG2_CollectScoreControl.goodA)
        {
            BGM.PlayOneShot(goodApple);
            MG2_CollectScoreControl.goodA = false;
        }
        if (MG2_CollectScoreControl.badA)
        {
            BGM.PlayOneShot(badApple);
            MG2_CollectScoreControl.badA = false;
        }

        if (MG2_UIControl.gameTime <= 0)
        {
            if (MG2_CollectScoreControl.score >= 30)
            {
                ani.SetBool("Basket", false);
                ani.SetBool("Win", true);
                BGM.PlayOneShot(gameWin);
            }
            else 
            {
                ani.SetBool("Basket", false);
                ani.SetBool("Lose", true);
                BGM.PlayOneShot(gameLose);
            }
            StartCoroutine(BackMainGame());
        }
    }
    IEnumerator BackMainGame()
    {
        yield return new WaitForSeconds(5f);
        SceneManager.LoadScene(7);
        MG2_StartButtonControl.isStart = false;
        MG2_CollectScoreControl.score = 0;
        MG2_UIControl.gameTime = 45;
    }
}
