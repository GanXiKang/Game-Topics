using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinControl : MonoBehaviour
{
    public static int P1CoinTotal, P2CoinTotal, P3CoinTotal, P4CoinTotal;

    public int initialCoin = 20;

    int howMuchSteal, stealWho, stealQuantity;

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
                            print(stealQuantity);
                            P2CoinTotal -= stealQuantity;
                            P1CoinTotal += stealQuantity;
                            break;

                        case 2:
                       
                            break;

                        case 3:
                            break;
                    }
                    break;

                case 2:
                    
                    break;

                case 3:
                    
                    break;

                case 4:
                    
                    break;
            }
            BagUIControl.isThief = false;
        }
    }
}
