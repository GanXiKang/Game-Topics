using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Menu_ChoosePlayer : MonoBehaviour
{
    public static float whoPlay, p, chooseP = 1;
    public static bool confirm,cancel;

    public Image[] P1_animals = new Image[4];
    public Image[] P2_animals = new Image[4];
    public Image[] P3_animals = new Image[4];
    public Image[] P4_animals = new Image[4];
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
                confirm =
            }
            if (chooseP == 2)
            {

            }
            if (chooseP == 3)
            {

            }
            if (chooseP == 4)
            {

            }
        }
    }
}
