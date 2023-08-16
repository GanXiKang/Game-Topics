using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinControl : MonoBehaviour
{
    public static int P1CoinTotal, P2CoinTotal, P3CoinTotal, P4CoinTotal;

    int Coin = 80;

    private void Start()
    {
        P1CoinTotal = Coin;
        P2CoinTotal = Coin;
        P3CoinTotal = Coin;
        P4CoinTotal = Coin;
    }
}
