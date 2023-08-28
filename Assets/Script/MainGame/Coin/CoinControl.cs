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
        if (BagUIControl.isThief)
        {
            howMuchSteal = Random.Range(4, 6);

            switch (ChangeCameraControl.changeCameraNum)
            {
                case 1:
                    stealWho = Random.Range(1, Menu_ChoosePlayer.whoPlay);
                    switch (stealWho)
                    {
                        case 1:
                            stealQuantity = P2CoinTotal * howMuchSteal / 10;
                            systemText.text = "ÕµµΩ¡À" + RoundUIControl.Player[2].ToString() + stealQuantity.ToString() + "ÂX£°";
                            systemText.fontSize = 12;
                            systemText.color = Color.black;
                            SystemTestTextControl.isTimer = true;
                            P2CoinTotal -= stealQuantity;
                            P1CoinTotal += stealQuantity;
                            break;

                        case 2:
                            stealQuantity = P3CoinTotal * howMuchSteal / 10;
                            P3CoinTotal -= stealQuantity;
                            P1CoinTotal += stealQuantity;
                            break;

                        case 3:
                            stealQuantity = P4CoinTotal * howMuchSteal / 10;
                            P4CoinTotal -= stealQuantity;
                            P1CoinTotal += stealQuantity;
                            break;
                    }
                    break;

                case 2:
                    stealWho = Random.Range(1, Menu_ChoosePlayer.whoPlay);
                    switch (stealWho)
                    {
                        case 1:
                            stealQuantity = P1CoinTotal * howMuchSteal / 10;
                            P1CoinTotal -= stealQuantity;
                            P2CoinTotal += stealQuantity;
                            break;

                        case 2:
                            stealQuantity = P3CoinTotal * howMuchSteal / 10;
                            P3CoinTotal -= stealQuantity;
                            P2CoinTotal += stealQuantity;
                            break;

                        case 3:
                            stealQuantity = P4CoinTotal * howMuchSteal / 10;
                            P4CoinTotal -= stealQuantity;
                            P2CoinTotal += stealQuantity;
                            break;
                    }
                    break;

                case 3:
                    stealWho = Random.Range(1, Menu_ChoosePlayer.whoPlay);
                    switch (stealWho)
                    {
                        case 1:
                            stealQuantity = P1CoinTotal * howMuchSteal / 10;
                            P1CoinTotal -= stealQuantity;
                            P3CoinTotal += stealQuantity;
                            break;

                        case 2:
                            stealQuantity = P2CoinTotal * howMuchSteal / 10;
                            P2CoinTotal -= stealQuantity;
                            P3CoinTotal += stealQuantity;
                            break;

                        case 3:
                            stealQuantity = P4CoinTotal * howMuchSteal / 10;
                            P4CoinTotal -= stealQuantity;
                            P3CoinTotal += stealQuantity;
                            break;
                    }
                    break;

                case 4:
                    stealWho = Random.Range(1, Menu_ChoosePlayer.whoPlay);
                    switch (stealWho)
                    {
                        case 1:
                            stealQuantity = P1CoinTotal * howMuchSteal / 10;
                            P1CoinTotal -= stealQuantity;
                            P4CoinTotal += stealQuantity;
                            break;

                        case 2:
                            stealQuantity = P2CoinTotal * howMuchSteal / 10;
                            P2CoinTotal -= stealQuantity;
                            P4CoinTotal += stealQuantity;
                            break;

                        case 3:
                            stealQuantity = P3CoinTotal * howMuchSteal / 10;
                            P3CoinTotal -= stealQuantity;
                            P4CoinTotal += stealQuantity;
                            break;
                    }
                    break;
            }
            BagUIControl.isThief = false;
        }
    }
}
