using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class DogPowerControl : MonoBehaviour
{
    BoxCollider bc;

    public NavMeshAgent agent;

    void Start()
    {
        bc = GetComponent<BoxCollider>();
    }

    void Update()
    {
        if (AnimalsPowerControl.dogUsePower)
        {
            agent.speed = 15;
            bc.enabled = true;
        }
    }
}
