using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dice : MonoBehaviour
{
    float diceNum = 0;
    public static float totalNum = 0;
    public static bool isThrow = false;

    public float min = 1;
    public float max = 7;
    void Update()
    {
        if (Input.GetKeyDown("space"))
        {
            diceNum = Random.Range(min, max);
            Debug.Log(diceNum);
            isThrow = true;
            totalNum += diceNum;
        }
    }
}