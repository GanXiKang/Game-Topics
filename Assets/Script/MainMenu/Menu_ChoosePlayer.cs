using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu_ChoosePlayer : MonoBehaviour
{
    public static int whoPlay = 0, whyP1, whyP2, whyP3, whyP4;

    public GameObject[] Group = new GameObject[2];
    public GameObject[] animals = new GameObject[4];
    public GameObject[] insPoint = new GameObject[4];
    //public GameObject[] P1_animals = new GameObject[4];
    //public GameObject[] P2_animals = new GameObject[4];
    //public GameObject[] P3_animals = new GameObject[4];
    //public GameObject[] P4_animals = new GameObject[4];
    public GameObject[] OK = new GameObject[4];
    public GameObject[] NO = new GameObject[4];
    public GameObject[] button = new GameObject[8];
    public GameObject ErrorMenu;

    public AudioSource BGM;
    public AudioClip ok, cancel, change, error, close;

    float p, confirm;

    void Update()
    {
        if (whoPlay == 2)
        {
            Group[0].SetActive(false);
            Group[1].SetActive(false);

            if (confirm == 2)
            {
                if (whyP1 != whyP2)
                {
                    StartCoroutine(GoMainGame());
                }
                else
                {
                    ErrorMenu.SetActive(true);
                    BGM.PlayOneShot(error);
                }
            }
        }
        else if (whoPlay == 3)
        {
            Group[1].SetActive(false);

            if (confirm == 3)
            {
                if (whyP1 != whyP2 && whyP1 != whyP3 && whyP2 != whyP3)
                {
                    StartCoroutine(GoMainGame());
                }
                else
                {
                    ErrorMenu.SetActive(true);
                    BGM.PlayOneShot(error);
                }
            }
        }


        if (confirm == 4)
        {
            if (whyP1 != whyP2 && whyP1 != whyP3 && whyP1 != whyP4 && whyP2 != whyP3 && whyP2 != whyP4 && whyP3 != whyP4)
            {
                StartCoroutine(GoMainGame());
            }
            else
            {
                ErrorMenu.SetActive(true);
                BGM.PlayOneShot(error);
            }
        }
    }
    IEnumerator GoMainGame()
    {
        NO[0].SetActive(false);
        NO[1].SetActive(false);
        NO[2].SetActive(false);
        NO[3].SetActive(false);
        yield return new WaitForSeconds(1f);
        InstantiatePointControl.isStart = true;
        SceneManager.LoadScene(7);
    }
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
            //P1_animals[0].SetActive(true);
            //P1_animals[1].SetActive(false);
            //P1_animals[2].SetActive(false);
            //P1_animals[3].SetActive(false);
            whyP1 = 1;
        }
        else if (p == 2)
        {
            //P1_animals[0].SetActive(false);
            //P1_animals[1].SetActive(true);
            //P1_animals[2].SetActive(false);
            //P1_animals[3].SetActive(false);
            whyP1 = 2;
        }
        else if (p == 3)
        {
            //P1_animals[0].SetActive(false);
            //P1_animals[1].SetActive(false);
            //P1_animals[2].SetActive(true);
            //P1_animals[3].SetActive(false);
            whyP1 = 3;
        }
        else if (p == 4)
        {
            //P1_animals[0].SetActive(false);
            //P1_animals[1].SetActive(false);
            //P1_animals[2].SetActive(false);
            //P1_animals[3].SetActive(true);
            whyP1 = 4;
        }
    }
    void Choose2P()
    {
        if (p == 1)
        {
            //P2_animals[0].SetActive(true);
            //P2_animals[1].SetActive(false);
            //P2_animals[2].SetActive(false);
            //P2_animals[3].SetActive(false);
            whyP2 = 1;
        }
        else if (p == 2)
        {
            //P2_animals[0].SetActive(false);
            //P2_animals[1].SetActive(true);
            //P2_animals[2].SetActive(false);
            //P2_animals[3].SetActive(false);
            whyP2 = 2;
        }
        else if (p == 3)
        {
            //P2_animals[0].SetActive(false);
            //P2_animals[1].SetActive(false);
            //P2_animals[2].SetActive(true);
            //P2_animals[3].SetActive(false);
            whyP2 = 3;
        }
        else if (p == 4)
        {
            //P2_animals[0].SetActive(false);
            //P2_animals[1].SetActive(false);
            //P2_animals[2].SetActive(false);
            //P2_animals[3].SetActive(true);
            whyP2 = 4;
        }
    }
    void Choose3P()
    {
        if (p == 1)
        {
            //P3_animals[0].SetActive(true);
            //P3_animals[1].SetActive(false);
            //P3_animals[2].SetActive(false);
            //P3_animals[3].SetActive(false);
            whyP3 = 1;
        }
        else if (p == 2)
        {
            //P3_animals[0].SetActive(false);
            //P3_animals[1].SetActive(true);
            //P3_animals[2].SetActive(false);
            //P3_animals[3].SetActive(false);
            whyP3 = 2;
        }
        else if (p == 3)
        {
            //P3_animals[0].SetActive(false);
            //P3_animals[1].SetActive(false);
            //P3_animals[2].SetActive(true);
            //P3_animals[3].SetActive(false);
            whyP3 = 3;
        }
        else if (p == 4)
        {
            //P3_animals[0].SetActive(false);
            //P3_animals[1].SetActive(false);
            //P3_animals[2].SetActive(false);
            //P3_animals[3].SetActive(true);
            whyP3 = 4;

        }
    }
    void Choose4P()
    {
        if (p == 1)
        {
            //P4_animals[0].SetActive(true);
            //P4_animals[1].SetActive(false);
            //P4_animals[2].SetActive(false);
            //P4_animals[3].SetActive(false);
            whyP4 = 1;
        }
        else if (p == 2)
        {
            //P4_animals[0].SetActive(false);
            //P4_animals[1].SetActive(true);
            //P4_animals[2].SetActive(false);
            //P4_animals[3].SetActive(false);
            whyP4 = 2;
        }
        else if (p == 3)
        {
            //P4_animals[0].SetActive(false);
            //P4_animals[1].SetActive(false);
            //P4_animals[2].SetActive(true);
            //P4_animals[3].SetActive(false);
            whyP4 = 3;
        }
        else if (p == 4)
        {
            //P4_animals[0].SetActive(false);
            //P4_animals[1].SetActive(false);
            //P4_animals[2].SetActive(false);
            //P4_animals[3].SetActive(true);
            whyP4 = 4;
        }
    }

    public void OK_1p()
    {
        confirm++;
        OK[0].SetActive(false);
        NO[0].SetActive(true);
        button[0].SetActive(false);
        button[1].SetActive(false);
        BGM.PlayOneShot(ok);
    }
    public void Cancel_1p()
    {
        confirm--;
        OK[0].SetActive(true);
        NO[0].SetActive(false);
        button[0].SetActive(true);
        button[1].SetActive(true);
        BGM.PlayOneShot(cancel);
    }
    public void Left_1p()
    {
        p--;
        Limit();
        Choose1P();
        OK[0].SetActive(true);
        BGM.PlayOneShot(change);
    }
    public void Right_1p()
    {
        p++;
        Limit();
        Choose1P();
        OK[0].SetActive(true);
        BGM.PlayOneShot(change);
    }

    public void OK_2p()
    {
        confirm++;
        OK[1].SetActive(false);
        NO[1].SetActive(true);
        button[2].SetActive(false);
        button[3].SetActive(false);
        BGM.PlayOneShot(ok);
    }
    public void Cancel_2p()
    {
        confirm--;
        OK[1].SetActive(true);
        NO[1].SetActive(false);
        button[2].SetActive(true);
        button[3].SetActive(true);
        BGM.PlayOneShot(cancel);
    }
    public void Left_2p()
    {
        p--;
        Limit();
        Choose2P();
        OK[1].SetActive(true);
        BGM.PlayOneShot(change);
    }
    public void Right_2p()
    {
        p++;
        Limit();
        Choose2P();
        OK[1].SetActive(true);
        BGM.PlayOneShot(change);
    }

    public void OK_3p()
    {
        confirm++;
        OK[2].SetActive(false);
        NO[2].SetActive(true);
        button[4].SetActive(false);
        button[5].SetActive(false);
        BGM.PlayOneShot(ok);
    }
    public void Cancel_3p()
    {
        confirm--;
        OK[2].SetActive(true);
        NO[2].SetActive(false);
        button[4].SetActive(true);
        button[5].SetActive(true);
        BGM.PlayOneShot(cancel);
    }
    public void Left_3p()
    {
        p--;
        Limit();
        Choose3P();
        OK[2].SetActive(true);
        BGM.PlayOneShot(change);
    }
    public void Right_3p()
    {
        p++;
        Limit();
        Choose3P();
        OK[2].SetActive(true);
        BGM.PlayOneShot(change);
    }

    public void OK_4p()
    {
        confirm++;
        OK[3].SetActive(false);
        NO[3].SetActive(true);
        button[6].SetActive(false);
        button[7].SetActive(false);
        BGM.PlayOneShot(ok);
    }
    public void Cancel_4p()
    {
        confirm--;
        OK[3].SetActive(true);
        NO[3].SetActive(false);
        button[6].SetActive(true);
        button[7].SetActive(true);
        BGM.PlayOneShot(cancel);
    }
    public void Left_4p()
    {
        p--;
        Limit();
        Choose4P();
        OK[3].SetActive(true);
        BGM.PlayOneShot(change);
    }
    public void Right_4p()
    {
        p++;
        Limit();
        Choose4P();
        OK[3].SetActive(true);
        BGM.PlayOneShot(change);
    }

    public void Close_ErrorMenu()
    {
        ErrorMenu.SetActive(false);
        confirm = 0;
        BGM.PlayOneShot(close);
        button[0].SetActive(true);
        button[1].SetActive(true);
        button[2].SetActive(true);
        button[3].SetActive(true);
        button[4].SetActive(true);
        button[5].SetActive(true);
        button[6].SetActive(true);
        button[7].SetActive(true);
        OK[0].SetActive(true);
        OK[1].SetActive(true);
        OK[2].SetActive(true);
        OK[3].SetActive(true);
        NO[0].SetActive(false);
        NO[1].SetActive(false);
        NO[2].SetActive(false);
        NO[3].SetActive(false);   
    }
}
