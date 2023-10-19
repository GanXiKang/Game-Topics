using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimalsExpressionControl : MonoBehaviour
{
    SkinnedMeshRenderer smr;

    public Material[] expression = new Material[4];

    bool isBlink = true;

    void Start()
    {
        smr = GetComponent<SkinnedMeshRenderer>();
    }

    void Update()
    {
        if (isBlink)
        {
            print("ok");
            StartCoroutine(AnimalsBlink());
        }
    }
    
    IEnumerator AnimalsBlink()
    {
        isBlink = false;
        smr.material = expression[1];
        yield return new WaitForSeconds(0.1f);
        smr.material = expression[2];
        yield return new WaitForSeconds(0.1f);
        smr.material = expression[3];
        yield return new WaitForSeconds(0.1f);
        smr.material = expression[2];
        yield return new WaitForSeconds(0.1f);
        smr.material = expression[1];
        yield return new WaitForSeconds(0.1f);
        smr.material = expression[0];
        yield return new WaitForSeconds(10f);
        isBlink = true;

    }
}
