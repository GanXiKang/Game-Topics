using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu_ChoosePlayer : MonoBehaviour
{
    AudioSource BGM;

    public static int whoPlay, whyP1, whyP2, whyP3, whyP4;
    public static int isDestoryP1, isDestoryP2, isDestoryP3, isDestoryP4;
    public static bool isJumpP1, isJumpP2, isJumpP3, isJumpP4;

    public GameObject[] Group = new GameObject[2];
    public GameObject[] animals = new GameObject[12];
    public GameObject[] insPoint = new GameObject[5];
    public GameObject[] OK = new GameObject[4];
    public GameObject[] NO = new GameObject[4];
    public GameObject[] button = new GameObject[8];
    public GameObject ErrorMenu;

    public AudioClip ok, cancel, change, error, close;

    bool isP1OK, isP2OK, isP3OK, isP4OK;
    bool isStopAD = false;

    void Start()
    {
        BGM = GetComponent<AudioSource>();

        whoPlay = 0;
        whyP1 = 0;
        whyP2 = 0;
        whyP3 = 0;
        whyP4 = 0;
        isDestoryP1 = 0;
        isDestoryP2 = 0;
        isDestoryP3 = 0;
        isDestoryP4 = 0;
    }

    void Update()
    {
        if (!isStopAD)
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
                    isP4OK = false;
                    isDestoryP4++;
                }
                if (whoPlay == 3)
                {
                    whyP3 = 0;
                    isP3OK = false;
                    isDestoryP3++;
                }
                whoPlay--;
                Limit();
            }
        }

        Process();
    }

    IEnumerator GoMainGame()
    {
        isStopAD = true;
        InstantiatePointControl.isStart = true;
        EndInsPlayerControl.isGameSceneDestroy = false;
        NO[0].SetActive(false);
        NO[1].SetActive(false);
        NO[2].SetActive(false);
        NO[3].SetActive(false);
        yield return new WaitForSeconds(1.5f);
        SceneManager.LoadScene(7);
        isStopAD = false;
    }

    void Process()
    {
        if (whoPlay == 2)
        {
            Group[0].SetActive(false);
            Group[1].SetActive(false);

            if (isP1OK && isP2OK)
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

            if (isP1OK && isP2OK && isP3OK)
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
            Group[0].SetActive(true);
            Group[1].SetActive(true);

            if (isP1OK && isP2OK && isP3OK && isP4OK)
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
            whyP1 = 12;
        }
        if (whyP1 > 12)
        {
            whyP1 = 1;
        }
    }
    void Limit2P()
    {
        if (whyP2 < 1)
        {
            whyP2 = 12;
        }
        if (whyP2 > 12)
        {
            whyP2 = 1;
        }
    }
    void Limit3P()
    {
        if (whyP3 < 1)
        {
            whyP3 = 12;
        }
        if (whyP3 > 12)
        {
            whyP3 = 1;
        }
    }
    void Limit4P()
    {
        if (whyP4 < 1)
        {
            whyP4 = 12;
        }
        if (whyP4 > 12)
        {
            whyP4 = 1;
        }
    }

    void Choose1P()
    {
        Instantiate(animals[whyP1 - 1], insPoint[1].transform.position, insPoint[1].transform.rotation);
    }
    void Choose2P()
    {
        Instantiate(animals[whyP2 - 1], insPoint[2].transform.position, insPoint[2].transform.rotation);
    }
    void Choose3P()
    {
        Instantiate(animals[whyP3 - 1], insPoint[3].transform.position, insPoint[3].transform.rotation);
    }
    void Choose4P()
    {
        Instantiate(animals[whyP4 - 1], insPoint[4].transform.position, insPoint[4].transform.rotation);
    }

    public void OK_1p()
    {
        if (whyP1 != 0)
        {
            isP1OK = true;
            isJumpP1 = true;
            OK[0].SetActive(false);
            NO[0].SetActive(true);
            button[0].SetActive(false);
            button[1].SetActive(false);
            BGM.PlayOneShot(ok);
        }
    }
    public void Cancel_1p()
    {
        isP1OK = false;
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
        if (whyP2 != 0)
        {
            isP2OK = true;
            isJumpP2 = true;
            OK[1].SetActive(false);
            NO[1].SetActive(true);
            button[2].SetActive(false);
            button[3].SetActive(false);
            BGM.PlayOneShot(ok);
        }
    }
    public void Cancel_2p()
    {
        isP2OK = false;
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
        if (whyP3 != 0)
        {
            isP3OK = true;
            isJumpP3 = true;
            OK[2].SetActive(false);
            NO[2].SetActive(true);
            button[4].SetActive(false);
            button[5].SetActive(false);
            BGM.PlayOneShot(ok);
        }
    }
    public void Cancel_3p()
    {
        isP3OK = false;
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
        if (whyP4 != 0)
        {
            isP4OK = true;
            isJumpP4 = true;
            OK[3].SetActive(false);
            NO[3].SetActive(true);
            button[6].SetActive(false);
            button[7].SetActive(false);
            BGM.PlayOneShot(ok);
        }
    }
    public void Cancel_4p()
    {
        isP4OK = false;
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
        isP1OK = false;
        isP2OK = false;
        isP3OK = false;
        isP4OK = false;
        ErrorMenu.SetActive(false);
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
