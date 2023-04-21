using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MG1_InstantiateControl : MonoBehaviour
{
    public GameObject scissors;
    public GameObject stone;
    public GameObject cloth;
    public Transform playerBrand;
    public Transform bossBrand;

    public GameObject tiger;
    public Transform playerIns;

    void Start()
    {
        playerBrand.transform.Rotate(90, 0, 0);
        bossBrand.transform.Rotate(90, 0, 0);

        tiger.transform.localScale = new Vector3(2, 2, 2);
        Instantiate(tiger, playerIns.transform.position, playerIns.transform.rotation);
    }
    void Update()
    {
        if (MG1_GameControl.playWhat == 1)
        {
            Instantiate(scissors, playerBrand.transform.position, playerBrand.transform.rotation);
        }
        if (MG1_GameControl.playWhat == 2)
        {
            Instantiate(stone, playerBrand.transform.position, playerBrand.transform.rotation);
        }
        if (MG1_GameControl.playWhat == 3)
        {
            Instantiate(cloth, playerBrand.transform.position, playerBrand.transform.rotation);
        }
    }
}
