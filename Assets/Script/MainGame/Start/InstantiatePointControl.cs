using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InstantiatePointControl : MonoBehaviour
{
    public GameObject[] insPoint = new GameObject[4];
    public GameObject[] animals = new GameObject[4];

    void Start()
    {
        insP1();
        insP2();
        insP3();
        insP4();
    }
    void insP1()
    {
        if (Menu_ChoosePlayer.whyP1 == 1)
        {
            Instantiate(animals[0], insPoint[0].transform.position, insPoint[0].transform.rotation);
        }
        else if (Menu_ChoosePlayer.whyP1 == 2)
        {
            Instantiate(animals[1], insPoint[0].transform.position, insPoint[0].transform.rotation);
        }
        else if (Menu_ChoosePlayer.whyP1 == 3)
        {
            Instantiate(animals[2], insPoint[0].transform.position, insPoint[0].transform.rotation);
        }
        else if (Menu_ChoosePlayer.whyP1 == 4)
        {
            Instantiate(animals[3], insPoint[0].transform.position, insPoint[0].transform.rotation);
        }
    }
    void insP2()
    {
        if (Menu_ChoosePlayer.whyP2 == 1)
        {
            Instantiate(animals[0], insPoint[1].transform.position, insPoint[1].transform.rotation);
        }
        else if (Menu_ChoosePlayer.whyP2 == 2)
        {
            Instantiate(animals[1], insPoint[1].transform.position, insPoint[1].transform.rotation);
        }
        else if (Menu_ChoosePlayer.whyP2 == 3)
        {
            Instantiate(animals[2], insPoint[1].transform.position, insPoint[1].transform.rotation);
        }
        else if (Menu_ChoosePlayer.whyP2 == 4)
        {
            Instantiate(animals[3], insPoint[1].transform.position, insPoint[1].transform.rotation);
        }
    }
    void insP3()
    {
        if (Menu_ChoosePlayer.whyP3 == 1)
        {
            Instantiate(animals[0], insPoint[2].transform.position, insPoint[2].transform.rotation);
        }
        else if (Menu_ChoosePlayer.whyP3 == 2)
        {
            Instantiate(animals[1], insPoint[2].transform.position, insPoint[2].transform.rotation);
        }
        else if (Menu_ChoosePlayer.whyP3 == 3)
        {
            Instantiate(animals[2], insPoint[2].transform.position, insPoint[2].transform.rotation);
        }
        else if (Menu_ChoosePlayer.whyP3 == 4)
        {
            Instantiate(animals[3], insPoint[2].transform.position, insPoint[2].transform.rotation);
        }
    }
    void insP4()
    {
        if (Menu_ChoosePlayer.whyP4 == 1)
        {
            Instantiate(animals[0], insPoint[3].transform.position, insPoint[3].transform.rotation);
        }
        else if (Menu_ChoosePlayer.whyP4 == 2)
        {
            Instantiate(animals[1], insPoint[3].transform.position, insPoint[3].transform.rotation);
        }
        else if (Menu_ChoosePlayer.whyP4 == 3)
        {
            Instantiate(animals[2], insPoint[3].transform.position, insPoint[3].transform.rotation);
        }
        else if (Menu_ChoosePlayer.whyP4 == 4)
        {
            Instantiate(animals[3], insPoint[3].transform.position, insPoint[3].transform.rotation);
        }
    }
}
