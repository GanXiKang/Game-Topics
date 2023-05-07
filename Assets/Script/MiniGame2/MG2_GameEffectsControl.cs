using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MG2_GameEffectsControl : MonoBehaviour
{
    public GameObject effects;
    void FixedUpdate()
    {
        if (MG2_GameResultControl.win)
        {
            Instantiate(effects, transform.position, transform.rotation);
        }
    }
}
