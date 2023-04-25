using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Menu_ChoosePlayer : MonoBehaviour
{
    public static float whoPlay, p, chooseP = 1;
    public static bool confirm;

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
