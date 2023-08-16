using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DiceInstantionAnimalsControl : MonoBehaviour
{
    public GameObject[] animals = new GameObject[4];

    void Start()
    {
        if (Dice.who == 1)
        {
            for (int i = 1; i <= animals.Length; i++)
            {
                if (Menu_ChoosePlayer.whyP1 == i)
                {
                    Instantiate(animals[i - 1], transform.position, transform.rotation);
                }
            }
        }
        else if (Dice.who == 2)
        {
            for (int i = 1; i <= animals.Length; i++)
            {
                if (Menu_ChoosePlayer.whyP2 == i)
                {
                    Instantiate(animals[i - 1], transform.position, transform.rotation);
                }
            }
        }
        else if (Dice.who == 3)
        {
            for (int i = 1; i <= animals.Length; i++)
            {
                if (Menu_ChoosePlayer.whyP3 == i)
                {
                    Instantiate(animals[i - 1], transform.position, transform.rotation);
                }
            }
        }
        else if (Dice.who == 4)
        {
            for (int i = 1; i <= animals.Length; i++)
            {
                if (Menu_ChoosePlayer.whyP4 == i)
                {
                    Instantiate(animals[i - 1], transform.position, transform.rotation);
                }
            }
        }
    }
}
