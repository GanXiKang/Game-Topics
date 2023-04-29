using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MG6_InsPlayerControl : MonoBehaviour
{
    public GameObject[] animals = new GameObject[4];
    public Transform playerIns;

    void Start()
    {
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
}
