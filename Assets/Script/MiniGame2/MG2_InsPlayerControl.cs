using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MG2_InsPlayerControl : MonoBehaviour
{
    public GameObject[] animals = new GameObject[4];
    public Transform playerIns;

    void Start()
    {
        if (MiniGameColliderControl.p == 1)
        {
            Instantiate(animals[0], playerIns.transform.position, playerIns.transform.rotation);
        }
        if (MiniGameColliderControl.p == 2)
        {
            Instantiate(animals[1], playerIns.transform.position, playerIns.transform.rotation);
        }
        if (MiniGameColliderControl.p == 3)
        {
            Instantiate(animals[2], playerIns.transform.position, playerIns.transform.rotation);
        }
        if (MiniGameColliderControl.p == 4)
        {
            Instantiate(animals[3], playerIns.transform.position, playerIns.transform.rotation);
        }
    }
}
