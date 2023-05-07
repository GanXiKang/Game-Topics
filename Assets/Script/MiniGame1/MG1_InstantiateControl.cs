using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MG1_InstantiateControl : MonoBehaviour
{
    public GameObject scissors, stone, cloth;
    public Transform playerBrand, bossBrand;

    public GameObject[] animals = new GameObject[4];
    public Transform playerIns;

    void Start()
    {
        playerBrand.transform.Rotate(90, 0, 0);
        bossBrand.transform.Rotate(90, 0, 0);

        InsPlayer();
    }
    void Update()
    {
        if (MG1_GameControl.playWhat == 1)
        {
            Instantiate(scissors, playerBrand.transform.position, playerBrand.transform.rotation);
            MG1_GameControl.playWhat = 0;
        }
        if (MG1_GameControl.playWhat == 2)
        {
            Instantiate(stone, playerBrand.transform.position, playerBrand.transform.rotation);
            MG1_GameControl.playWhat = 0;
        }
        if (MG1_GameControl.playWhat == 3)
        {
            Instantiate(cloth, playerBrand.transform.position, playerBrand.transform.rotation);
            MG1_GameControl.playWhat = 0;
        }

        if (MG1_GameControl.AIplayWhat == 1)
        {
            Instantiate(scissors, bossBrand.transform.position, bossBrand.transform.rotation);
            MG1_GameControl.AIplayWhat = 0;
        }
        if (MG1_GameControl.AIplayWhat == 2)
        {
            Instantiate(stone, bossBrand.transform.position, bossBrand.transform.rotation);
            MG1_GameControl.AIplayWhat = 0;
        }
        if (MG1_GameControl.AIplayWhat == 3)
        {
            Instantiate(cloth, bossBrand.transform.position, bossBrand.transform.rotation);
            MG1_GameControl.AIplayWhat = 0;
        }
    }
    void InsPlayer()
    {
        if (MiniGameColliderControl.p == 1)
        {
            for (int i = 1; i < animals.Length; i++)
            {
                if (Menu_ChoosePlayer.whyP1 == i)
                {
                    Instantiate(animals[i - 1], playerIns.transform.position, playerIns.transform.rotation);
                }
            }
        }
        if (MiniGameColliderControl.p == 2)
        {
            for (int i = 1; i < animals.Length; i++)
            {
                if (Menu_ChoosePlayer.whyP2 == i)
                {
                    Instantiate(animals[i - 1], playerIns.transform.position, playerIns.transform.rotation);
                }
            }
        }
        if (MiniGameColliderControl.p == 3)
        {
            for (int i = 1; i < animals.Length; i++)
            {
                if (Menu_ChoosePlayer.whyP3 == i)
                {
                    Instantiate(animals[i - 1], playerIns.transform.position, playerIns.transform.rotation);
                }
            }
        }
        if (MiniGameColliderControl.p == 4)
        {
            for (int i = 1; i < animals.Length; i++)
            {
                if (Menu_ChoosePlayer.whyP4 == i)
                {
                    Instantiate(animals[i - 1], playerIns.transform.position, playerIns.transform.rotation);
                }
            }
        }
    }
}
