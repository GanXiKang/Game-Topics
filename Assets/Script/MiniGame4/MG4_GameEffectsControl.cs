using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MG4_GameEffectsControl : MonoBehaviour
{
    public GameObject effects;
    public Transform pointWin, pointLose;

    bool isEffects = true;

    void Update()
    {
        if (isEffects)
        {
            if (MG4_EndControl.winPlayer)
            {
                StartCoroutine(OpenEffects(1));
            }
            if (MG4_EndControl.losePlayer)
            {
                StartCoroutine(OpenEffects(2));
            }
        }
    }

    IEnumerator OpenEffects(int i)
    {
        isEffects = false;
        if (i == 1)
        {
            Instantiate(effects, pointWin.transform.position, pointWin.transform.rotation);
        }
        else
        {
            Instantiate(effects, pointLose.transform.position, pointLose.transform.rotation);
        }
        yield return new WaitForSeconds(1f);
        if (i == 1)
        {
            Instantiate(effects, pointWin.transform.position, pointWin.transform.rotation);
        }
        else
        {
            Instantiate(effects, pointLose.transform.position, pointLose.transform.rotation);
        }
        yield return new WaitForSeconds(1f);
        if (i == 1)
        {
            Instantiate(effects, pointWin.transform.position, pointWin.transform.rotation);
        }
        else
        {
            Instantiate(effects, pointLose.transform.position, pointLose.transform.rotation);
        }
        yield return new WaitForSeconds(1f);
        if (i == 1)
        {
            Instantiate(effects, pointWin.transform.position, pointWin.transform.rotation);
        }
        else
        {
            Instantiate(effects, pointLose.transform.position, pointLose.transform.rotation);
        }
        yield return new WaitForSeconds(1f);
        if (i == 1)
        {
            Instantiate(effects, pointWin.transform.position, pointWin.transform.rotation);
        }
        else
        {
            Instantiate(effects, pointLose.transform.position, pointLose.transform.rotation);
        }
        yield return new WaitForSeconds(1f);
    }
}
