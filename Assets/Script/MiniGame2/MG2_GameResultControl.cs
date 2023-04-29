using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MG2_GameResultControl : MonoBehaviour
{
    Animator ani;
    void Start()
    {
        ani = GetComponent<Animator>();
    }
    void Update()
    {
        if (MG2_UIControl.gameTime <= 0)
        {
            if (MG2_CollectScoreControl.score >= 30)
            {
                print("Win");
                ani.SetBool("Walk", false);
                ani.SetBool("Win", true);
            }
            else 
            {
                print("Lose");
                ani.SetBool("Walk", false);
                ani.SetBool("Lose", true);
            }
            StartCoroutine(BackMainGame());
        }
    }
    IEnumerator BackMainGame()
    {
        yield return new WaitForSeconds(2f);
        SceneManager.LoadScene(0);
        MG2_StartButtonControl.isStart = false;
        MG2_CollectScoreControl.score = 0;
        MG2_UIControl.gameTime = 45;
    }
}
