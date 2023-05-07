using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MG5_GameEffectsControl : MonoBehaviour
{
    public GameObject effects;
    void FixedUpdate()
    {
        if (MG5_GameResultControl.isEffects)
        {
            Instantiate(effects, transform.position, transform.rotation);
            MG5_GameResultControl.isEffects = false;
        }
    }
}
