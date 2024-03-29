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
            agent.speed = 17f;
            bc.enabled = true;
        }
        else
        {
            agent.speed = 15f;
            bc.enabled = false;
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (AnimalsPowerControl.dogUsePower)
        {
            if (other.tag == "Point")
            {
                switch (ChangeCameraControl.changeCameraNum)
                {
                    case 1:
                        CoinControl.P1CoinTotal += 5;
                        break;

                    case 2:
                        CoinControl.P2CoinTotal += 5;
                        break;

                    case 3:
                        CoinControl.P3CoinTotal += 5;
                        break;

                    case 4:
                        CoinControl.P4CoinTotal += 5;
                        break;
                }
            }
        }
    }
}
