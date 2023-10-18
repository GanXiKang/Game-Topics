using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MGFinishAwardControl : MonoBehaviour
{
    public static int miniGame;
    public static bool isFinishMG = false, isWin = false;
    public static bool isBearCall, isSlothCall, isDolphinCall, isFoxCall, isTycoonCall, isOstrichCall;

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
                    isTycoonCall = true;
                    break;

                case 2:
                    isCoinAward = true;
                    isSlothCall = true;
                    break;

                case 3:
                    isPropsAward = true;
                    isFoxCall = true;
                    break;

                case 4:
                    isCoinAward = true;
                    isOstrichCall = true;
                    break;

                case 5:
                    isPropsAward = true;
                    isBearCall = true;
                    break;

                case 6:
                    isCoinAward = true;
                    isDolphinCall = true;
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
                        systemText.text = "勝利獲得" + winCoin + "錢！";
                        SystemTestTextControl.isTimer = true;
                    }
                    else
                    {
                        CoinControl.P1CoinTotal += loseCoin;
                        systemText.text = "失敗獲得" + loseCoin + "錢！";
                        SystemTestTextControl.isTimer = true;
                    }
                    break;

                case 2:
                    if (isWin)
                    {
                        CoinControl.P2CoinTotal += winCoin;
                        systemText.text = "勝利獲得" + winCoin + "錢！";
                        SystemTestTextControl.isTimer = true;
                    }
                    else
                    {
                        CoinControl.P2CoinTotal += loseCoin;
                        systemText.text = "失敗獲得" + loseCoin + "錢！";
                        SystemTestTextControl.isTimer = true;
                    }
                    break;

                case 3:
                    if (isWin)
                    {
                        CoinControl.P3CoinTotal += winCoin;
                        systemText.text = "勝利獲得" + winCoin + "錢！";
                        SystemTestTextControl.isTimer = true;
                    }
                    else
                    {
                        CoinControl.P3CoinTotal += loseCoin;
                        systemText.text = "失敗獲得" + loseCoin + "錢！";
                        SystemTestTextControl.isTimer = true;
                    }
                    break;

                case 4:
                    if (isWin)
                    {
                        CoinControl.P4CoinTotal += winCoin;
                        systemText.text = "勝利獲得" + winCoin + "錢！";
                        SystemTestTextControl.isTimer = true;
                    }
                    else
                    {
                        CoinControl.P4CoinTotal += loseCoin;
                        systemText.text = "失敗獲得" + loseCoin + "錢！";
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
                        switch (miniGame)
                        {
                            case 1:
                                if (p == 1)
                                {
                                    PropsControl.P1Props[1] += 1;
                                    systemText.text = "勝利獲得" + PropsControl.propsName[1];
                                    systemText.fontSize = 15;
                                    SystemTestTextControl.isTimer = true;
                                }
                                else
                                {
                                    PropsControl.P1Props[2] += 1;
                                    systemText.text = "勝利獲得" + PropsControl.propsName[2];
                                    systemText.fontSize = 15;
                                    SystemTestTextControl.isTimer = true;
                                }
                                break;

                            case 3:
                                PropsControl.P1Props[6] += 1;
                                systemText.text = "勝利獲得" + PropsControl.propsName[6];
                                systemText.fontSize = 15;
                                SystemTestTextControl.isTimer = true;
                                break;

                            case 5:
                                if (p == 1)
                                {
                                    PropsControl.P1Props[4] += 1;
                                    systemText.text = "勝利獲得" + PropsControl.propsName[4];
                                    systemText.fontSize = 15;
                                    SystemTestTextControl.isTimer = true;
                                }
                                else
                                {
                                    PropsControl.P1Props[5] += 1;
                                    systemText.text = "勝利獲得" + PropsControl.propsName[5];
                                    systemText.fontSize = 15;
                                    SystemTestTextControl.isTimer = true;
                                }
                                break;
                        }
                    }
                    else
                    {
                        systemText.text = "失敗沒有獎勵！";
                        SystemTestTextControl.isTimer = true;
                    }
                    break;

                case 2:
                    if (isWin)
                    {
                        switch (miniGame)
                        {
                            case 1:
                                if (p == 1)
                                {
                                    PropsControl.P2Props[1] += 1;
                                    systemText.text = "勝利獲得" + PropsControl.propsName[1];
                                    systemText.fontSize = 15;
                                    SystemTestTextControl.isTimer = true;
                                }
                                else
                                {
                                    PropsControl.P2Props[2] += 1;
                                    systemText.text = "勝利獲得" + PropsControl.propsName[2];
                                    systemText.fontSize = 15;
                                    SystemTestTextControl.isTimer = true;
                                }
                                break;

                            case 3:
                                PropsControl.P2Props[6] += 1;
                                systemText.text = "勝利獲得" + PropsControl.propsName[6];
                                systemText.fontSize = 15;
                                SystemTestTextControl.isTimer = true;
                                break;

                            case 5:
                                if (p == 1)
                                {
                                    PropsControl.P2Props[4] += 1;
                                    systemText.text = "勝利獲得" + PropsControl.propsName[4];
                                    systemText.fontSize = 15;
                                    SystemTestTextControl.isTimer = true;
                                }
                                else
                                {
                                    PropsControl.P2Props[5] += 1;
                                    systemText.text = "勝利獲得" + PropsControl.propsName[5];
                                    systemText.fontSize = 15;
                                    SystemTestTextControl.isTimer = true;
                                }
                                break;
                        }
                    }
                    else
                    {
                        systemText.text = "失敗沒有獎勵！";
                        SystemTestTextControl.isTimer = true;
                    }
                    break;

                case 3:
                    if (isWin)
                    {
                        switch (miniGame)
                        {
                            case 1:
                                if (p == 1)
                                {
                                    PropsControl.P3Props[1] += 1;
                                    systemText.text = "勝利獲得" + PropsControl.propsName[1];
                                    systemText.fontSize = 15;
                                    SystemTestTextControl.isTimer = true;
                                }
                                else
                                {
                                    PropsControl.P3Props[2] += 1;
                                    systemText.text = "勝利獲得" + PropsControl.propsName[2];
                                    systemText.fontSize = 15;
                                    SystemTestTextControl.isTimer = true;
                                }
                                break;

                            case 3:
                                PropsControl.P3Props[6] += 1;
                                systemText.text = "勝利獲得" + PropsControl.propsName[6];
                                systemText.fontSize = 15;
                                SystemTestTextControl.isTimer = true;
                                break;

                            case 5:
                                if (p == 1)
                                {
                                    PropsControl.P3Props[4] += 1;
                                    systemText.text = "勝利獲得" + PropsControl.propsName[4];
                                    systemText.fontSize = 15;
                                    SystemTestTextControl.isTimer = true;
                                }
                                else
                                {
                                    PropsControl.P3Props[5] += 1;
                                    systemText.text = "勝利獲得" + PropsControl.propsName[5];
                                    systemText.fontSize = 15;
                                    SystemTestTextControl.isTimer = true;
                                }
                                break;
                        }
                    }
                    else
                    {
                        systemText.text = "失敗沒有獎勵！";
                        SystemTestTextControl.isTimer = true;
                    }
                    break;

                case 4:
                    if (isWin)
                    {
                        switch (miniGame)
                        {
                            case 1:
                                if (p == 1)
                                {
                                    PropsControl.P4Props[1] += 1;
                                    systemText.text = "勝利獲得" + PropsControl.propsName[1];
                                    systemText.fontSize = 15;
                                    SystemTestTextControl.isTimer = true;
                                }
                                else
                                {
                                    PropsControl.P4Props[2] += 1;
                                    systemText.text = "勝利獲得" + PropsControl.propsName[2];
                                    systemText.fontSize = 15;
                                    SystemTestTextControl.isTimer = true;
                                }
                                break;

                            case 3:
                                PropsControl.P4Props[6] += 1;
                                systemText.text = "勝利獲得" + PropsControl.propsName[6];
                                systemText.fontSize = 15;
                                SystemTestTextControl.isTimer = true;
                                break;

                            case 5:
                                if (p == 1)
                                {
                                    PropsControl.P4Props[4] += 1;
                                    systemText.text = "勝利獲得" + PropsControl.propsName[4];
                                    systemText.fontSize = 15;
                                    SystemTestTextControl.isTimer = true;
                                }
                                else
                                {
                                    PropsControl.P4Props[5] += 1;
                                    systemText.text = "勝利獲得" + PropsControl.propsName[5];
                                    systemText.fontSize = 15;
                                    SystemTestTextControl.isTimer = true;
                                }
                                break;
                        }
                    }
                    else
                    {
                        systemText.text = "失敗沒有獎勵！";
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
        TrueByAnimator();
        CameraMoveControl.isChangeCameraPoint = true;
        yield return new WaitForSeconds(2f);
        isWin = false;
        FalseByAnimator();
        CameraMoveControl.isChangeCameraPoint = false;
        ChangeCameraControl.changeCameraNum++;
        DiceUIControl.isDiceUI = true;
    }

    void TrueByAnimator()
    {
        switch (ChangeCameraControl.changeCameraNum)
        {
            case 1:
                if (isWin)
                {
                    AnimatorControl.isP1Win = true;
                }
                else
                {
                    AnimatorControl.isP1Lose = true;
                }
                break;

            case 2:
                if (isWin)
                {
                    AnimatorControl.isP2Win = true;
                }
                else
                {
                    AnimatorControl.isP2Lose = true;
                }
                break;

            case 3:
                if (isWin)
                {
                    AnimatorControl.isP3Win = true;
                }
                else
                {
                    AnimatorControl.isP3Lose = true;
                }
                break;

            case 4:
                if (isWin)
                {
                    AnimatorControl.isP4Win = true;
                }
                else
                {
                    AnimatorControl.isP4Lose = true;
                }
                break;
        }
    }
    void FalseByAnimator()
    {
        AnimatorControl.isP1Win = false;
        AnimatorControl.isP2Win = false;
        AnimatorControl.isP3Win = false;
        AnimatorControl.isP4Win = false;
        AnimatorControl.isP1Lose = false;
        AnimatorControl.isP2Lose = false;
        AnimatorControl.isP3Lose = false;
        AnimatorControl.isP4Lose = false;
    }
}

