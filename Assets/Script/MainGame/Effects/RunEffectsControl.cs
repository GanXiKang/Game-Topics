using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RunEffectsControl : MonoBehaviour
{
    GameObject cow, rabbit, horse, dog;

    void Start()
    {
        if (AnimalsPowerControl.cowUsePower)
        {
            cow = GameObject.Find("CowEffectsPoint");
        }
        if (AnimalsPowerControl.rabbitUsePower)
        {
            rabbit = GameObject.Find("RabbitEffectsPoint");
        }
        if (AnimalsPowerControl.horseUsePower)
        {
            horse = GameObject.Find("HorseEffectsPoint");
        }
        if (AnimalsPowerControl.dogUsePower)
        {
            dog = GameObject.Find("DogEffectsPoint");
        }
    }
    void Update()
    {
        if (!AnimalsPowerControl.cowUsePower && !AnimalsPowerControl.rabbitUsePower && !AnimalsPowerControl.horseUsePower && !AnimalsPowerControl.dogUsePower)
        {
            Destroy(gameObject);
        }
        else
        {
            if (AnimalsPowerControl.cowUsePower)
            {
                transform.position = cow.transform.position;
            }
            if (AnimalsPowerControl.rabbitUsePower)
            {
                transform.position = rabbit.transform.position;
            }
            if (AnimalsPowerControl.horseUsePower)
            {
                transform.position = horse.transform.position;
            }
            if (AnimalsPowerControl.dogUsePower)
            {
                transform.position = dog.transform.position;
            }
        }
    }
}
