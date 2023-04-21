using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MG1_InstantiateControl : MonoBehaviour
{
    public GameObject mouse;
    public Transform playerIns;

    void Start()
    {
        Instantiate(mouse, playerIns.transform.position, playerIns.transform.rotation);
    }
    void Update()
    {
        
    }
}
