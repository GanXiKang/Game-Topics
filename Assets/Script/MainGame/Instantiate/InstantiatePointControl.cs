using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InstantiatePointControl : MonoBehaviour
{
    public GameObject[] insPoint = new GameObject[4];
    public GameObject[] animals = new GameObject[12];

    public static bool isStart;

    void Start()
    {
        if (isStart)
        {
            DiceControl.P1_totalNum = 0;
            DiceControl.P2_totalNum = 0;
            DiceControl.P3_totalNum = 0;
            DiceControl.P4_totalNum = 0;
            Instantiate(animals[Menu_ChoosePlayer.whyP1 - 1], insPoint[0].transform.position, insPoint[0].transform.rotation);
            Instantiate(animals[Menu_ChoosePlayer.whyP2 - 1], insPoint[1].transform.position, insPoint[1].transform.rotation);
            if (Menu_ChoosePlayer.whoPlay >= 3)
            {
                Instantiate(animals[Menu_ChoosePlayer.whyP3 - 1], insPoint[2].transform.position, insPoint[2].transform.rotation);
            }
            if (Menu_ChoosePlayer.whoPlay == 4)
            {
                Instantiate(animals[Menu_ChoosePlayer.whyP4 - 1], insPoint[3].transform.position, insPoint[3].transform.rotation);
            }
            isStart = false;
        }
    }
}
