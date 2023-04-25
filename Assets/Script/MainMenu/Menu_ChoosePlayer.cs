using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Menu_ChoosePlayer : MonoBehaviour
{
    public static float whoPlay, p = 0, chooseP = 1;
    public static bool confirm, cancel;

    public GameObject[] P1_animals = new GameObject[4];
    public GameObject[] P2_animals = new GameObject[4];
    public GameObject[] P3_animals = new GameObject[4];
    public GameObject[] P4_animals = new GameObject[4];
    public GameObject[] OK = new GameObject[4];
    public GameObject[] NO = new GameObject[4];

    void FixedUpdate()
    {
        if (chooseP > whoPlay)
        {
            chooseP = whoPlay;
        }

        if (p < 1)
        {
            p = 4;
        }
        if (p > 4)
        {
            p = 1;
        }

        if (chooseP == 1)
        {
            if (p == 1)
            {
                P1_animals[0].SetActive(true);
            }
            if (p == 2)
            {
                P1_animals[0].SetActive(false);
                P1_animals[1].SetActive(true);
            }
            if (p == 3)
            {
                P1_animals[1].SetActive(false);
                P1_animals[2].SetActive(true);
            }
            if (p == 4)
            {
                P1_animals[2].SetActive(false);
                P1_animals[3].SetActive(true);
            }
        }
        if (chooseP == 2)
        {
            if (p == 1)
            {
                P2_animals[0].SetActive(true);
            }
            if (p == 2)
            {
                P2_animals[0].SetActive(false);
                P2_animals[1].SetActive(true);
            }
            if (p == 3)
            {
                P2_animals[1].SetActive(false);
                P2_animals[2].SetActive(true);
            }
            if (p == 4)
            {
                P2_animals[2].SetActive(false);
                P2_animals[3].SetActive(true);
            }
        }
        if (chooseP == 3)
        {
            if (p == 1)
            {
                P3_animals[0].SetActive(true);
            }
            if (p == 2)
            {
                P3_animals[0].SetActive(false);
                P3_animals[1].SetActive(true);
            }
            if (p == 3)
            {
                P3_animals[1].SetActive(false);
                P3_animals[2].SetActive(true);
            }
            if (p == 4)
            {
                P3_animals[2].SetActive(false);
                P3_animals[3].SetActive(true);
            }
        }
        if (chooseP == 4)
        {
            if (p == 1)
            {
                P4_animals[0].SetActive(true);
            }
            if (p == 2)
            {
                P4_animals[0].SetActive(false);
                P4_animals[1].SetActive(true);
            }
            if (p == 3)
            {
                P4_animals[1].SetActive(false);
                P4_animals[2].SetActive(true);
            }
            if (p == 4)
            {
                P4_animals[2].SetActive(false);
                P4_animals[3].SetActive(true);
            }
        }

        if (confirm == true)
        {
            if (chooseP == 1)
            {
                chooseP++;
                p = 0;
                confirm = false;
            }
            if (chooseP == 2)
            {
                chooseP++;
                p = 0;
                confirm = false;
            }
            if (chooseP == 3)
            {
                chooseP++;
                p = 0;
                confirm = false;
            }
            if (chooseP == 4)
            {
                confirm = false;
            }
        }
        if (cancel == true)
        {
            if (chooseP == 1)
            {
                cancel = false;
            }
            if (chooseP == 2)
            {
                cancel = false;
            }
            if (chooseP == 3)
            {
                cancel = false;
            }
            if (chooseP == 4)
            {
                cancel = false;
            }
        }
    }
}
