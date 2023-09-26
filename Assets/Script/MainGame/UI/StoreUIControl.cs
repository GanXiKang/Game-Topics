using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StoreUIControl : MonoBehaviour
{
    AudioSource BGM;
    public AudioClip buy, cancel, close, getCoin, select, sure;

    public GameObject[] StoreUI = new GameObject[4];
    public Text[] PorpsCoin = new Text[6];
    public Text[] group3Text = new Text[3];
    public GameObject[] propsImage = new GameObject[7];
    public Button buttonBuy;

    public static bool isStore = false, isBuying = false;

    bool haveBuy = false, buyOK = false;
    int whyProps, totalCoin, buyQuantity = 1, limitQuantity = 3;
    int[] howMuchCoin = new int[6];

    void Start()
    {
        BGM = GetComponent<AudioSource>();
        InitialHowMuchCoin();
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
                    if (CoinControl.P1CoinTotal < totalCoin)
                    {
                        group3Text[2].color = Color.red;
                        buyOK = false;
                    }
                    else
                    {
                        group3Text[2].color = Color.green;
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
                    if (CoinControl.P2CoinTotal < totalCoin)
                    {
                        group3Text[2].color = Color.red;
                        buyOK = false;
                    }
                    else
                    {
                        group3Text[2].color = Color.green;
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
                    if (CoinControl.P3CoinTotal < totalCoin)
                    {
                        group3Text[2].color = Color.red;
                        buyOK = false;
                    }
                    else
                    {
                        group3Text[2].color = Color.green;
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
                    if (CoinControl.P4CoinTotal < totalCoin)
                    {
                        group3Text[2].color = Color.red;
                        buyOK = false;
                    }
                    else
                    {
                        group3Text[2].color = Color.green;
                        buyOK = true;
                    }
                    break;
            }
            switch (whyProps)
            {
                case 1:
                    for (int i = 1; i < 7; i++)
                    {
                        if (i == whyProps)
                        {
                            propsImage[i].SetActive(true);
                        }
                        else
                        {
                            propsImage[i].SetActive(false);
                        }
                    }
                    switch (StoreColliderControl.who)
                    {
                        case 1:
                            group3Text[0].text = PropsControl.P1Props[0].ToString();
                            break;

                        case 2:
                            group3Text[0].text = PropsControl.P2Props[0].ToString();
                            break;

                        case 3:
                            group3Text[0].text = PropsControl.P3Props[0].ToString();
                            break;

                        case 4:
                            group3Text[0].text = PropsControl.P4Props[0].ToString();
                            break;
                    }
                    group3Text[1].text = buyQuantity.ToString() + " / " + limitQuantity.ToString();
                    group3Text[2].text = totalCoin.ToString();
                    break;

                case 2:
                    for (int i = 1; i < 7; i++)
                    {
                        if (i == whyProps)
                        {
                            propsImage[i].SetActive(true);
                        }
                        else
                        {
                            propsImage[i].SetActive(false);
                        }
                    }
                    switch (StoreColliderControl.who)
                    {
                        case 1:
                            group3Text[0].text = PropsControl.P1Props[1].ToString();
                            break;

                        case 2:
                            group3Text[0].text = PropsControl.P2Props[1].ToString();
                            break;

                        case 3:
                            group3Text[0].text = PropsControl.P3Props[1].ToString();
                            break;


                        case 4:
                            group3Text[0].text = PropsControl.P4Props[1].ToString();
                            break;
                    }
                    group3Text[1].text = buyQuantity.ToString() + " / " + limitQuantity.ToString();
                    group3Text[2].text = totalCoin.ToString();
                    break;

                case 3:
                    for (int i = 1; i < 7; i++)
                    {
                        if (i == whyProps)
                        {
                            propsImage[i].SetActive(true);
                        }
                        else
                        {
                            propsImage[i].SetActive(false);
                        }
                    }
                    switch (StoreColliderControl.who)
                    {
                        case 1:
                            group3Text[0].text = PropsControl.P1Props[2].ToString();
                            break;

                        case 2:
                            group3Text[0].text = PropsControl.P2Props[2].ToString();
                            break;

                        case 3:
                            group3Text[0].text = PropsControl.P3Props[2].ToString();
                            break;


                        case 4:
                            group3Text[0].text = PropsControl.P4Props[2].ToString();
                            break;
                    }
                    group3Text[1].text = buyQuantity.ToString() + " / " + limitQuantity.ToString();
                    group3Text[2].text = totalCoin.ToString();
                    break;

                case 4:
                    for (int i = 1; i < 7; i++)
                    {
                        if (i == whyProps)
                        {
                            propsImage[i].SetActive(true);
                        }
                        else
                        {
                            propsImage[i].SetActive(false);
                        }
                    }
                    switch (StoreColliderControl.who)
                    {
                        case 1:
                            group3Text[0].text = PropsControl.P1Props[3].ToString();
                            break;

                        case 2:
                            group3Text[0].text = PropsControl.P2Props[3].ToString();
                            break;

                        case 3:
                            group3Text[0].text = PropsControl.P3Props[3].ToString();
                            break;


                        case 4:
                            group3Text[0].text = PropsControl.P4Props[3].ToString();
                            break;
                    }
                    group3Text[1].text = buyQuantity.ToString() + " / " + limitQuantity.ToString();
                    group3Text[2].text = totalCoin.ToString();
                    break;

                case 5:
                    for (int i = 1; i < 7; i++)
                    {
                        if (i == whyProps)
                        {
                            propsImage[i].SetActive(true);
                        }
                        else
                        {
                            propsImage[i].SetActive(false);
                        }
                    }
                    switch (StoreColliderControl.who)
                    {
                        case 1:
                            group3Text[0].text = PropsControl.P1Props[4].ToString();
                            break;

                        case 2:
                            group3Text[0].text = PropsControl.P2Props[4].ToString();
                            break;

                        case 3:
                            group3Text[0].text = PropsControl.P3Props[4].ToString();
                            break;


                        case 4:
                            group3Text[0].text = PropsControl.P4Props[4].ToString();
                            break;
                    }
                    group3Text[1].text = buyQuantity.ToString() + " / " + limitQuantity.ToString();
                    group3Text[2].text = totalCoin.ToString();
                    break;

                case 6:
                    for (int i = 1; i < 7; i++)
                    {
                        if (i == whyProps)
                        {
                            propsImage[i].SetActive(true);
                        }
                        else
                        {
                            propsImage[i].SetActive(false);
                        }
                    }
                    switch (StoreColliderControl.who)
                    {
                        case 1:
                            group3Text[0].text = PropsControl.P1Props[5].ToString();
                            break;

                        case 2:
                            group3Text[0].text = PropsControl.P2Props[5].ToString();
                            break;

                        case 3:
                            group3Text[0].text = PropsControl.P3Props[5].ToString();
                            break;


                        case 4:
                            group3Text[0].text = PropsControl.P4Props[5].ToString();
                            break;
                    }
                    group3Text[1].text = buyQuantity.ToString() + " / " + limitQuantity.ToString();
                    group3Text[2].text = totalCoin.ToString();
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
        BGM.PlayOneShot(sure);
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
        BGM.PlayOneShot(getCoin);
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
        BGM.PlayOneShot(cancel);
        StoreUI[2].SetActive(true);
        StoreUI[3].SetActive(false);
        buyQuantity = 1;
    }
    public void Button_Buy()
    {
        BGM.PlayOneShot(buy);
        StoreUI[2].SetActive(true);
        StoreUI[3].SetActive(false);
        switch (StoreColliderControl.who)
        {
            case 1:
                CoinControl.P1CoinTotal -= totalCoin;
                switch (whyProps)
                {
                    case 1:
                        PropsControl.P1Props[0] += buyQuantity;
                        break;

                    case 2:
                        PropsControl.P1Props[1] += buyQuantity;
                        break;

                    case 3:
                        PropsControl.P1Props[2] += buyQuantity;
                        break;

                    case 4:
                        PropsControl.P1Props[3] += buyQuantity;
                        break;

                    case 5:
                        PropsControl.P1Props[4] += buyQuantity;
                        break;

                    case 6:
                        PropsControl.P1Props[5] += buyQuantity;
                        break;

                    case 7:
                        PropsControl.P1Props[6] += buyQuantity;
                        break;
                }
                break;

            case 2:
                CoinControl.P2CoinTotal -= totalCoin;
                switch (whyProps)
                {
                    case 1:
                        PropsControl.P2Props[0] += buyQuantity;
                        break;

                    case 2:
                        PropsControl.P2Props[1] += buyQuantity;
                        break;

                    case 3:
                        PropsControl.P2Props[2] += buyQuantity;
                        break;

                    case 4:
                        PropsControl.P2Props[3] += buyQuantity;
                        break;

                    case 5:
                        PropsControl.P2Props[4] += buyQuantity;
                        break;

                    case 6:
                        PropsControl.P2Props[5] += buyQuantity;
                        break;

                    case 7:
                        PropsControl.P2Props[6] += buyQuantity;
                        break;
                }
                break;

            case 3:
                CoinControl.P3CoinTotal -= totalCoin;
                switch (whyProps)
                {
                    case 1:
                        PropsControl.P3Props[0] += buyQuantity;
                        break;

                    case 2:
                        PropsControl.P3Props[1] += buyQuantity;
                        break;

                    case 3:
                        PropsControl.P3Props[2] += buyQuantity;
                        break;

                    case 4:
                        PropsControl.P3Props[3] += buyQuantity;
                        break;

                    case 5:
                        PropsControl.P3Props[4] += buyQuantity;
                        break;

                    case 6:
                        PropsControl.P3Props[5] += buyQuantity;
                        break;

                    case 7:
                        PropsControl.P3Props[6] += buyQuantity;
                        break;
                }
                break;

            case 4:
                CoinControl.P4CoinTotal -= totalCoin;
                switch (whyProps)
                {
                    case 1:
                        PropsControl.P4Props[0] += buyQuantity;
                        break;

                    case 2:
                        PropsControl.P4Props[1] += buyQuantity;
                        break;

                    case 3:
                        PropsControl.P4Props[2] += buyQuantity;
                        break;

                    case 4:
                        PropsControl.P4Props[3] += buyQuantity;
                        break;

                    case 5:
                        PropsControl.P4Props[4] += buyQuantity;
                        break;

                    case 6:
                        PropsControl.P4Props[5] += buyQuantity;
                        break;

                    case 7:
                        PropsControl.P4Props[6] += buyQuantity;
                        break;
                }
                break;
        }
        haveBuy = true;
        CatAnimatorControl.isHappy = true;
        buyQuantity = 1;
    }
    IEnumerator ChangeCamera()
    {
        BGM.PlayOneShot(close);
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
        DiceUIControl.isDiceUI = true;
        StoreColliderControl.isStoreNotStopUI = false;
    }

    void Limit()
    {
        BGM.PlayOneShot(select);
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
        howMuchCoin[0] = 15;
        howMuchCoin[1] = 25;
        howMuchCoin[2] = 35;
        howMuchCoin[3] = 30;
        howMuchCoin[4] = 20;
        howMuchCoin[5] = 50;
    }
}
