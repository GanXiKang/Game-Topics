using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MG3_GameEffectsControl : MonoBehaviour
{
    public GameObject effects;

    bool isEffects = true;

    void FixedUpdate()
    {
        if (MG3_GameControl.isWin)
        {
            if (isEffects)
            {
                StartCoroutine(OpenEffects());
            }
        }
    }

    IEnumerator OpenEffects()
    {
        isEffects = false;
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
