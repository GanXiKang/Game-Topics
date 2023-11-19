using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RunEffectsControl : MonoBehaviour
{
    void Update()
    {
        if (!AnimalsPowerControl.cowUsePower && !AnimalsPowerControl.rabbitUsePower && !AnimalsPowerControl.horseUsePower && !AnimalsPowerControl.dogUsePower)
        {
            Destroy(gameObject);
        }
    }
}
