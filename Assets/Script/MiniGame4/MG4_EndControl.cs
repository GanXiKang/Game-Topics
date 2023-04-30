using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MG4_EndControl : MonoBehaviour
{
    float arriveEnd = 0;
    bool win;
    public static bool winPlayer, losePlayer;

    void Update()
    {
        if (arriveEnd == 2)
        {
            if (win)
            {
                print("Win");
                winPlayer = true;
            }
            else 
            {
                print("Lose");
                losePlayer = true;
            }
            StartCoroutine(BackMainGame());
        }
    }
    private void OnTriggerEnter(Collider other)
    {                                           //�Д��l���
        if (other.tag == "Player")              
        {
            print("1");
            win = false;                        //AI�ȵ��K�c
            arriveEnd++;
        }
        if (other.tag == "AI")
        {
            print("2");
            win = true;                         //Player�ȵ��K�c
            arriveEnd++;
        }
    }
    IEnumerator BackMainGame()
    {
        yield return new WaitForSeconds(2f);
        SceneManager.LoadScene(0);
        winPlayer = false;
        losePlayer = false;
        MG4_UIControl.isStart = false;
        MG4_RoadBlockControl.combo = 0;
    }
}
