using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MG3_StarControl : MonoBehaviour
{
    public GameObject star, gameWinUI, gameLoseUI;
    public Transform insPoint1, insPoint2, insPoint3;
    public AudioSource BGM;
    public AudioClip gameWin, gameLose, starCup, notStarCup;

    public static bool insStar;
    public static float win;
    float x, result;

    void Update()
    {
        if (MG3_ButtonControl.round <= 3)
        {
            if (insStar == true)
            {
                x = Random.Range(1, 4);
                switch (x)
                {
                    case 1:
                        Instantiate(star, insPoint1.transform.position, insPoint1.transform.rotation);
                        break;
                    case 2:
                        Instantiate(star, insPoint2.transform.position, insPoint2.transform.rotation);
                        break;
                    case 3:
                        Instantiate(star, insPoint3.transform.position, insPoint3.transform.rotation);
                        break;
                }
                insStar = false;
            }
            if (MG3_ButtonControl.openBox == true)
            {
                if (MG3_ButtonControl.openWhyBox == x)
                {
                    win++;
                    BGM.PlayOneShot(starCup);
                }
                else
                {
                    StartCoroutine(LoseRound());
                }
                result++;
                MG3_ButtonControl.openBox = false;
            }
        }
        if (result == 3)
        {
            if (win >= 2)
            {
                gameWinUI.SetActive(true);
                BGM.PlayOneShot(gameWin);
            }
            else
            {
                gameLoseUI.SetActive(true);
                BGM.PlayOneShot(gameLose);
            }
            StartCoroutine(BackMainGame());
        }
    }
    IEnumerator LoseRound()
    {
        BGM.PlayOneShot(notStarCup);
        yield return new WaitForSeconds(1f);
        if (x == 1)
        {
            MG3_BoxMoveControl.openBox1 = true;
        }
        else if (x == 2)
        {
            MG3_BoxMoveControl.openBox2 = true;
        }
        else if (x == 3)
        {
            MG3_BoxMoveControl.openBox3 = true;
        }
    }
    IEnumerator BackMainGame()
    {
        yield return new WaitForSeconds(5f);
        SceneManager.LoadScene(7);
        win = 0;
        MG3_ButtonControl.round = 0;
        MG3_ButtonControl.destoryStarNum = 0;
    }
}
