using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MG4_GameEffectsControl : MonoBehaviour
{
    public GameObject effects;
    public Transform pointWin, pointLose;
    void FixedUpdate()
    {
        if (MG4_EndControl.winPlayer)
        {
            Instantiate(effects, pointWin.transform.position, pointWin.transform.rotation);
            MG4_EndControl.winPlayer = false;
        }
        if (MG4_EndControl.losePlayer)
        {
            Instantiate(effects, pointLose.transform.position, pointLose.transform.rotation);
            MG4_EndControl.losePlayer = false;
        }
    }
}
