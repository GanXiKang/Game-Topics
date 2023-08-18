using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StoreUIControl : MonoBehaviour
{
    AudioSource BGM;
    public AudioClip buy, cancel, close, getCoin, select, sure;

    public GameObject[] StoreUI = new GameObject[4];
    public Text[] PorpsCoin = new Text[7];
    public Text[] group3Text = new Text[5];
    public Button buttonBuy;

    public static bool isStore = false, isBuying = false;

    bool haveBuy = false, buyOK = false;
    int whyProps, totalCoin, buyQuantity = 1, limitQuantity = 3;
    int[] howMuchCoin = new int[7];
    string[] propsName = new string[7];
    string[] propsUse = new string[7];

    void Start()
    {
        BGM = GetComponent<AudioSource>();
        //道具數量和書包系統一同製作
        InitialHowMuchCoin();
        InitialPropsName();
        InitialPropsUse();
    }
    void Update()
    {
        if (isStore)
        {
            StoreUI[1].SetActive(true);
            CatAnimatorControl.isWave = true;
        }
        else if (isBuying)
        {
            switch (StoreColliderControl.who)
            {
                case 1:
                    if (CoinControl.P1CoinTotal < howMuchCoin[0])
                    {
                        PorpsCoin[0].color = Color.red;
                    }
                    else
                    {
                        PorpsCoin[0].color = Color.green;
                    }
                    if (CoinControl.P1CoinTotal < howMuchCoin[1])
                    {
                        PorpsCoin[1].color = Color.red;
                    }
                    else
                    {
                        PorpsCoin[1].color = Color.green;
                    }
                    if (CoinControl.P1CoinTotal < howMuchCoin[2])
                    {
                        PorpsCoin[2].color = Color.red;
                    }
                    else
                    {
                        PorpsCoin[2].color = Color.green;
                    }
                    if (CoinControl.P1CoinTotal < howMuchCoin[3])
                    {
                        PorpsCoin[3].color = Color.red;
                    }
                    else
                    {
                        PorpsCoin[3].color = Color.green;
                    }
                    if (CoinControl.P1CoinTotal < howMuchCoin[4])
                    {
                        PorpsCoin[4].color = Color.red;
                    }
                    else
                    {
                        PorpsCoin[4].color = Color.green;
                    }
                    if (CoinControl.P1CoinTotal < howMuchCoin[5])
                    {
                        PorpsCoin[5].color = Color.red;
                    }
                    else
                    {
                        PorpsCoin[5].color = Color.green;
                    }
                    if (CoinControl.P1CoinTotal < howMuchCoin[6])
                    {
                        PorpsCoin[6].color = Color.red;
                    }
                    else
                    {
                        PorpsCoin[6].color = Color.green;
                    }
                    if (CoinControl.P1CoinTotal < totalCoin)
                    {
                        group3Text[4].color = Color.red;
                        buyOK = false;
                    }
                    else
                    {
                        group3Text[4].color = Color.green;
                        buyOK = true;
                    }
                    break;

                case 2:
                    if (CoinControl.P2CoinTotal < howMuchCoin[0])
                    {
                        PorpsCoin[0].color = Color.red;
                    }
                    else
                    {
                        PorpsCoin[0].color = Color.green;
                    }
                    if (CoinControl.P2CoinTotal < howMuchCoin[1])
                    {
                        PorpsCoin[1].color = Color.red;
                    }
                    else
                    {
                        PorpsCoin[1].color = Color.green;
                    }
                    if (CoinControl.P2CoinTotal < howMuchCoin[2])
                    {
                        PorpsCoin[2].color = Color.red;
                    }
                    else
                    {
                        PorpsCoin[2].color = Color.green;
                    }
                    if (CoinControl.P2CoinTotal < howMuchCoin[3])
                    {
                        PorpsCoin[3].color = Color.red;
                    }
                    else
                    {
                        PorpsCoin[3].color = Color.green;
                    }
                    if (CoinControl.P2CoinTotal < howMuchCoin[4])
                    {
                        PorpsCoin[4].color = Color.red;
                    }
                    else
                    {
                        PorpsCoin[4].color = Color.green;
                    }
                    if (CoinControl.P2CoinTotal < howMuchCoin[5])
                    {
                        PorpsCoin[5].color = Color.red;
                    }
                    else
                    {
                        PorpsCoin[5].color = Color.green;
                    }
                    if (CoinControl.P2CoinTotal < howMuchCoin[6])
                    {
                        PorpsCoin[6].color = Color.red;
                    }
                    else
                    {
                        PorpsCoin[6].color = Color.green;
                    }
                    if (CoinControl.P2CoinTotal < totalCoin)
                    {
                        group3Text[4].color = Color.red;
                        buyOK = false;
                    }
                    else
                    {
                        group3Text[4].color = Color.green;
                        buyOK = true;
                    }
                    break;

                case 3:
                    if (CoinControl.P3CoinTotal < howMuchCoin[0])
                    {
                        PorpsCoin[0].color = Color.red;
                    }
                    else
                    {
                        PorpsCoin[0].color = Color.green;
                    }
                    if (CoinControl.P3CoinTotal < howMuchCoin[1])
                    {
                        PorpsCoin[1].color = Color.red;
                    }
                    else
                    {
                        PorpsCoin[1].color = Color.green;
                    }
                    if (CoinControl.P3CoinTotal < howMuchCoin[2])
                    {
                        PorpsCoin[2].color = Color.red;
                    }
                    else
                    {
                        PorpsCoin[2].color = Color.green;
                    }
                    if (CoinControl.P3CoinTotal < howMuchCoin[3])
                    {
                        PorpsCoin[3].color = Color.red;
                    }
                    else
                    {
                        PorpsCoin[3].color = Color.green;
                    }
                    if (CoinControl.P3CoinTotal < howMuchCoin[4])
                    {
                        PorpsCoin[4].color = Color.red;
                    }
                    else
                    {
                        PorpsCoin[4].color = Color.green;
                    }
                    if (CoinControl.P3CoinTotal < howMuchCoin[5])
                    {
                        PorpsCoin[5].color = Color.red;
                    }
                    else
                    {
                        PorpsCoin[5].color = Color.green;
                    }
                    if (CoinControl.P3CoinTotal < howMuchCoin[6])
                    {
                        PorpsCoin[6].color = Color.red;
                    }
                    else
                    {
                        PorpsCoin[6].color = Color.green;
                    }
                    if (CoinControl.P3CoinTotal < totalCoin)
                    {
                        group3Text[4].color = Color.red;
                        buyOK = false;
                    }
                    else
                    {
                        group3Text[4].color = Color.green;
                        buyOK = true;
                    }
                    break;

                case 4:
                    if (CoinControl.P4CoinTotal < howMuchCoin[0])
                    {
                        PorpsCoin[0].color = Color.red;
                    }
                    else
                    {
                        PorpsCoin[0].color = Color.green;
                    }
                    if (CoinControl.P4CoinTotal < howMuchCoin[1])
                    {
                        PorpsCoin[1].color = Color.red;
                    }
                    else
                    {
                        PorpsCoin[1].color = Color.green;
                    }
                    if (CoinControl.P4CoinTotal < howMuchCoin[2])
                    {
                        PorpsCoin[2].color = Color.red;
                    }
                    else
                    {
                        PorpsCoin[2].color = Color.green;
                    }
                    if (CoinControl.P4CoinTotal < howMuchCoin[3])
                    {
                        PorpsCoin[3].color = Color.red;
                    }
                    else
                    {
                        PorpsCoin[3].color = Color.green;
                    }
                    if (CoinControl.P4CoinTotal < howMuchCoin[4])
                    {
                        PorpsCoin[4].color = Color.red;
                    }
                    else
                    {
                        PorpsCoin[4].color = Color.green;
                    }
                    if (CoinControl.P4CoinTotal < howMuchCoin[5])
                    {
                        PorpsCoin[5].color = Color.red;
                    }
                    else
                    {
                        PorpsCoin[5].color = Color.green;
                    }
                    if (CoinControl.P4CoinTotal < howMuchCoin[6])
                    {
                        PorpsCoin[6].color = Color.red;
                    }
                    else
                    {
                        PorpsCoin[6].color = Color.green;
                    }
                    if (CoinControl.P4CoinTotal < totalCoin)
                    {
                        group3Text[4].color = Color.red;
                        buyOK = false;
                    }
                    else
                    {
                        group3Text[4].color = Color.green;
                        buyOK = true;
                    }
                    break;
            }
            switch (whyProps)
            {
                case 1:
                    group3Text[0].text = propsName[0].ToString();
                    //group2Text[1].text =
                    group3Text[2].text = propsUse[0].ToString();
                    group3Text[3].text = buyQuantity.ToString() + " / " + limitQuantity.ToString();
                    group3Text[4].text = totalCoin.ToString();
                    break;

                case 2:
                    group3Text[0].text = propsName[1].ToString();
                    //group2Text[1].text =
                    group3Text[2].text = propsUse[1].ToString();
                    group3Text[3].text = buyQuantity.ToString() + " / " + limitQuantity.ToString();
                    group3Text[4].text = totalCoin.ToString();
                    break;

                case 3:
                    group3Text[0].text = propsName[2].ToString();
                    //group2Text[1].text =
                    group3Text[2].text = propsUse[2].ToString();
                    group3Text[3].text = buyQuantity.ToString() + " / " + limitQuantity.ToString();
                    group3Text[4].text = totalCoin.ToString();
                    break;

                case 4:
                    group3Text[0].text = propsName[3].ToString();
                    //group2Text[1].text =
                    group3Text[2].text = propsUse[3].ToString();
                    group3Text[3].text = buyQuantity.ToString() + " / " + limitQuantity.ToString();
                    group3Text[4].text = totalCoin.ToString();
                    break;

                case 5:
                    group3Text[0].text = propsName[4].ToString();
                    //group2Text[1].text =
                    group3Text[2].text = propsUse[4].ToString();
                    group3Text[3].text = buyQuantity.ToString() + " / " + limitQuantity.ToString();
                    group3Text[4].text = totalCoin.ToString();
                    break;

                case 6:
                    group3Text[0].text = propsName[5].ToString();
                    //group2Text[1].text =
                    group3Text[2].text = propsUse[5].ToString();
                    group3Text[3].text = buyQuantity.ToString() + " / " + limitQuantity.ToString();
                    group3Text[4].text = totalCoin.ToString();
                    break;

                case 7:
                    group3Text[0].text = propsName[6].ToString();
                    //group2Text[1].text =
                    group3Text[2].text = propsUse[6].ToString();
                    group3Text[3].text = buyQuantity.ToString() + " / " + limitQuantity.ToString();
                    group3Text[4].text = totalCoin.ToString();
                    break;
            }
        }

        if (buyOK)
        {
            buttonBuy.interactable = true;
        }
        else 
        {
            buttonBuy.interactable = false;
        }
    }

    public void Button_Yes()
    {
        isBuying = true;
        isStore = false;
        StoreUI[1].SetActive(false);
        StoreUI[2].SetActive(true);
        CatAnimatorControl.isWave = false;
    }
    public void Button_NO()
    {
        StartCoroutine(ChangeCamera());
    }
    public void Button_Porps(int why)
    {
        StoreUI[2].SetActive(false);
        StoreUI[3].SetActive(true);
        whyProps = why;
        BalanceTotal();
    }
    public void Button_Add()
    {
        buyQuantity++;
        Limit();
        BalanceTotal();
    }
    public void Button_Reduce()
    {
        buyQuantity--;
        Limit();
        BalanceTotal();
    }
    public void Button_Cancel()
    {
        StoreUI[2].SetActive(true);
        StoreUI[3].SetActive(false);
    }
    public void Button_Buy()
    {
        StoreUI[2].SetActive(true);
        StoreUI[3].SetActive(false);
        switch (StoreColliderControl.who)
        {
            case 1:
                CoinControl.P1CoinTotal -= totalCoin;
                break;

            case 2:
                CoinControl.P2CoinTotal -= totalCoin;
                break;

            case 3:
                CoinControl.P3CoinTotal -= totalCoin;
                break;

            case 4:
                CoinControl.P4CoinTotal -= totalCoin;
                break;
        }
        haveBuy = true;
        CatAnimatorControl.isHappy = true;
    }
    IEnumerator ChangeCamera()
    {

        isStore = false;
        isBuying = false;
        StoreUI[1].SetActive(false);
        StoreUI[2].SetActive(false);
        if (haveBuy)
        {
            CatAnimatorControl.isBye = true;
        }
        else
        {
            CatAnimatorControl.isSad = true;
        }
        yield return new WaitForSeconds(2f);
        ChangeCameraControl.changeCameraNum++;
        Dice.isDiceUI = true;
    }

    void Limit()
    {
        if (buyQuantity > limitQuantity)
        {
            buyQuantity = limitQuantity;
        }
        else if (buyQuantity < 1)
        {
            buyQuantity = 1;
        }
    }
    void BalanceTotal()
    {
        switch (whyProps)
        {
            case 1:
                totalCoin = howMuchCoin[0] * buyQuantity;
                break;

            case 2:
                totalCoin = howMuchCoin[1] * buyQuantity;
                break;

            case 3:
                totalCoin = howMuchCoin[2] * buyQuantity;
                break;

            case 4:
                totalCoin = howMuchCoin[3] * buyQuantity;
                break;

            case 5:
                totalCoin = howMuchCoin[4] * buyQuantity;
                break;

            case 6:
                totalCoin = howMuchCoin[5] * buyQuantity;
                break;

            case 7:
                totalCoin = howMuchCoin[6] * buyQuantity;
                break;
        }
    }
    void InitialHowMuchCoin()
    {
        howMuchCoin[0] = 100;
        howMuchCoin[1] = 90;
        howMuchCoin[2] = 80;
        howMuchCoin[3] = 70;
        howMuchCoin[4] = 60;
        howMuchCoin[5] = 50;
        howMuchCoin[6] = 40;
    }
    void InitialPropsName()
    {
        propsName[0] = "A道具";
        propsName[1] = "B道具";
        propsName[2] = "C道具";
        propsName[3] = "D道具";
        propsName[4] = "E道具";
        propsName[5] = "F道具";
        propsName[6] = "G道具";
    }
    void InitialPropsUse()
    {
        propsUse[0] = "A用途";
        propsUse[1] = "B用途";
        propsUse[2] = "C用途";
        propsUse[3] = "D用途";
        propsUse[4] = "E用途";
        propsUse[5] = "F用途";
        propsUse[6] = "G用途";
    }
}
