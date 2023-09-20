using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu_ChoosePlayer : MonoBehaviour
{
    public static int whoPlay = 0, whyP1 = 0, whyP2 = 0, whyP3 = 0, whyP4 = 0;
    public static int isDestoryP1 = 0, isDestoryP2 = 0, isDestoryP3 = 0, isDestoryP4 = 0;
    public static bool isOkP1, isOkP2, isOkP3, isOkP4;

    public GameObject[] Group = new GameObject[2];
    public GameObject[] animals = new GameObject[4];
    public GameObject[] insPoint = new GameObject[5];
    public GameObject[] OK = new GameObject[4];
    public GameObject[] NO = new GameObject[4];
    public GameObject[] button = new GameObject[8];
    public GameObject ErrorMenu;

    public AudioSource BGM;
    public AudioClip ok, cancel, change, error, close;

    float confirm;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.A))
        {
            whoPlay++;
            if (whoPlay == 4)
            {
                isDestoryP4 = 0;
            }
            if (whoPlay == 3)
            {
                isDestoryP3 = 0;
            } 
            Limit();
        }
        if (Input.GetKeyDown(KeyCode.D))
        {
            if (whoPlay == 4)
            {
                whyP4 = 0;
                isDestoryP4++;
            }
            if (whoPlay == 3)
            {
                whyP3 = 0;
                isDestoryP3++;
            }
            whoPlay--;
            Limit();
        }

        Process();
    }
    IEnumerator GoMainGame()
    {
        NO[0].SetActive(false);
        NO[1].SetActive(false);
        NO[2].SetActive(false);
        NO[3].SetActive(false);
        yield return new WaitForSeconds(1.5f);
        InstantiatePointControl.isStart = true;
        SceneManager.LoadScene(7);
        isDestoryP1 = 0;
        isDestoryP2 = 0;
        isDestoryP3 = 0;
        isDestoryP4 = 0;
    }

    void Process()
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
            Group[0].SetActive(true);
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
        else if (whoPlay == 4)
        {
            Group[1].SetActive(true);

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
    }
    void Limit()
    {
        if (whoPlay > 4)
        {
            whoPlay = 4;
        }
        if (whoPlay < 2)
        {
            whoPlay = 2;
        }
    }
    void Limit1P()
    {
        if (whyP1 < 1)
        {
            whyP1 = 4;
        }
        if (whyP1 > 4)
        {
            whyP1 = 1;
        }
    }
    void Limit2P()
    {
        if (whyP2 < 1)
        {
            whyP2 = 4;
        }
        if (whyP2 > 4)
        {
            whyP2 = 1;
        }
    }
    void Limit3P()
    {
        if (whyP3 < 1)
        {
            whyP3 = 4;
        }
        if (whyP3 > 4)
        {
            whyP3 = 1;
        }
    }
    void Limit4P()
    {
        if (whyP4 < 1)
        {
            whyP4 = 4;
        }
        if (whyP4 > 4)
        {
            whyP4 = 1;
        }
    }

    void Choose1P()
    {
        switch (whyP1)
        {
            case 1:
                Instantiate(animals[0], insPoint[1].transform.position, insPoint[1].transform.rotation);
                break;
            case 2:
                Instantiate(animals[1], insPoint[1].transform.position, insPoint[1].transform.rotation);
                break;
            case 3:
                Instantiate(animals[2], insPoint[1].transform.position, insPoint[1].transform.rotation);
                break;
            case 4:
                Instantiate(animals[3], insPoint[1].transform.position, insPoint[1].transform.rotation);
                break;
        }
    }
    void Choose2P()
    {
        switch (whyP2)
        {
            case 1:
                Instantiate(animals[0], insPoint[2].transform.position, insPoint[2].transform.rotation);
                break;
            case 2:
                Instantiate(animals[1], insPoint[2].transform.position, insPoint[2].transform.rotation);
                break;
            case 3:
                Instantiate(animals[2], insPoint[2].transform.position, insPoint[2].transform.rotation);
                break;
            case 4:
                Instantiate(animals[3], insPoint[2].transform.position, insPoint[2].transform.rotation);
                break;
        }
    }
    void Choose3P()
    {
        switch (whyP3)
        {
            case 1:
                Instantiate(animals[0], insPoint[3].transform.position, insPoint[3].transform.rotation);
                break;
            case 2:
                Instantiate(animals[1], insPoint[3].transform.position, insPoint[3].transform.rotation);
                break;
            case 3:
                Instantiate(animals[2], insPoint[3].transform.position, insPoint[3].transform.rotation);
                break;
            case 4:
                Instantiate(animals[3], insPoint[3].transform.position, insPoint[3].transform.rotation);
                break;
        }
    }
    void Choose4P()
    {
        switch (whyP4)
        {
            case 1:
                Instantiate(animals[0], insPoint[4].transform.position, insPoint[4].transform.rotation);
                break;
            case 2:
                Instantiate(animals[1], insPoint[4].transform.position, insPoint[4].transform.rotation);
                break;
            case 3:
                Instantiate(animals[2], insPoint[4].transform.position, insPoint[4].transform.rotation);
                break;
            case 4:
                Instantiate(animals[3], insPoint[4].transform.position, insPoint[4].transform.rotation);
                break;
        }
    }

    public void OK_1p()
    {
        confirm++;
        isOkP1 = true;
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
        isDestoryP1++;
        whyP1--;
        Limit1P();
        Choose1P();
        OK[0].SetActive(true);
        BGM.PlayOneShot(change);
    }
    public void Right_1p()
    {
        isDestoryP1++;
        whyP1++;
        Limit1P();
        Choose1P();
        OK[0].SetActive(true);
        BGM.PlayOneShot(change);
    }

    public void OK_2p()
    {
        confirm++;
        isOkP2 = true;
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
        isDestoryP2++;
        whyP2--; 
        Limit2P();
        Choose2P();
        OK[1].SetActive(true);
        BGM.PlayOneShot(change);
    }
    public void Right_2p()
    {
        isDestoryP2++;
        whyP2++;
        Limit2P();
        Choose2P();
        OK[1].SetActive(true);
        BGM.PlayOneShot(change);
    }

    public void OK_3p()
    {
        confirm++;
        isOkP3 = true;
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
        isDestoryP3++;
        whyP3--;
        Limit3P();
        Choose3P();
        OK[2].SetActive(true);
        BGM.PlayOneShot(change);
    }
    public void Right_3p()
    {
        isDestoryP3++;
        whyP3++;
        Limit3P();
        Choose3P();
        OK[2].SetActive(true);
        BGM.PlayOneShot(change);
    }

    public void OK_4p()
    {
        confirm++;
        isOkP4 = true;
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
        isDestoryP4++;
        whyP4--;
        Limit4P();
        Choose4P();
        OK[3].SetActive(true);
        BGM.PlayOneShot(change);
    }
    public void Right_4p()
    {
        isDestoryP4++;
        whyP4++;
        Limit4P();
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
