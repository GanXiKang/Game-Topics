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
            rabbit = GameObject.Find("Rabbit(Clone)");
        }
        if (AnimalsPowerControl.horseUsePower)
        {
            horse = GameObject.Find("Horse(Clone)");
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
                transform.rotation = cow.transform.rotation;
            }
            if (AnimalsPowerControl.rabbitUsePower)
            {
                transform.position = rabbit.transform.position;
                transform.rotation = rabbit.transform.rotation;
            }
            if (AnimalsPowerControl.horseUsePower)
            {
                transform.position = horse.transform.position;
                transform.rotation = horse.transform.rotation;
            }
            if (AnimalsPowerControl.dogUsePower)
            {
                transform.position = dog.transform.position;
                transform.rotation = dog.transform.rotation;
            }
        }
    }
}
