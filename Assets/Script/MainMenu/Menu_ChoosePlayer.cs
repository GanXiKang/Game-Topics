using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

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
            P1_animals[0].SetActive(true);
            P1_animals[1].SetActive(false);
            P1_animals[2].SetActive(false);
            P1_animals[3].SetActive(false);
        }
        else if (p == 2)
        {
            P1_animals[0].SetActive(false);
            P1_animals[1].SetActive(true);
            P1_animals[2].SetActive(false);
            P1_animals[3].SetActive(false);
        }
        else if (p == 3)
        {
            P1_animals[0].SetActive(false);
            P1_animals[1].SetActive(false);
            P1_animals[2].SetActive(true);
            P1_animals[3].SetActive(false);
        }
        else if (p == 4)
        {
            P1_animals[0].SetActive(false);
            P1_animals[1].SetActive(false);
            P1_animals[2].SetActive(false);
            P1_animals[3].SetActive(true);
        }
    }
    void Choose2P()
    {
        if (p == 1)
        {
            P2_animals[0].SetActive(true);
            P2_animals[1].SetActive(false);
            P2_animals[2].SetActive(false);
            P2_animals[3].SetActive(false);
        }
        else if (p == 2)
        {
            P2_animals[0].SetActive(false);
            P2_animals[1].SetActive(true);
            P2_animals[2].SetActive(false);
            P2_animals[3].SetActive(false);
        }
        else if (p == 3)
        {
            P2_animals[0].SetActive(false);
            P2_animals[1].SetActive(false);
            P2_animals[2].SetActive(true);
            P2_animals[3].SetActive(false);
        }
        else if (p == 4)
        {
            P2_animals[0].SetActive(false);
            P2_animals[1].SetActive(false);
            P2_animals[2].SetActive(false);
            P2_animals[3].SetActive(true);
        }
    }
    void Choose3P()
    {
        if (p == 1)
        {
            P3_animals[0].SetActive(true);
            P3_animals[1].SetActive(false);
            P3_animals[2].SetActive(false);
            P3_animals[3].SetActive(false);
        }
        else if (p == 2)
        {
            P3_animals[0].SetActive(false);
            P3_animals[1].SetActive(true);
            P3_animals[2].SetActive(false);
            P3_animals[3].SetActive(false);
        }
        else if (p == 3)
        {
            P3_animals[0].SetActive(false);
            P3_animals[1].SetActive(false);
            P3_animals[2].SetActive(true);
            P3_animals[3].SetActive(false);
        }
        else if (p == 4)
        {
            P3_animals[0].SetActive(false);
            P3_animals[1].SetActive(false);
            P3_animals[2].SetActive(false);
            P3_animals[3].SetActive(true);

        }
    }
    void Choose4P()
    {
        if (p == 1)
        {
            P4_animals[0].SetActive(true);
            P4_animals[1].SetActive(false);
            P4_animals[2].SetActive(false);
            P4_animals[3].SetActive(false);
        }
        else if (p == 2)
        {
            P4_animals[0].SetActive(false);
            P4_animals[1].SetActive(true);
            P4_animals[2].SetActive(false);
            P4_animals[3].SetActive(false);
        }
        else if (p == 3)
        {
            P4_animals[0].SetActive(false);
            P4_animals[1].SetActive(false);
            P4_animals[2].SetActive(true);
            P4_animals[3].SetActive(false);
        }
        else if (p == 4)
        {
            P4_animals[0].SetActive(false);
            P4_animals[1].SetActive(false);
            P4_animals[2].SetActive(false);
            P4_animals[3].SetActive(true);
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

    public void OK_2p()
    {
        confirm++;
        OK[1].SetActive(false);
        NO[1].SetActive(true);
        button[2].SetActive(false);
        button[3].SetActive(false);
    }
    public void Cancel_2p()
    {
        confirm--;
        OK[1].SetActive(true);
        NO[1].SetActive(false);
        button[2].SetActive(true);
        button[3].SetActive(true);
    }
    public void Left_2p()
    {
        p--;
        Limit();
        Choose2P();
    }
    public void Right_2p()
    {
        p++;
        Limit();
        Choose2P();
    }

    public void OK_3p()
    {
        confirm++;
        OK[2].SetActive(false);
        NO[2].SetActive(true);
        button[4].SetActive(false);
        button[5].SetActive(false);
    }
    public void Cancel_3p()
    {
        confirm--;
        OK[2].SetActive(true);
        NO[2].SetActive(false);
        button[4].SetActive(true);
        button[5].SetActive(true);
    }
    public void Left_3p()
    {
        p--;
        Limit();
        Choose3P();
    }
    public void Right_3p()
    {
        p++;
        Limit();
        Choose3P();
    }

    public void OK_4p()
    {
        confirm++;
        OK[3].SetActive(false);
        NO[3].SetActive(true);
        button[6].SetActive(false);
        button[7].SetActive(false);
    }
    public void Cancel_4p()
    {
        confirm--;
        OK[3].SetActive(true);
        NO[3].SetActive(false);
        button[6].SetActive(true);
        button[7].SetActive(true);
    }
    public void Left_4p()
    {
        p--;
        Limit();
        Choose4P();
    }
    public void Right_4p()
    {
        p++;
        Limit();
        Choose4P();
    }
}
