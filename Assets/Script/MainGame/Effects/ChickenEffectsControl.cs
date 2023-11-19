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
        chicken = GameObject.Find("Chicken");
    }

    void Update()
    {
        if (isEffects)
        {
            transform.position = new Vector3(chicken.transform.position.x, 0, chicken.transform.position.z);
        }
        else
        {
            Destroy(gameObject);
        }
    }
}
