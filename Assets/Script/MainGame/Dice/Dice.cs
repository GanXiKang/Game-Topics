using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dice : MonoBehaviour
{
    float diceNum = 0, round = 0, who;
    public static float P1_totalNum = 0, P2_totalNum = 0, P3_totalNum = 0, P4_totalNum = 0;
    public static bool isThrow = false;

    public int min = 1;
    public int max = 7;
    void Update()
    {
        if (Input.GetKeyDown("space"))
        {
            diceNum = Random.Range(min, max);
            Debug.Log(diceNum);
            isThrow = true;

            who = round % 4;
            print(who);
            who++;
            print("w:" + who);
            switch (who)
            {
                case 1:
                    P1_totalNum += diceNum;
                    break;

                case 2:
                    P2_totalNum += diceNum;
                    break;

                case 3:
                    P3_totalNum += diceNum;
                    break;

                case 4:
                    P4_totalNum += diceNum;
                    break;
            }
        }
    }
}