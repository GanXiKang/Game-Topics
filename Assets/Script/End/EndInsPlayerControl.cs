using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EndInsPlayerControl : MonoBehaviour
{
    AudioSource audio;

    public GameObject[] point = new GameObject[4];
    public GameObject[] animals = new GameObject[12];
    public GameObject[] animalsWin = new GameObject[12];

    public static bool isGameSceneDestroy = false;

    bool isLose1, isLose2;

    void Start()
    {
        audio = GetComponent<AudioSource>();
        audio.volume = Menu_VolumeSetting.VolumeBGM;

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
            for (int i = 1; i <= animals.Length; i++)
            {
                if (Menu_ChoosePlayer.whyP1 == i)
                {
                    Instantiate(animalsWin[i - 1], point[0].transform.position, point[0].transform.rotation);
                }
            }
        }
        else if (GameEndControl.whoWin == 2)
        {
            for (int i = 1; i <= animals.Length; i++)
            {
                if (Menu_ChoosePlayer.whyP2 == i)
                {
                    Instantiate(animalsWin[i - 1], point[0].transform.position, point[0].transform.rotation);
                }
            }
        }
        else if (GameEndControl.whoWin == 3)
        {
            for (int i = 1; i <= animals.Length; i++)
            {
                if (Menu_ChoosePlayer.whyP3 == i)
                {
                    Instantiate(animalsWin[i - 1], point[0].transform.position, point[0].transform.rotation);
                }
            }
        }
        else if (GameEndControl.whoWin == 4)
        {
            for (int i = 1; i <= animals.Length; i++)
            {
                if (Menu_ChoosePlayer.whyP4 == i)
                {
                    Instantiate(animalsWin[i - 1], point[0].transform.position, point[0].transform.rotation);
                }
            }
        }
    }
    void insLosePlayer1()
    {
        if (GameEndControl.whoWin != 1)
        {
            for (int i = 1; i <= animals.Length; i++)
            {
                if (Menu_ChoosePlayer.whyP1 == i)
                {
                    Instantiate(animals[i - 1], point[1].transform.position, point[1].transform.rotation);
                }
            }
        }
        else if (GameEndControl.whoWin != 2)
        {
            isLose1 = true;
            for (int i = 1; i <= animals.Length; i++)
            {
                if (Menu_ChoosePlayer.whyP2 == i)
                {
                    Instantiate(animals[i - 1], point[1].transform.position, point[1].transform.rotation);
                }
            }
        }
    }
    void insLosePlayer2()
    {
        if (GameEndControl.whoWin != 2 && !isLose1)
        {
            for (int i = 1; i <= animals.Length; i++)
            {
                if (Menu_ChoosePlayer.whyP2 == i)
                {
                    Instantiate(animals[i - 1], point[2].transform.position, point[2].transform.rotation);
                }
            }
        }
        else if (GameEndControl.whoWin != 3)
        {
            isLose2 = true;
            for (int i = 1; i <= animals.Length; i++)
            {
                if (Menu_ChoosePlayer.whyP3 == i)
                {
                    Instantiate(animals[i - 1], point[2].transform.position, point[2].transform.rotation);
                }
            }
        }
    }
    void insLosePlayer3()
    {
        if (GameEndControl.whoWin != 3 && !isLose2)
        {
            for (int i = 1; i <= animals.Length; i++)
            {
                if (Menu_ChoosePlayer.whyP3 == i)
                {
                    Instantiate(animals[i - 1], point[3].transform.position, point[3].transform.rotation);
                }
            }
        }
        else if (GameEndControl.whoWin != 4)
        {
            for (int i = 1; i <= animals.Length; i++)
            {
                if (Menu_ChoosePlayer.whyP4 == i)
                {
                    Instantiate(animals[i - 1], point[3].transform.position, point[3].transform.rotation);
                }
            }
        }
    }
    IEnumerator EndGameTime()
    {
        isGameSceneDestroy = true;
        DataManagement();
        yield return new WaitForSeconds(15f);
        isGameSceneDestroy = false;
        SceneManager.LoadScene(0);
    }

    void DataManagement()
    {
        OrdinaryColliderControl.P1_Enter = true;
        OrdinaryColliderControl.P2_Enter = true;
        OrdinaryColliderControl.P3_Enter = true;
        OrdinaryColliderControl.P4_Enter = true;
        StoreColliderControl.P1_EnterStore = true;
        StoreColliderControl.P2_EnterStore = true;
        StoreColliderControl.P3_EnterStore = true;
        StoreColliderControl.P4_EnterStore = true;
    }
}

