using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DiceInstantionAnimalsControl : MonoBehaviour
{
    public GameObject[] animals = new GameObject[12];

    void Start()
    {
        switch (ChangeCameraControl.changeCameraNum)
        {
            case 1:
                for (int i = 1; i <= animals.Length; i++)
                {
                    if (Menu_ChoosePlayer.whyP1 == i)
                    {
                        Instantiate(animals[i - 1], transform.position, transform.rotation);
                    }
                }
                break;

            case 2:
                for (int i = 1; i <= animals.Length; i++)
                {
                    if (Menu_ChoosePlayer.whyP2 == i)
                    {
                        Instantiate(animals[i - 1], transform.position, transform.rotation);
                    }
                }
                break;

            case 3:
                for (int i = 1; i <= animals.Length; i++)
                {
                    if (Menu_ChoosePlayer.whyP3 == i)
                    {
                        Instantiate(animals[i - 1], transform.position, transform.rotation);
                    }
                }
                break;

            case 4:
                for (int i = 1; i <= animals.Length; i++)
                {
                    if (Menu_ChoosePlayer.whyP4 == i)
                    {
                        Instantiate(animals[i - 1], transform.position, transform.rotation);
                    }
                }
                break;
        }
    }
}
