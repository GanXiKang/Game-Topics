using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChickenEffectsControl : MonoBehaviour
{
    public static bool isEffects;

    GameObject chicken;

    void Start()
    {
        isEffects = true;
        chicken = GameObject.Find("ChickenEffectsPoint");
    }

    void Update()
    {
        if (isEffects)
        {
            transform.position = chicken.transform.position;
        }
        else
        {
            Destroy(gameObject);
        }
    }
}
