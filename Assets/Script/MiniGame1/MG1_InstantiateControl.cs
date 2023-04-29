using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MG1_InstantiateControl : MonoBehaviour
{
    public GameObject scissors;
    public GameObject stone;
    public GameObject cloth;
    public Transform playerBrand, bossBrand;

    public GameObject[] animals = new GameObject[4];
    public Transform playerIns;

    void Start()
    {
        playerBrand.transform.Rotate(90, 0, 0);
        bossBrand.transform.Rotate(90, 0, 0);

        if (MG1_BoxColliderControl.p == 1)
        {
            Instantiate(animals[0], playerIns.transform.position, playerIns.transform.rotation);
        }
        if (MG1_BoxColliderControl.p == 2)
        {
            Instantiate(animals[1], playerIns.transform.position, playerIns.transform.rotation);
        }
        if (MG1_BoxColliderControl.p == 3)
        {
            Instantiate(animals[2], playerIns.transform.position, playerIns.transform.rotation);
        }
        if (MG1_BoxColliderControl.p == 4)
        {
            Instantiate(animals[3], playerIns.transform.position, playerIns.transform.rotation);
        }
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
}
