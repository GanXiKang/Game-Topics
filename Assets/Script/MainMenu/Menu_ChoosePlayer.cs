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
    public GameObject[] button = new GameObject[8];

    float p, confirm;

    void Limit()
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
    void Choose1P()
    {
        if (p == 1)
        {
            P1_animals[3].SetActive(false);
            P1_animals[0].SetActive(true);
            P1_animals[1].SetActive(false);
        }
        else if (p == 2)
        {
            P1_animals[0].SetActive(false);
            P1_animals[1].SetActive(true);
            P1_animals[2].SetActive(false);
        }
        else if (p == 3)
        {
            P1_animals[1].SetActive(false);
            P1_animals[2].SetActive(true);
            P1_animals[3].SetActive(false);
        }
        else if (p == 4)
        {
            P1_animals[2].SetActive(false);
            P1_animals[3].SetActive(true);
            P1_animals[0].SetActive(false);
        }
    }
    public void OK_1p()
    {
        confirm++;
        OK[0].SetActive(false);
        NO[0].SetActive(true);
        button[0].SetActive(false);
        button[1].SetActive(false);
    }
    public void Cancel_1p()
    {
        confirm--;
        OK[0].SetActive(true);
        NO[0].SetActive(false);
        button[0].SetActive(true);
        button[1].SetActive(true);
    }
    public void Left_1p()
    {
        p--;
        Limit();
        Choose1P();
    }
    public void Right_1p()
    {
       p++;

        Limit();
        Choose1P();
    }
}
