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
        Instantiate(stone, playerBrand.transform.position, playerBrand.transform.rotation);
        Instantiate(cloth, bossBrand.transform.position, bossBrand.transform.rotation);
    }
    void Update()
    {
        
    }
}
