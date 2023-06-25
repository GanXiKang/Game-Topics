using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndInsPlayerControl : MonoBehaviour
{
    public GameObject[] point = new GameObject[4];
    public GameObject[] animals = new GameObject[4];

    void Start()
    {
        insWinPlayer();
    }

    void Update()
    {
        
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
}
