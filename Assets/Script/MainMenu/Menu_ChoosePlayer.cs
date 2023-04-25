using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Menu_ChoosePlayer : MonoBehaviour
{
    public static float whoPlay, p, chooseP = 1;
    public static bool confirm, cancel;

    public Image[] P1_animals = new Image[4];
    public Image[] P2_animals = new Image[4];
    public Image[] P3_animals = new Image[4];
    public Image[] P4_animals = new Image[4];
    public Image[] OK = new Image[4];
    public Image[] NO = new Image[4];

    void Update()
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

        if (confirm == true)
        {
            if (chooseP == 1)
            {
                chooseP++;
                confirm = false;
            }
            if (chooseP == 2)
            {
                chooseP++;
                confirm = false;
            }
            if (chooseP == 3)
            {
                chooseP++;
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
