using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dice : MonoBehaviour
{
    float diceNum = 0;
    public static float totalNum = 0;
    public static bool isThrow = false;

    void Update()
    {
        if (Input.GetKeyDown("space"))
        {
            diceNum = Random.Range(1, 7);
            Debug.Log(diceNum);
            isThrow = true;
            totalNum += diceNum;
        }

    }
}