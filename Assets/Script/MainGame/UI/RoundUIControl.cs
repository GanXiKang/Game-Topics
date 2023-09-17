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
                Player[1] = "Mouse";
                break;
            case 2:
                Player[1] = "Cow";
                break;
            case 3:
                Player[1] = "Tiger";
                break;
            case 4:
                Player[1] = "Rabbit";
                break;
            case 5:
                Player[1] = "Dragon";
                break;
            case 6:
                Player[1] = "Snake";
                break;
            case 7:
                Player[1] = "Horse";
                break;
            case 8:
                Player[1] = "Sheep";
                break;
            case 9:
                Player[1] = "Monkey";
                break;
            case 10:
                Player[1] = "Chicken";
                break;
            case 11:
                Player[1] = "Dog";
                break;
            case 12:
                Player[1] = "Pig";
                break;
        }
        switch (Menu_ChoosePlayer.whyP2)
        {
            case 1:
                Player[2] = "Mouse";
                break;
            case 2:
                Player[2] = "Cow";
                break;
            case 3:
                Player[2] = "Tiger";
                break;
            case 4:
                Player[2] = "Rabbit";
                break;
            case 5:
                Player[2] = "Dragon";
                break;
            case 6:
                Player[2] = "Snake";
                break;
            case 7:
                Player[2] = "Horse";
                break;
            case 8:
                Player[2] = "Sheep";
                break;
            case 9:
                Player[2] = "Monkey";
                break;
            case 10:
                Player[2] = "Chicken";
                break;
            case 11:
                Player[2] = "Dog";
                break;
            case 12:
                Player[2] = "Pig";
                break;
        }
        switch (Menu_ChoosePlayer.whyP3)
        {
            case 1:
                Player[3] = "Mouse";
                break;
            case 2:
                Player[3] = "Cow";
                break;
            case 3:
                Player[3] = "Tiger";
                break;
            case 4:
                Player[3] = "Rabbit";
                break;
            case 5:
                Player[3] = "Dragon";
                break;
            case 6:
                Player[3] = "Snake";
                break;
            case 7:
                Player[3] = "Horse";
                break;
            case 8:
                Player[3] = "Sheep";
                break;
            case 9:
                Player[3] = "Monkey";
                break;
            case 10:
                Player[3] = "Chicken";
                break;
            case 11:
                Player[3] = "Dog";
                break;
            case 12:
                Player[3] = "Pig";
                break;
        }
        switch (Menu_ChoosePlayer.whyP4)
        {
            case 1:
                Player[4] = "Mouse";
                break;
            case 2:
                Player[4] = "Cow";
                break;
            case 3:
                Player[4] = "Tiger";
                break;
            case 4:
                Player[4] = "Rabbit";
                break;
            case 5:
                Player[4] = "Dragon";
                break;
            case 6:
                Player[4] = "Snake";
                break;
            case 7:
                Player[4] = "Horse";
                break;
            case 8:
                Player[4] = "Sheep";
                break;
            case 9:
                Player[4] = "Monkey";
                break;
            case 10:
                Player[4] = "Chicken";
                break;
            case 11:
                Player[4] = "Dog";
                break;
            case 12:
                Player[4] = "Pig";
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
                    p[4].SetActive(false);
                    CoinTotal.text = "Coin : " + CoinControl.P1CoinTotal.ToString();
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
                    p[2].SetActive(true);
                    p[1].SetActive(false);
                    CoinTotal.text = "Coin : " + CoinControl.P2CoinTotal.ToString();
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
                    p[3].SetActive(true);
                    p[2].SetActive(false);
                    CoinTotal.text = "Coin : " + CoinControl.P3CoinTotal.ToString();
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
                    p[4].SetActive(true);
                    p[3].SetActive(false);
                    CoinTotal.text = "Coin : " + CoinControl.P4CoinTotal.ToString();
                    break;
            }
        }
    }
}
