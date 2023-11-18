using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartCameraControl : MonoBehaviour
{
    public GameObject[] c = new GameObject[7]; 

    void Start()
    {
        StartCoroutine(OpeningCameraShow());
    }

    IEnumerator OpeningCameraShow()
    {
        c[7].SetActive(true);
        DiceUIControl.isDiceUI = false;
        yield return new WaitForSeconds(1f);
        c[7].SetActive(false);
        c[6].SetActive(true);
        yield return new WaitForSeconds(1f);
        c[6].SetActive(false);
        c[5].SetActive(true);
        yield return new WaitForSeconds(1f);
        c[5].SetActive(false);
        c[4].SetActive(true);
        yield return new WaitForSeconds(1f);
        c[4].SetActive(false);
        c[3].SetActive(true);
        yield return new WaitForSeconds(1f);
        c[3].SetActive(false);
        c[2].SetActive(true);
        yield return new WaitForSeconds(1f);
        c[2].SetActive(false);
        c[1].SetActive(true);
        yield return new WaitForSeconds(1f);
        c[1].SetActive(false);
        c[0].SetActive(true);
        yield return new WaitForSeconds(1.3f);
        c[0].SetActive(false);
        DiceUIControl.isDiceUI = true;
    }
}
