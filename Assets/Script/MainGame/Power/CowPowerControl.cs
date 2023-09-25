using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class CowPowerControl : MonoBehaviour
{
    public NavMeshAgent agent;

    public static bool isCowPowerStopP1 = false, isCowPowerStopP2 = false, isCowPowerStopP3 = false, isCowPowerStopP4 = false;

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
                IsStopUIControl.isCowPowerStopUI++;
                isCowPowerStopP1 = true;
            }
            if (other.tag == "P2")
            {
                IsStopUIControl.isCowPowerStopUI++;
                isCowPowerStopP2 = true;
            }
            if (other.tag == "P3")
            {
                IsStopUIControl.isCowPowerStopUI++;
                isCowPowerStopP3 = true;
            }
            if (other.tag == "P4")
            {
                IsStopUIControl.isCowPowerStopUI++;
                isCowPowerStopP4 = true;
            }
        }
    }
}
