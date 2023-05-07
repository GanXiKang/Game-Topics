using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MG4_GameEffectsControl : MonoBehaviour
{
    public GameObject effects;
    void FixedUpdate()
    {
        if (MG4_EndControl.isEffects)
        {
            Instantiate(effects, transform.position, transform.rotation);
            MG4_EndControl.isEffects = false;
        }
    }
}
