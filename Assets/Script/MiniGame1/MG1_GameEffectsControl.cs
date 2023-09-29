using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MG1_GameEffectsControl : MonoBehaviour
{
    public GameObject effects;

    bool isEffects = true;

    void FixedUpdate()
    {
        if (MG1_GameControl.playerAniWin)
        {
            if (isEffects)
            {
                StartCoroutine(OpenEffects());
            }
        }
    }

    IEnumerator OpenEffects()
    {
        MG1_GameControl.isEffects = false;
        Instantiate(effects, transform.position, transform.rotation);
        yield return new WaitForSeconds(1f);
        Instantiate(effects, transform.position, transform.rotation);
        yield return new WaitForSeconds(1f);
        Instantiate(effects, transform.position, transform.rotation);
        yield return new WaitForSeconds(1f);
        Instantiate(effects, transform.position, transform.rotation);
        yield return new WaitForSeconds(1f);
        Instantiate(effects, transform.position, transform.rotation);
        yield return new WaitForSeconds(1f);
    }
}
