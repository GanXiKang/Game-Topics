using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MG5_GameEffectsControl : MonoBehaviour
{
    public GameObject effects;

    bool isEffects = true;

    void Update()
    {
        if (MG5_GameResultControl.win)
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
