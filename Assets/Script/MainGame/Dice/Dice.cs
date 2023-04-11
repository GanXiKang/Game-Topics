using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dice : MonoBehaviour
{
    float diceNum = 0, round = 0, who;
    public static float P1_totalNum = 0, P2_totalNum = 0, P3_totalNum = 0, P4_totalNum = 0;
    public static bool P1_isThrow = false, P2_isThrow = false, P3_isThrow = false, P4_isThrow = false;

    public int min = 1;
    public int max = 7;
    void Update()
    {
        if (Input.GetKeyDown("space"))
        {
            diceNum = Random.Range(min, max);
            Debug.Log(diceNum);

            who = round % 4;
            who++;
            switch (who)
            {
                case 1:
                    P1_totalNum += diceNum;
                    P1_isThrow = true;
                    break;

                case 2:
                    P2_totalNum += diceNum;
                    P2_isThrow = true;
                    break;

                case 3:
                    P3_totalNum += diceNum;
                    P3_isThrow = true;
                    break;

                case 4:
                    P4_totalNum += diceNum;
                    P4_isThrow = true;
                    break;
            }
            round++;
        }
    }
}