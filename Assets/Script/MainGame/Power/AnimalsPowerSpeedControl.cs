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
        if (AnimalsPowerControl.rabbitUsePower || AnimalsPowerControl.horseUsePower)
        {
            agent.speed = 15f;
        }
        else
        {
            agent.speed = 12f;
        }
    }
}
