using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraControl : MonoBehaviour
{
    public GameObject P1_FrontCamera, P1_BackCamera, P2_FrontCamera, P2_BackCamera, P3_FrontCamera, P3_BackCamera, P4_FrontCamera, P4_BackCamera;

    void Update()
    {
        if (Dice.P1_isThrow == true)
        {
            StartCoroutine(P1_ChangeCamera());
        }
        else
        {
            StopCoroutine(P1_ChangeCamera());
        }

        if (Dice.P2_isThrow == true)
        {
            StartCoroutine(P2_ChangeCamera());
        }
        else
        {
            StopCoroutine(P2_ChangeCamera());
        }

        if (Dice.P3_isThrow == true)
        {
            StartCoroutine(P3_ChangeCamera());
        }
        else
        {
            StopCoroutine(P3_ChangeCamera());
        }

        if (Dice.P4_isThrow == true)
        {
            StartCoroutine(P4_ChangeCamera());
        }
        else
        {
            StopCoroutine(P4_ChangeCamera());
        }
    }

    IEnumerator P1_ChangeCamera()
    {
        P1_BackCamera.SetActive(false);
        P1_FrontCamera.SetActive(true);
        yield return new WaitForSeconds(5f);
        Dice.P1_isThrow = false;
        P2_BackCamera.SetActive(true);
        P1_FrontCamera.SetActive(false);
    }

    IEnumerator P2_ChangeCamera()
    {
        P2_BackCamera.SetActive(false);
        P2_FrontCamera.SetActive(true);
        yield return new WaitForSeconds(5f);
        Dice.P2_isThrow = false;
        P3_BackCamera.SetActive(true);
        P2_FrontCamera.SetActive(false);
    }

    IEnumerator P3_ChangeCamera()
    {
        P3_BackCamera.SetActive(false);
        P3_FrontCamera.SetActive(true);
        yield return new WaitForSeconds(5f);
        Dice.P3_isThrow = false;
        P4_BackCamera.SetActive(true);
        P3_FrontCamera.SetActive(false);
    }

    IEnumerator P4_ChangeCamera()
    {
        P4_BackCamera.SetActive(false);
        P4_FrontCamera.SetActive(true);
        yield return new WaitForSeconds(5f);
        Dice.P4_isThrow = false;
        P1_BackCamera.SetActive(true);
        P4_FrontCamera.SetActive(false);
    }
}
