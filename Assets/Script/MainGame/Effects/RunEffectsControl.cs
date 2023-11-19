using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RunEffectsControl : MonoBehaviour
{
    GameObject cow, rabbit, horse, dog;
    float x, z;

    void Start()
    {
        if (AnimalsPowerControl.cowUsePower)
        {
            cow = GameObject.Find("Cow(Clone)");
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
            dog = GameObject.Find("Dog(Clone)");
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
                transform.position = new Vector3(cow.transform.position.x, transform.position.y, cow.transform.position.z + 0.5f);
            }
            if (AnimalsPowerControl.rabbitUsePower)
            {
                x = transform.position.x - rabbit.transform.position.x;
                z = transform.position.z - rabbit.transform.position.z;
                transform.position += new Vector3(x, 0, z);
            }
            if (AnimalsPowerControl.horseUsePower)
            {
                transform.position = new Vector3(horse.transform.position.x + 2f, transform.position.y, horse.transform.position.z);
            }
            if (AnimalsPowerControl.dogUsePower)
            {
                transform.position = new Vector3(dog.transform.position.x, transform.position.y, dog.transform.position.z + 0.5f);
            }
        }
    }
}
