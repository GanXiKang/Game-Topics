using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dice : MonoBehaviour
{
    public static float diceNum = 0;

    void Update()
    {
        if (Input.GetKeyDown("space"))
        {
            diceNum = Random.Range(1, 7);
            Debug.Log(diceNum);
        }
    }
}
