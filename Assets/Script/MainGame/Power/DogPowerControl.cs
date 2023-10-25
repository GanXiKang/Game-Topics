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
        //if (AnimalsPowerControl.dogUsePower)
        //{
        //    agent.speed = 15;
        //    bc.enabled = true;
        //}
        //else
        //{
        //    agent.speed = 10;
        //    bc.enabled = false;
        //}
    }

    private void OnTriggerEnter(Collider other)
    {
        if (AnimalsPowerControl.dogUsePower)
        {
            if (other.tag == "Point")
            {
                CoinControl.P1CoinTotal += 5;
            }
        }
    }
}
