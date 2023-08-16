using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinControl : MonoBehaviour
{
    public static int P1CoinTotal, P2CoinTotal, P3CoinTotal, P4CoinTotal;

    public int initialCoin = 80;

    private void Start()
    {
        P1CoinTotal = initialCoin;
        P2CoinTotal = initialCoin;
        P3CoinTotal = initialCoin;
        P4CoinTotal = initialCoin;
    }
}
