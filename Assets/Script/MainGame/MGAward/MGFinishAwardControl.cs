using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MGFinishAwardControl : MonoBehaviour
{
    public static int miniGame;
    public static bool isFinishMG = false, isWin;

    public Text systemText;

    int winCoin = 30, loseCoin = 10, p;
    bool isCoinAward = false, isPropsAward = false;

    void Update()
    {
        if (isFinishMG)
        {
            switch (miniGame)
            {
                case 1:
                    isPropsAward = true;
                    break;

                case 2:
                    isCoinAward = true;
                    break;

                case 3:
                    isPropsAward = true;
                    break;

                case 4:
                    isCoinAward = true;
                    break;

                case 5:
                    isPropsAward = true;
                    break;

                case 6:
                    isCoinAward = true;
                    break;
            }
            StartCoroutine(AfterReceivingAward());
            isFinishMG = false;
        }
    }

    void Award()
    {
        if (isCoinAward)
        {
            switch (ChangeCameraControl.changeCameraNum)
            {
                case 1:
                    if (isWin)
                    {
                        CoinControl.P1CoinTotal += winCoin;
                        systemText.text = "小遊戲勝利獲得" + winCoin + "錢！";
                        SystemTestTextControl.isTimer = true;
                    }
                    else
                    {
                        CoinControl.P1CoinTotal += loseCoin;
                        systemText.text = "小遊戲失敗獲得" + loseCoin + "錢！";
                        SystemTestTextControl.isTimer = true;
                    }
                    break;

                case 2:
                    if (isWin)
                    {
                        CoinControl.P2CoinTotal += winCoin;
                        systemText.text = "小遊戲勝利獲得" + winCoin + "錢！";
                        SystemTestTextControl.isTimer = true;
                    }
                    else
                    {
                        CoinControl.P2CoinTotal += loseCoin;
                        systemText.text = "小遊戲失敗獲得" + loseCoin + "錢！";
                        SystemTestTextControl.isTimer = true;
                    }
                    break;

                case 3:
                    if (isWin)
                    {
                        CoinControl.P3CoinTotal += winCoin;
                        systemText.text = "小遊戲勝利獲得" + winCoin + "錢！";
                        SystemTestTextControl.isTimer = true;
                    }
                    else
                    {
                        CoinControl.P3CoinTotal += loseCoin;
                        systemText.text = "小遊戲失敗獲得" + loseCoin + "錢！";
                        SystemTestTextControl.isTimer = true;
                    }
                    break;

                case 4:
                    if (isWin)
                    {
                        CoinControl.P4CoinTotal += winCoin;
                        systemText.text = "小遊戲勝利獲得" + winCoin + "錢！";
                        SystemTestTextControl.isTimer = true;
                    }
                    else
                    {
                        CoinControl.P4CoinTotal += loseCoin;
                        systemText.text = "小遊戲失敗獲得" + loseCoin + "錢！";
                        SystemTestTextControl.isTimer = true;
                    }
                    break;
            }
            isCoinAward = false;
        }
        if (isPropsAward)
        {
            p = Random.Range(1, 3);
            switch (ChangeCameraControl.changeCameraNum)
            {
                case 1:
                    if (isWin)
                    {
                       
                    }
                    else
                    {
                        systemText.text = "小遊戲失敗沒有獎勵！";
                        SystemTestTextControl.isTimer = true;
                    }
                    break;

                case 2:
                    if (isWin)
                    {
                        
                    }
                    else
                    {
                        systemText.text = "小遊戲失敗沒有獎勵！";
                        SystemTestTextControl.isTimer = true;
                    }
                    break;

                case 3:
                    if (isWin)
                    {

                    }
                    else
                    {
                        systemText.text = "小遊戲失敗沒有獎勵！";
                        SystemTestTextControl.isTimer = true;
                    }
                    break;

                case 4:
                    if (isWin)
                    {
                        
                    }
                    else
                    {
                        systemText.text = "小遊戲失敗沒有獎勵！";
                        SystemTestTextControl.isTimer = true;
                    }
                    break;
            }
            isPropsAward = false;
        }
    }

    IEnumerator AfterReceivingAward()
    {
        Award();
        yield return new WaitForSeconds(2f);
        ChangeCameraControl.changeCameraNum++;
        DiceUIControl.isDiceUI = true;
    }
}
