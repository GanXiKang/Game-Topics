using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RoundUIControl : MonoBehaviour
{
    public GameObject[] animals = new GameObject[13];
    public GameObject[] p = new GameObject[5];
    public Text CoinTotal;

    public static string[] Player = new string[5];

    void Start()
    {
        switch (Menu_ChoosePlayer.whyP1)
        {
            case 1:
                Player[1] = "��";
                break;
            case 2:
                Player[1] = "ţ";
                break;
            case 3:
                Player[1] = "��";
                break;
            case 4:
                Player[1] = "��";
                break;
            case 5:
                Player[1] = "��";
                break;
            case 6:
                Player[1] = "��";
                break;
            case 7:
                Player[1] = "�R";
                break;
            case 8:
                Player[1] = "��";
                break;
            case 9:
                Player[1] = "��";
                break;
            case 10:
                Player[1] = "�u";
                break;
            case 11:
                Player[1] = "��";
                break;
            case 12:
                Player[1] = "�i";
                break;
        }
        switch (Menu_ChoosePlayer.whyP2)
        {
            case 1:
                Player[2] = "��";
                break;
            case 2:
                Player[2] = "ţ";
                break;
            case 3:
                Player[2] = "��";
                break;
            case 4:
                Player[2] = "��";
                break;
            case 5:
                Player[2] = "��";
                break;
            case 6:
                Player[2] = "��";
                break;
            case 7:
                Player[2] = "�R";
                break;
            case 8:
                Player[2] = "��";
                break;
            case 9:
                Player[2] = "��";
                break;
            case 10:
                Player[2] = "�u";
                break;
            case 11:
                Player[2] = "��";
                break;
            case 12:
                Player[2] = "�i";
                break;
        }
        switch (Menu_ChoosePlayer.whyP3)
        {
            case 1:
                Player[3] = "��";
                break;
            case 2:
                Player[3] = "ţ";
                break;
            case 3:
                Player[3] = "��";
                break;
            case 4:
                Player[3] = "��";
                break;
            case 5:
                Player[3] = "��";
                break;
            case 6:
                Player[3] = "��";
                break;
            case 7:
                Player[3] = "�R";
                break;
            case 8:
                Player[3] = "��";
                break;
            case 9:
                Player[3] = "��";
                break;
            case 10:
                Player[3] = "�u";
                break;
            case 11:
                Player[3] = "��";
                break;
            case 12:
                Player[3] = "�i";
                break;
        }
        switch (Menu_ChoosePlayer.whyP4)
        {
            case 1:
                Player[4] = "��";
                break;
            case 2:
                Player[4] = "ţ";
                break;
            case 3:
                Player[4] = "��";
                break;
            case 4:
                Player[4] = "��";
                break;
            case 5:
                Player[4] = "��";
                break;
            case 6:
                Player[4] = "��";
                break;
            case 7:
                Player[4] = "�R";
                break;
            case 8:
                Player[4] = "��";
                break;
            case 9:
                Player[4] = "��";
                break;
            case 10:
                Player[4] = "�u";
                break;
            case 11:
                Player[4] = "��";
                break;
            case 12:
                Player[4] = "�i";
                break;
        }
    }
    void Update()
    {
        if (!MiniGameColliderControl.isMiniGame || !GameEndControl.isEnd)
        {
            switch (ChangeCameraControl.changeCameraNum)
            {
                case 1:
                    for (int i = 1; i <= 12; i++)
                    {
                        if (i == Menu_ChoosePlayer.whyP1)
                        {
                            animals[i].SetActive(true);
                        }
                        else
                        {
                            animals[i].SetActive(false);
                        }
                    }
                    p[1].SetActive(true);
                    p[2].SetActive(false);
                    p[3].SetActive(false);
                    p[4].SetActive(false);
                    CoinTotal.text = CoinControl.P1CoinTotal.ToString();
                    break;

                case 2:
                    for (int i = 1; i <= 12; i++)
                    {
                        if (i == Menu_ChoosePlayer.whyP2)
                        {
                            animals[i].SetActive(true);
                        }
                        else
                        {
                            animals[i].SetActive(false);
                        }
                    }
                    p[1].SetActive(false);
                    p[2].SetActive(true);
                    p[3].SetActive(false);
                    p[4].SetActive(false);
                    CoinTotal.text = CoinControl.P2CoinTotal.ToString();
                    break;

                case 3:
                    for (int i = 1; i <= 12; i++)
                    {
                        if (i == Menu_ChoosePlayer.whyP3)
                        {
                            animals[i].SetActive(true);
                        }
                        else
                        {
                            animals[i].SetActive(false);
                        }
                    }
                    p[1].SetActive(false);
                    p[2].SetActive(false);
                    p[3].SetActive(true);
                    p[4].SetActive(false);
                    CoinTotal.text = CoinControl.P3CoinTotal.ToString();
                    break;

                case 4:
                    for (int i = 1; i <= 12; i++)
                    {
                        if (i == Menu_ChoosePlayer.whyP4)
                        {
                            animals[i].SetActive(true);
                        }
                        else
                        {
                            animals[i].SetActive(false);
                        }
                    }
                    p[1].SetActive(false);
                    p[2].SetActive(false);
                    p[3].SetActive(false);
                    p[4].SetActive(true);
                    CoinTotal.text = CoinControl.P4CoinTotal.ToString();
                    break;
            }
        }
    }
}
