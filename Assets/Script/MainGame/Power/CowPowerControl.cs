using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class CowPowerControl : MonoBehaviour
{
    BoxCollider bc;

    public NavMeshAgent agent;

    public static bool isCowPowerStopP1 = false, isCowPowerStopP2 = false, isCowPowerStopP3 = false, isCowPowerStopP4 = false;

    void Start()
    {
        bc = GetComponent<BoxCollider>();
    }
    void Update()
    {
        if (AnimalsPowerControl.cowUsePower)
        {
            agent.speed = 20;
            bc.enabled = true;
        }
        else 
        {
            agent.speed = 10;
            bc.enabled = false;
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (AnimalsPowerControl.cowUsePower)
        {
            if (other.tag == "P1")
            {
                if (Menu_ChoosePlayer.whyP1 != 2)
                {
                    IsStopUIControl.isCowPowerStopUI++;
                    isCowPowerStopP1 = true;
                }
            }
            if (other.tag == "P2")
            {
                if (Menu_ChoosePlayer.whyP2 != 2)
                {
                    IsStopUIControl.isCowPowerStopUI++;
                    isCowPowerStopP2 = true;
                }
            }
            if (other.tag == "P3")
            {
                if (Menu_ChoosePlayer.whyP3 != 2)
                {
                    IsStopUIControl.isCowPowerStopUI++;
                    isCowPowerStopP3 = true;
                }
            }
            if (other.tag == "P4")
            {
                if (Menu_ChoosePlayer.whyP4 != 2)
                {
                    IsStopUIControl.isCowPowerStopUI++;
                    isCowPowerStopP4 = true;
                }
            }
        }
    }
}
