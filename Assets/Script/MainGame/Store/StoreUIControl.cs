using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StoreUIControl : MonoBehaviour
{
    public GameObject[] StoreUI = new GameObject[4];
    public Text[] PorpsCoin = new Text[7];
    public Text[] group3Text = new Text[5];

    public static bool isStore = false, isBuying = false;

    int[] howMuchCoin = new int[7];
    int whyProps, buyQuantity = 1;

    void Start()
    {
        howMuchCoin[0] = 100;
        howMuchCoin[1] = 90;
        howMuchCoin[2] = 80;
        howMuchCoin[3] = 70;
        howMuchCoin[4] = 60;
        howMuchCoin[5] = 50;
        howMuchCoin[6] = 40;

    }
    void Update()
    {
        if (isStore)
        {
            StoreUI[1].SetActive(true);
            isStore = false;
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
                    break;
            }
        }
    }

    public void Button_Yes()
    {
        isBuying = true;
        StoreUI[1].SetActive(false);
        StoreUI[2].SetActive(true);
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
    }
    public void Button_Add()
    {
        buyQuantity++;
    }
    public void Button_Reduce()
    {
        buyQuantity--;
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
    }
    IEnumerator ChangeCamera()
    {
        StoreUI[1].SetActive(false);
        StoreUI[2].SetActive(false);
        yield return new WaitForSeconds(1f);
        ChangeCameraControl.changeCameraNum++;
        Dice.isDiceUI = true;
    }
}
