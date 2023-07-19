using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RoundUIControl : MonoBehaviour
{
    public Text whoRound;
    public Text CoinTotal;

    void Update()
    {
        switch (ChangeCameraControl.changeCameraNum)
        {
            case 1:
                whoRound.text = "P1";
                whoRound.color = Color.red;
                CoinTotal.text = "Coin :" + CoinControl.P1CoinTotal.ToString();
                break;

            case 2:
                whoRound.text = "P2";
                whoRound.color = Color.yellow;
                CoinTotal.text = "Coin :" + CoinControl.P2CoinTotal.ToString();
                break;

            case 3:
                whoRound.text = "P3";
                whoRound.color = Color.green;
                CoinTotal.text = "Coin :" + CoinControl.P3CoinTotal.ToString();
                break;

            case 4:
                whoRound.text = "P4";
                whoRound.color = Color.blue;
                CoinTotal.text = "Coin :" + CoinControl.P4CoinTotal.ToString();
                break;
        }
    }
}
