using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MG5_GameResultControl : MonoBehaviour
{
    void Update()
    {
        if (MG5_UIControl.gameTime <= 0)
        {
            if (MG5_HookControl.score >= 15)
            {
                print("Win");
            }
            else
            {
                print("Lose");
            }
            StartCoroutine(BackMainGame());
        }
    }
    IEnumerator BackMainGame()
    {
        yield return new WaitForSeconds(2f);
        SceneManager.LoadScene(7);
        MG5_HookControl.score = 0;
        MG5_UIControl.gameTime = 45;
    }
}
