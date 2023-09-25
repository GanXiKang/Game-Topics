using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class CowPowerControl : MonoBehaviour
{
    public NavMeshAgent agent;

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

    private void OnTriggerEnter(Collider other)
    {
        if (AnimalsPowerControl.cowUsePower)
        {
            if (other.tag == "P1")
            {
                
            }
            if (other.tag == "P2")
            {
                
            }
            if (other.tag == "P3")
            { 
                
            }
            if (other.tag == "P4")
            {
                
            }
        }
    }
}
