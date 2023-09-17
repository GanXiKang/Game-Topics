using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RoundUIControl : MonoBehaviour
{
    public GameObject[] animals = new GameObject[12];
    public GameObject[] p = new GameObject[5];
    public Text CoinTotal;

    void Update()
    {
        if (!MiniGameColliderControl.isMiniGame || !GameEndControl.isEnd)
        {
            switch (ChangeCameraControl.changeCameraNum)
            {
                case 1:
                    for (int i = 0; i < 4; i++)
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
                    p[4].SetActive(false);
                    CoinTotal.text = "Coin : " + CoinControl.P1CoinTotal.ToString();
                    break;

                case 2:
                    for (int i = 0; i < 4; i++)
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
                    p[2].SetActive(true);
                    p[1].SetActive(false);
                    CoinTotal.text = "Coin : " + CoinControl.P2CoinTotal.ToString();
                    break;

                case 3:
                    for (int i = 0; i < 4; i++)
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
                    p[3].SetActive(true);
                    p[2].SetActive(false);
                    CoinTotal.text = "Coin : " + CoinControl.P3CoinTotal.ToString();
                    break;

                case 4:
                    for (int i = 0; i < 4; i++)
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
                    p[4].SetActive(true);
                    p[3].SetActive(false);
                    CoinTotal.text = "Coin : " + CoinControl.P4CoinTotal.ToString();
                    break;
            }
        }
    }
}
