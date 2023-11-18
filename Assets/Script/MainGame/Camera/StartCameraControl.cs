using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartCameraControl : MonoBehaviour
{
    public GameObject[] c = new GameObject[7]; 

    void Start()
    {
        StartCoroutine(CameraShow());
    }

    IEnumerator CameraShow()
    {
        yield return new WaitForSeconds(1f);
        c[6].SetActive(true);
        DiceUIControl.isDiceUI = false;
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
        AnimatorControl.isP1Wave = true;
        AnimatorControl.isP2Wave = true;
        AnimatorControl.isP3Wave = true;
        AnimatorControl.isP4Wave = true;
        yield return new WaitForSeconds(1.3f);
        c[0].SetActive(false);
        DiceUIControl.isDiceUI = true;
        AnimatorControl.isP1Wave = false;
        AnimatorControl.isP2Wave = false;
        AnimatorControl.isP3Wave = false;
        AnimatorControl.isP4Wave = false;
    }
}
