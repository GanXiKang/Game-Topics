using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class AnimalsPowerSpeedControl : MonoBehaviour
{
    NavMeshAgent agent;

    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
    }
    void Update()
    {
        if (AnimalsPowerControl.rabbitUsePower)
        {
            agent.speed = 18f;
        }
        else
        {
            agent.speed = 15f;
        }

        if (AnimalsPowerControl.horseUsePower)
        {
            agent.speed = 20f;
        }
        else
        {
            agent.speed = 15f;
        }
    }
}
