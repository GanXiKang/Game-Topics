using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Menu_ChoosePlayer : MonoBehaviour
{
    public static float whoPlay, p, chooseP;

    void Update()
    {
        if (p < 1)
        {
            p = 4;
        }
        if (p > 4)
        {
            p = 1;
        }
    }
}
