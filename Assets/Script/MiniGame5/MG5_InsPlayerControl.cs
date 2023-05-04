using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MG5_InsPlayerControl : MonoBehaviour
{
    public GameObject[] animals = new GameObject[4];

    void Start()
    {
        if (MiniGameColliderControl.p == 1)
        {
            Instantiate(animals[0], transform.position, transform.rotation);
        }
        if (MiniGameColliderControl.p == 2)
        {
            Instantiate(animals[1], transform.position, transform.rotation);
        }
        if (MiniGameColliderControl.p == 3)
        {
            Instantiate(animals[2], transform.position, transform.rotation);
        }
        if (MiniGameColliderControl.p == 4)
        {
            Instantiate(animals[3], transform.position, transform.rotation);
        }
    }
}
