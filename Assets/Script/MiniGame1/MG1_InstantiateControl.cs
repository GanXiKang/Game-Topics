using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MG1_InstantiateControl : MonoBehaviour
{
    public GameObject tiger;
    public Transform playerIns;

    void Start()
    {

        Instantiate(tiger, playerIns.transform.position, playerIns.transform.rotation);
    }
    void Update()
    {
        
    }
}
