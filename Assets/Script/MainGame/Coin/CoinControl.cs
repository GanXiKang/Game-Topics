using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CoinControl : MonoBehaviour
{
    public static int P1CoinTotal, P2CoinTotal, P3CoinTotal, P4CoinTotal;

    public int initialCoin = 20;
    public Text systemText;

    int howMuchSteal, stealWho, stealQuantity = 0;

    private void Start()
    {
        P1CoinTotal = initialCoin;
        P2CoinTotal = initialCoin;
        P3CoinTotal = initialCoin;
        P4CoinTotal = initialCoin;
    }

    void Update()
    {
        Limit();

        if (BagUIControl.isThief)
        {
            howMuchSteal = Random.Range(3, 6);

            switch (ChangeCameraControl.changeCameraNum)
            {
                case 1:
                    stealWho = Random.Range(1, Menu_ChoosePlayer.whoPlay);
                    switch (stealWho)
                    {
                        case 1:
                            if (!AnimalsPowerControl.chickenUsePower || Menu_ChoosePlayer.whyP2 != 10)
                            {
                                AnimatorControl.isP1Win = true;
                                stealQuantity = P2CoinTotal * howMuchSteal / 10;
                                systemText.text = "偷" + RoundUIControl.Player[2].ToString() + stealQuantity.ToString() + "貓貓幣";
                                SystemTestTextControl.isTimer = true;
                                P2CoinTotal -= stealQuantity;
                                P1CoinTotal += stealQuantity;
                            }
                            else
                            {
                                AnimatorControl.isP1Lose = true;
                                systemText.text = "偷不到鷄的貓貓幣";
                                SystemTestTextControl.isTimer = true;
                            }
                            break;

                        case 2:
                            if (!AnimalsPowerControl.chickenUsePower || Menu_ChoosePlayer.whyP3 != 10)
                            {
                                AnimatorControl.isP1Win = true;
                                stealQuantity = P3CoinTotal * howMuchSteal / 10;
                                systemText.text = "偷" + RoundUIControl.Player[3].ToString() + stealQuantity.ToString() + "貓貓幣";
                                SystemTestTextControl.isTimer = true;
                                P3CoinTotal -= stealQuantity;
                                P1CoinTotal += stealQuantity;
                            }
                            else
                            {
                                AnimatorControl.isP1Lose = true;
                                systemText.text = "偷不到鷄的貓貓幣";
                                SystemTestTextControl.isTimer = true;
                            }
                            break;

                        case 3:
                            if (!AnimalsPowerControl.chickenUsePower || Menu_ChoosePlayer.whyP4 != 10)
                            {
                                AnimatorControl.isP1Win = true;
                                stealQuantity = P4CoinTotal * howMuchSteal / 10;
                                systemText.text = "偷" + RoundUIControl.Player[4].ToString() + stealQuantity.ToString() + "貓貓幣";
                                SystemTestTextControl.isTimer = true;
                                P4CoinTotal -= stealQuantity;
                                P1CoinTotal += stealQuantity;
                            }
                            else
                            {
                                AnimatorControl.isP1Lose = true;
                                systemText.text = "偷不到鷄的貓貓幣";
                                SystemTestTextControl.isTimer = true;
                            }
                            break;
                    }
                    break;

                case 2:
                    stealWho = Random.Range(1, Menu_ChoosePlayer.whoPlay);
                    switch (stealWho)
                    {
                        case 1:
                            if (!AnimalsPowerControl.chickenUsePower || Menu_ChoosePlayer.whyP1 != 10)
                            {
                                AnimatorControl.isP2Win = true;
                                stealQuantity = P1CoinTotal * howMuchSteal / 10;
                                systemText.text = "偷" + RoundUIControl.Player[1].ToString() + stealQuantity.ToString() + "貓貓幣";
                                SystemTestTextControl.isTimer = true;
                                P1CoinTotal -= stealQuantity;
                                P2CoinTotal += stealQuantity;
                            }
                            else
                            {
                                AnimatorControl.isP2Lose = true;
                                systemText.text = "偷不到鷄的貓貓幣";
                                SystemTestTextControl.isTimer = true;
                            }
                            break;

                        case 2:
                            if (!AnimalsPowerControl.chickenUsePower || Menu_ChoosePlayer.whyP3 != 10)
                            {
                                AnimatorControl.isP2Win = true;
                                stealQuantity = P3CoinTotal * howMuchSteal / 10;
                                systemText.text = "偷" + RoundUIControl.Player[3].ToString() + stealQuantity.ToString() + "貓貓幣";
                                SystemTestTextControl.isTimer = true;
                                P3CoinTotal -= stealQuantity;
                                P2CoinTotal += stealQuantity;
                            }
                            else
                            {
                                AnimatorControl.isP2Lose = true;
                                systemText.text = "偷不到鷄的貓貓幣";
                                SystemTestTextControl.isTimer = true;
                            }
                            break;

                        case 3:
                            if (!AnimalsPowerControl.chickenUsePower || Menu_ChoosePlayer.whyP4 != 10)
                            {
                                AnimatorControl.isP2Win = true;
                                stealQuantity = P4CoinTotal * howMuchSteal / 10;
                                systemText.text = "偷" + RoundUIControl.Player[4].ToString() + stealQuantity.ToString() + "貓貓幣";
                                SystemTestTextControl.isTimer = true;
                                P4CoinTotal -= stealQuantity;
                                P2CoinTotal += stealQuantity;
                            }
                            else 
                            {
                                AnimatorControl.isP2Lose = true;
                                systemText.text = "偷不到鷄的貓貓幣";
                                SystemTestTextControl.isTimer = true;
                            }
                            break;
                    }
                    break;

                case 3:
                    stealWho = Random.Range(1, Menu_ChoosePlayer.whoPlay);
                    switch (stealWho)
                    {
                        case 1:
                            if (!AnimalsPowerControl.chickenUsePower || Menu_ChoosePlayer.whyP1 != 10)
                            {
                                AnimatorControl.isP3Win = true;
                                stealQuantity = P1CoinTotal * howMuchSteal / 10;
                                systemText.text = "偷" + RoundUIControl.Player[1].ToString() + stealQuantity.ToString() + "貓貓幣";
                                SystemTestTextControl.isTimer = true;
                                P1CoinTotal -= stealQuantity;
                                P3CoinTotal += stealQuantity;
                            }
                            else
                            {
                                AnimatorControl.isP3Lose = true;
                                systemText.text = "偷不到鷄的貓貓幣";
                                SystemTestTextControl.isTimer = true;
                            }
                            break;

                        case 2:
                            if (!AnimalsPowerControl.chickenUsePower || Menu_ChoosePlayer.whyP2 != 10)
                            {
                                AnimatorControl.isP3Win = true;
                                stealQuantity = P2CoinTotal * howMuchSteal / 10;
                                systemText.text = "偷" + RoundUIControl.Player[2].ToString() + stealQuantity.ToString() + "貓貓幣";
                                SystemTestTextControl.isTimer = true;
                                P2CoinTotal -= stealQuantity;
                                P3CoinTotal += stealQuantity;
                            }
                            else
                            {
                                AnimatorControl.isP3Lose = true;
                                systemText.text = "偷不到鷄的貓貓幣";
                                SystemTestTextControl.isTimer = true;
                            }
                            break;

                        case 3:
                            if (!AnimalsPowerControl.chickenUsePower || Menu_ChoosePlayer.whyP4 != 10)
                            {
                                AnimatorControl.isP3Win = true;
                                stealQuantity = P4CoinTotal * howMuchSteal / 10;
                                systemText.text = "偷" + RoundUIControl.Player[4].ToString() + stealQuantity.ToString() + "貓貓幣";
                                SystemTestTextControl.isTimer = true;
                                P4CoinTotal -= stealQuantity;
                                P3CoinTotal += stealQuantity;
                            }
                            else
                            {
                                AnimatorControl.isP3Lose = true;
                                systemText.text = "偷不到鷄的貓貓幣";
                                SystemTestTextControl.isTimer = true;
                            }
                            break;

                    }
                    break;

                case 4:
                    stealWho = Random.Range(1, Menu_ChoosePlayer.whoPlay);
                    switch (stealWho)
                    {
                        case 1:
                            if (!AnimalsPowerControl.chickenUsePower || Menu_ChoosePlayer.whyP1 != 10)
                            {
                                AnimatorControl.isP4Win = true;
                                stealQuantity = P1CoinTotal * howMuchSteal / 10;
                                systemText.text = "偷" + RoundUIControl.Player[1].ToString() + stealQuantity.ToString() + "貓貓幣";
                                SystemTestTextControl.isTimer = true;
                                P1CoinTotal -= stealQuantity;
                                P4CoinTotal += stealQuantity;
                            }
                            else
                            {
                                AnimatorControl.isP4Lose = true;
                                systemText.text = "偷不到鷄的貓貓幣";
                                SystemTestTextControl.isTimer = true;
                            }
                            break;

                        case 2:
                            if (!AnimalsPowerControl.chickenUsePower || Menu_ChoosePlayer.whyP2 != 10)
                            {
                                AnimatorControl.isP4Win = true;
                                stealQuantity = P2CoinTotal * howMuchSteal / 10;
                                systemText.text = "偷" + RoundUIControl.Player[2].ToString() + stealQuantity.ToString() + "貓貓幣";
                                SystemTestTextControl.isTimer = true;
                                P2CoinTotal -= stealQuantity;
                                P4CoinTotal += stealQuantity;
                            }
                            else
                            {
                                AnimatorControl.isP4Lose = true;
                                systemText.text = "偷不到鷄的貓貓幣";
                                SystemTestTextControl.isTimer = true;
                            }
                            break;

                        case 3:
                            if (!AnimalsPowerControl.chickenUsePower || Menu_ChoosePlayer.whyP3 != 10)
                            {
                                AnimatorControl.isP4Win = true;
                                stealQuantity = P3CoinTotal * howMuchSteal / 10;
                                systemText.text = "偷" + RoundUIControl.Player[3].ToString() + stealQuantity.ToString() + "貓貓幣";
                                SystemTestTextControl.isTimer = true;
                                P3CoinTotal -= stealQuantity;
                                P4CoinTotal += stealQuantity;
                            }
                            else
                            {
                                AnimatorControl.isP4Lose = true;
                                systemText.text = "偷不到鷄的貓貓幣";
                                SystemTestTextControl.isTimer = true;
                            }
                            break;
                    }
                    break;
            }
            BagUIControl.isThief = false;
            Invoke("FalseByAnimtor", 1f);
        }
    }

    void Limit()
    {
        if (P1CoinTotal < 0)
        {
            P1CoinTotal = 0;
        }
        else if(P2CoinTotal < 0)
        {
            P2CoinTotal = 0;
        }
        else if (P3CoinTotal < 0)
        {
            P3CoinTotal = 0;
        }
        else if (P4CoinTotal < 0)
        {
            P4CoinTotal = 0;
        }
    }
    void FalseByAnimtor()
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
