using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChickenEffectsControl : MonoBehaviour
{
    public static bool isEffects;

    void Start()
    {
        isEffects = true;
    }

    void Update()
    {
        if (!isEffects)
        {
            Destroy(gameObject);
        }
    }
}
