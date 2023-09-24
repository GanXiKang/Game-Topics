using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class CowPowerControl : MonoBehaviour
{
    NavMeshAgent agent;

    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
    }

    void Update()
    {
        if (AnimalsPowerControl.cowUsePower)
        {
            agent.speed = 20;
        }
        else 
        {
            agent.speed = 10;
        }
    }
}
