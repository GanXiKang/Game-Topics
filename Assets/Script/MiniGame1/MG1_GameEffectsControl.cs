using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MG1_GameEffectsControl : MonoBehaviour
{
    public GameObject effects;
    void FixedUpdate()
    {
        if (MG1_GameControl.playerAniWin)
        {
            Instantiate(effects, transform.position, transform.rotation);
            MG1_GameControl.isEffects = false;
        }
    }
}
