using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MG6_FireWorkControl : MonoBehaviour
{
    public GameObject fireWork;

    bool openEffects = true;

    void Update()
    {
        if (MG6_EndControl.isEffects)
        {
            if (openEffects)
            {
                StartCoroutine(FireWorkShow());
            }  
        }
    }

    IEnumerator FireWorkShow()
    {
        openEffects = false;
        Instantiate(fireWork, transform.position, transform.rotation);
        yield return new WaitForSeconds(0.5f);
        Instantiate(fireWork, transform.position, transform.rotation);
        yield return new WaitForSeconds(0.5f);
        Instantiate(fireWork, transform.position, transform.rotation);
        yield return new WaitForSeconds(0.5f);
        Instantiate(fireWork, transform.position, transform.rotation);
        yield return new WaitForSeconds(0.5f);
        Instantiate(fireWork, transform.position, transform.rotation);
        yield return new WaitForSeconds(0.5f);
        Instantiate(fireWork, transform.position, transform.rotation);
        yield return new WaitForSeconds(0.5f);
        Instantiate(fireWork, transform.position, transform.rotation);
        yield return new WaitForSeconds(0.5f);
        Instantiate(fireWork, transform.position, transform.rotation);
        yield return new WaitForSeconds(0.5f);
        Instantiate(fireWork, transform.position, transform.rotation);
        yield return new WaitForSeconds(0.5f);
        Instantiate(fireWork, transform.position, transform.rotation);
        yield return new WaitForSeconds(0.5f);
    }
}
