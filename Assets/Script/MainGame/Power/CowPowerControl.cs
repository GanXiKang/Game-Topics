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
            agent.speed = 15;
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
                    AnimatorControl.isP1Dizziness = true;
                    if (AnimalsPowerControl.dragonUsePower && Menu_ChoosePlayer.whyP1 == 5)
                    {
                        AnimalsPowerControl.dragonUsePower = false;
                        AnimatorControl.isP1Skill = false;
                    }
                }
            }
            if (other.tag == "P2")
            {
                if (Menu_ChoosePlayer.whyP2 != 2)
                {
                    IsStopUIControl.isCowPowerStopUI++;
                    isCowPowerStopP2 = true;
                    AnimatorControl.isP2Dizziness = true;
                    if (AnimalsPowerControl.dragonUsePower && Menu_ChoosePlayer.whyP2 == 5)
                    {
                        AnimalsPowerControl.dragonUsePower = false;
                        AnimatorControl.isP2Skill = false;
                    }
                }
            }
            if (other.tag == "P3")
            {
                if (Menu_ChoosePlayer.whyP3 != 2)
                {
                    IsStopUIControl.isCowPowerStopUI++;
                    isCowPowerStopP3 = true;
                    AnimatorControl.isP3Dizziness = true;
                    if (AnimalsPowerControl.dragonUsePower && Menu_ChoosePlayer.whyP3 == 5)
                    {
                        AnimalsPowerControl.dragonUsePower = false;
                        AnimatorControl.isP3Skill = false;
                    }
                }
            }
            if (other.tag == "P4")
            {
                if (Menu_ChoosePlayer.whyP4 != 2)
                {
                    IsStopUIControl.isCowPowerStopUI++;
                    isCowPowerStopP4 = true;
                    AnimatorControl.isP4Dizziness = true;
                    if (AnimalsPowerControl.dragonUsePower && Menu_ChoosePlayer.whyP4 == 5)
                    {
                        AnimalsPowerControl.dragonUsePower = false;
                        AnimatorControl.isP4Skill = false;
                    }
                }
            }
        }
    }
}
