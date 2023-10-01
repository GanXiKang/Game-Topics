using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MGFinishAwardControl : MonoBehaviour
{
    public static int miniGame;
    public static bool isFinishMG = false, iswin;

    public Text systemText;

    int winCoin = 30, loseCoin = 10;
    bool isCoinAward;

    void Update()
    {
        if (isFinishMG)
        {
            switch (miniGame)
            {
                case 1:

                    break;

                case 2:
                    break;

                case 3:
                    break;

                case 4:
                    break;

                case 5:
                    break;

                case 6:
                    break;
            }
            isFinishMG = false;
        }
    }
}
