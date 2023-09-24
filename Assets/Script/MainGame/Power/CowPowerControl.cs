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

    private void OnCollisionEnter(Collision collision)
    {
        if (AnimalsPowerControl.cowUsePower)
        {
            if (collision.tag == "P1")
            {
                print("1");
            }
            if (other.tag == "P2")
            {
                print("2");
            }
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        if (AnimalsPowerControl.cowUsePower)
        {
            if (other.tag == "P1")
            {
                print("1");
            }
            if (other.tag == "P2")
            {
                print("2");
            }
            if (other.tag == "P3")
            { 
                print("3");
            }
            if (other.tag == "P4")
            {
                print("4");
            }
        }
    }
}
