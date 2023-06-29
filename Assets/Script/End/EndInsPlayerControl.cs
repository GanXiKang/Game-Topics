using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EndInsPlayerControl : MonoBehaviour
{
    public GameObject[] point = new GameObject[4];
    public GameObject[] animals = new GameObject[4];

    bool isLose1, isLose2;
    void Start()
    {
        StartCoroutine(EndGameTime());
        insWinPlayer();
        insLosePlayer1();
        insLosePlayer2();
        insLosePlayer3();
    }
    void insWinPlayer()
    {
        if (GameEndControl.whoWin == 1)
        {
            if (Menu_ChoosePlayer.whyP1 == 1)
            {
                Instantiate(animals[0], point[0].transform.position, point[0].transform.rotation);
            }
            else if (Menu_ChoosePlayer.whyP1 == 2)
            {
                Instantiate(animals[1], point[0].transform.position, point[0].transform.rotation);
            }
            else if (Menu_ChoosePlayer.whyP1 == 3)
            {
                Instantiate(animals[2], point[0].transform.position, point[0].transform.rotation);
            }
            else if (Menu_ChoosePlayer.whyP1 == 4)
            {
                Instantiate(animals[3], point[0].transform.position, point[0].transform.rotation);
            }
        }
        if (GameEndControl.whoWin == 2)
        {
            if (Menu_ChoosePlayer.whyP2 == 1)
            {
                Instantiate(animals[0], point[0].transform.position, point[0].transform.rotation);
            }
            else if (Menu_ChoosePlayer.whyP2 == 2)
            {
                Instantiate(animals[1], point[0].transform.position, point[0].transform.rotation);
            }
            else if (Menu_ChoosePlayer.whyP2 == 3)
            {
                Instantiate(animals[2], point[0].transform.position, point[0].transform.rotation);
            }
            else if (Menu_ChoosePlayer.whyP2 == 4)
            {
                Instantiate(animals[3], point[0].transform.position, point[0].transform.rotation);
            }
        }
        if (GameEndControl.whoWin == 3)
        {
            if (Menu_ChoosePlayer.whyP3 == 1)
            {
                Instantiate(animals[0], point[0].transform.position, point[0].transform.rotation);
            }
            else if (Menu_ChoosePlayer.whyP3 == 2)
            {
                Instantiate(animals[1], point[0].transform.position, point[0].transform.rotation);
            }
            else if (Menu_ChoosePlayer.whyP3 == 3)
            {
                Instantiate(animals[2], point[0].transform.position, point[0].transform.rotation);
            }
            else if (Menu_ChoosePlayer.whyP3 == 4)
            {
                Instantiate(animals[3], point[0].transform.position, point[0].transform.rotation);
            }
        }
        if (GameEndControl.whoWin == 4)
        {
            if (Menu_ChoosePlayer.whyP4 == 1)
            {
                Instantiate(animals[0], point[0].transform.position, point[0].transform.rotation);
            }
            else if (Menu_ChoosePlayer.whyP4 == 2)
            {
                Instantiate(animals[1], point[0].transform.position, point[0].transform.rotation);
            }
            else if (Menu_ChoosePlayer.whyP4 == 3)
            {
                Instantiate(animals[2], point[0].transform.position, point[0].transform.rotation);
            }
            else if (Menu_ChoosePlayer.whyP4 == 4)
            {
                Instantiate(animals[3], point[0].transform.position, point[0].transform.rotation);
            }
        }
    }
    void insLosePlayer1()
    {
        if (GameEndControl.whoWin != 1)
        {
            if (Menu_ChoosePlayer.whyP1 == 1)
            {
                Instantiate(animals[0], point[1].transform.position, point[1].transform.rotation);
            }
            else if (Menu_ChoosePlayer.whyP1 == 2)
            {
                Instantiate(animals[1], point[1].transform.position, point[1].transform.rotation);
            }
            else if (Menu_ChoosePlayer.whyP1 == 3)
            {
                Instantiate(animals[2], point[1].transform.position, point[1].transform.rotation);
            }
            else if (Menu_ChoosePlayer.whyP1 == 4)
            {
                Instantiate(animals[3], point[1].transform.position, point[1].transform.rotation);
            }
        }
        else if (GameEndControl.whoWin != 2)
        {
            isLose1 = true;
            if (Menu_ChoosePlayer.whyP2 == 1)
            {
                Instantiate(animals[0], point[1].transform.position, point[1].transform.rotation);
            }
            else if (Menu_ChoosePlayer.whyP2 == 2)
            {
                Instantiate(animals[1], point[1].transform.position, point[1].transform.rotation);
            }
            else if (Menu_ChoosePlayer.whyP2 == 3)
            {
                Instantiate(animals[2], point[1].transform.position, point[1].transform.rotation);
            }
            else if (Menu_ChoosePlayer.whyP2 == 4)
            {
                Instantiate(animals[3], point[1].transform.position, point[1].transform.rotation);
            }
        }
    }
    void insLosePlayer2()
    {
        if (GameEndControl.whoWin != 2 && !isLose1)
        {
            if (Menu_ChoosePlayer.whyP2 == 1)
            {
                Instantiate(animals[0], point[2].transform.position, point[2].transform.rotation);
            }
            else if (Menu_ChoosePlayer.whyP2 == 2)
            {
                Instantiate(animals[1], point[2].transform.position, point[2].transform.rotation);
            }
            else if (Menu_ChoosePlayer.whyP2 == 3)
            {
                Instantiate(animals[2], point[2].transform.position, point[2].transform.rotation);
            }
            else if (Menu_ChoosePlayer.whyP2 == 4)
            {
                Instantiate(animals[3], point[2].transform.position, point[2].transform.rotation);
            }
        }
        else if (GameEndControl.whoWin != 3)
        {
            isLose2 = true;
            if (Menu_ChoosePlayer.whyP3 == 1)
            {
                Instantiate(animals[0], point[2].transform.position, point[2].transform.rotation);
            }
            else if (Menu_ChoosePlayer.whyP3 == 2)
            {
                Instantiate(animals[1], point[2].transform.position, point[2].transform.rotation);
            }
            else if (Menu_ChoosePlayer.whyP3 == 3)
            {
                Instantiate(animals[2], point[2].transform.position, point[2].transform.rotation);
            }
            else if (Menu_ChoosePlayer.whyP3 == 4)
            {
                Instantiate(animals[3], point[2].transform.position, point[2].transform.rotation);
            }
        }
    }
    void insLosePlayer3()
    {
        if (GameEndControl.whoWin != 3 && !isLose2)
        {
            if (Menu_ChoosePlayer.whyP3 == 1)
            {
                Instantiate(animals[0], point[3].transform.position, point[3].transform.rotation);
            }
            else if (Menu_ChoosePlayer.whyP3 == 2)
            {
                Instantiate(animals[1], point[3].transform.position, point[3].transform.rotation);
            }
            else if (Menu_ChoosePlayer.whyP3 == 3)
            {
                Instantiate(animals[2], point[3].transform.position, point[3].transform.rotation);
            }
            else if (Menu_ChoosePlayer.whyP3 == 4)
            {
                Instantiate(animals[3], point[3].transform.position, point[3].transform.rotation);
            }
        }
        else if (GameEndControl.whoWin != 4)
        {
            if (Menu_ChoosePlayer.whyP4 == 1)
            {
                Instantiate(animals[0], point[3].transform.position, point[3].transform.rotation);
            }
            else if (Menu_ChoosePlayer.whyP4 == 2)
            {
                Instantiate(animals[1], point[3].transform.position, point[3].transform.rotation);
            }
            else if (Menu_ChoosePlayer.whyP4 == 3)
            {
                Instantiate(animals[2], point[3].transform.position, point[3].transform.rotation);
            }
            else if (Menu_ChoosePlayer.whyP4 == 4)
            {
                Instantiate(animals[3], point[3].transform.position, point[3].transform.rotation);
            }
        }
    }
    IEnumerator EndGameTime()
    {
        yield return new WaitForSeconds(7f);
        SceneManager.LoadScene(0);
    }
}

