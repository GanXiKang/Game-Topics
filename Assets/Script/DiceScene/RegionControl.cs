using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RegionControl : MonoBehaviour
{
    public GameObject[] region = new GameObject[7];

    void Start()
    {
        switch (Dice.who)
        {
            case 1:
                if (DiceControl.P1_totalNum <= 10)
                {
                    region[1].SetActive(true);
                }
                else if (DiceControl.P1_totalNum <= 20)
                {
                    region[2].SetActive(true);
                }
                else if (DiceControl.P1_totalNum <= 30)
                {
                    region[3].SetActive(true);
                }
                else if (DiceControl.P1_totalNum <= 40)
                {
                    region[4].SetActive(true);
                }
                else if (DiceControl.P1_totalNum <= 50)
                {
                    region[5].SetActive(true);
                }
                else if (DiceControl.P1_totalNum <= 60)
                {
                    region[6].SetActive(true);
                }
                break;

            case 2:
                if (DiceControl.P2_totalNum <= 10)
                {
                    region[1].SetActive(true);
                }
                else if (DiceControl.P2_totalNum <= 20)
                {
                    region[2].SetActive(true);
                }
                else if (DiceControl.P2_totalNum <= 30)
                {
                    region[3].SetActive(true);
                }
                else if (DiceControl.P2_totalNum <= 40)
                {
                    region[4].SetActive(true);
                }
                else if (DiceControl.P2_totalNum <= 50)
                {
                    region[5].SetActive(true);
                }
                else if (DiceControl.P2_totalNum <= 60)
                {
                    region[6].SetActive(true);
                }
                break;

            case 3:
                if (DiceControl.P3_totalNum <= 10)
                {
                    region[1].SetActive(true);
                }
                else if (DiceControl.P3_totalNum <= 20)
                {
                    region[2].SetActive(true);
                }
                else if (DiceControl.P3_totalNum <= 30)
                {
                    region[3].SetActive(true);
                }
                else if (DiceControl.P3_totalNum <= 40)
                {
                    region[4].SetActive(true);
                }
                else if (DiceControl.P3_totalNum <= 50)
                {
                    region[5].SetActive(true);
                }
                else if (DiceControl.P3_totalNum <= 60)
                {
                    region[6].SetActive(true);
                }
                break;

            case 4:
                if (DiceControl.P4_totalNum <= 10)
                {
                    region[1].SetActive(true);
                }
                else if (DiceControl.P4_totalNum <= 20)
                {
                    region[2].SetActive(true);
                }
                else if (DiceControl.P4_totalNum <= 30)
                {
                    region[3].SetActive(true);
                }
                else if (DiceControl.P4_totalNum <= 40)
                {
                    region[4].SetActive(true);
                }
                else if (DiceControl.P4_totalNum <= 50)
                {
                    region[5].SetActive(true);
                }
                else if (DiceControl.P4_totalNum <= 60)
                {
                    region[6].SetActive(true);
                }
                break;
        }
    }
}
