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
                Player[1] = " Û";
                break;
            case 2:
                Player[1] = "≈£";
                break;
            case 3:
                Player[1] = "ª¢";
                break;
            case 4:
                Player[1] = "Õ√";
                break;
            case 5:
                Player[1] = "˝à";
                break;
            case 6:
                Player[1] = "…ﬂ";
                break;
            case 7:
                Player[1] = "ÒR";
                break;
            case 8:
                Player[1] = "—Ú";
                break;
            case 9:
                Player[1] = "∫Ô";
                break;
            case 10:
                Player[1] = "Îu";
                break;
            case 11:
                Player[1] = "π∑";
                break;
            case 12:
                Player[1] = "ÿi";
                break;
        }
        switch (Menu_ChoosePlayer.whyP2)
        {
            case 1:
                Player[2] = " Û";
                break;
            case 2:
                Player[2] = "≈£";
                break;
            case 3:
                Player[2] = "ª¢";
                break;
            case 4:
                Player[2] = "Õ√";
                break;
            case 5:
                Player[2] = "˝à";
                break;
            case 6:
                Player[2] = "…ﬂ";
                break;
            case 7:
                Player[2] = "ÒR";
                break;
            case 8:
                Player[2] = "—Ú";
                break;
            case 9:
                Player[2] = "∫Ô";
                break;
            case 10:
                Player[2] = "Îu";
                break;
            case 11:
                Player[2] = "π∑";
                break;
            case 12:
                Player[2] = "ÿi";
                break;
        }
        switch (Menu_ChoosePlayer.whyP3)
        {
            case 1:
                Player[3] = " Û";
                break;
            case 2:
                Player[3] = "≈£";
                break;
            case 3:
                Player[3] = "ª¢";
                break;
            case 4:
                Player[3] = "Õ√";
                break;
            case 5:
                Player[3] = "˝à";
                break;
            case 6:
                Player[3] = "…ﬂ";
                break;
            case 7:
                Player[3] = "ÒR";
                break;
            case 8:
                Player[3] = "—Ú";
                break;
            case 9:
                Player[3] = "∫Ô";
                break;
            case 10:
                Player[3] = "Îu";
                break;
            case 11:
                Player[3] = "π∑";
                break;
            case 12:
                Player[3] = "ÿi";
                break;
        }
        switch (Menu_ChoosePlayer.whyP4)
        {
            case 1:
                Player[4] = " Û";
                break;
            case 2:
                Player[4] = "≈£";
                break;
            case 3:
                Player[4] = "ª¢";
                break;
            case 4:
                Player[4] = "Õ√";
                break;
            case 5:
                Player[4] = "˝à";
                break;
            case 6:
                Player[4] = "…ﬂ";
                break;
            case 7:
                Player[4] = "ÒR";
                break;
            case 8:
                Player[4] = "—Ú";
                break;
            case 9:
                Player[4] = "∫Ô";
                break;
            case 10:
                Player[4] = "Îu";
                break;
            case 11:
                Player[4] = "π∑";
                break;
            case 12:
                Player[4] = "ÿi";
                break;
        }
    }
    void Update()
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
