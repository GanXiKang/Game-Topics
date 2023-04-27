using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Menu_ChoosePlayer : MonoBehaviour
{
    public static float whoPlay;

    public GameObject[] P1_animals = new GameObject[4];
    public GameObject[] P2_animals = new GameObject[4];
    public GameObject[] P3_animals = new GameObject[4];
    public GameObject[] P4_animals = new GameObject[4];
    public GameObject[] OK = new GameObject[4];
    public GameObject[] NO = new GameObject[4];

    float p;
    bool confirm;

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
    public void OK_1p()
    {
        confirm = true;
    }
    public void Cancel_1p()
    {
       cancel = false;
    }
    public void Left_1p()
    {
        p--;
    }
    public void B_Right_1p()
    {
       p++;
    }
}
