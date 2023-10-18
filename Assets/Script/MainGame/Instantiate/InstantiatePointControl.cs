using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InstantiatePointControl : MonoBehaviour
{
    public GameObject[] insPoint = new GameObject[4];
    public GameObject[] animals = new GameObject[12];

    public static bool isStart = true;
    void Start()
    {
        if (isStart)
        {
            if (Menu_ChoosePlayer.whoPlay == 4)
            {
                Instantiate(animals[Menu_ChoosePlayer.whyP4 - 1], insPoint[3].transform.position, insPoint[3].transform.rotation);
            }
            if (Menu_ChoosePlayer.whoPlay >= 3)
            {
                Instantiate(animals[Menu_ChoosePlayer.whyP3 - 1], insPoint[2].transform.position, insPoint[2].transform.rotation);
            }
            Instantiate(animals[Menu_ChoosePlayer.whyP1 - 1], insPoint[0].transform.position, insPoint[0].transform.rotation);
            Instantiate(animals[Menu_ChoosePlayer.whyP2 - 1], insPoint[1].transform.position, insPoint[1].transform.rotation);
            isStart = false;
        }
    }
}
