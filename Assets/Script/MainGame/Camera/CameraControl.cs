using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraControl : MonoBehaviour
{
    public GameObject P1_FrontCamera, P1_BackCamera, P2_FrontCamera, P2_BackCamera, P3_FrontCamera, P3_BackCamera, P4_FrontCamera, P4_BackCamera;

    void FixedUpdate()
    {
        if (Dice.P1_isThrow == true)
        {
            StartCoroutine(P1_ChangeCamera());
        }
        if (Dice.P2_isThrow == true)
        {
            StartCoroutine(P2_ChangeCamera());
        }
        if (Dice.P3_isThrow == true)
        {
            StartCoroutine(P3_ChangeCamera());
        }
        if (Dice.P4_isThrow == true)
        {
            StartCoroutine(P4_ChangeCamera());
        }
    }

    IEnumerator P1_ChangeCamera()
    {
        Dice.P1_isThrow = false;

        P1_FrontCamera.SetActive(true);
        P1_BackCamera.SetActive(false);
        yield return new WaitForSeconds(4f);
        P1_BackCamera.SetActive(true);
        P1_FrontCamera.SetActive(false);
        yield return new WaitForSeconds(2f);
        P2_BackCamera.SetActive(true);
        P1_BackCamera.SetActive(false);
    }

    IEnumerator P2_ChangeCamera()
    {
        Dice.P2_isThrow = false;

        P2_FrontCamera.SetActive(true);
        P2_BackCamera.SetActive(false);
        yield return new WaitForSeconds(4f);
        P2_BackCamera.SetActive(true);
        P2_FrontCamera.SetActive(false);
        yield return new WaitForSeconds(2f);
        P3_BackCamera.SetActive(true);
        P2_BackCamera.SetActive(false);
    }

    IEnumerator P3_ChangeCamera()
    {
        Dice.P3_isThrow = false;

        P3_FrontCamera.SetActive(true);
        P3_BackCamera.SetActive(false);
        yield return new WaitForSeconds(4f);
        P3_BackCamera.SetActive(true);
        P3_FrontCamera.SetActive(false);
        yield return new WaitForSeconds(2f);
        P4_BackCamera.SetActive(true);
        P3_BackCamera.SetActive(false);
    }

    IEnumerator P4_ChangeCamera()
    {
        Dice.P4_isThrow = false;

        P4_FrontCamera.SetActive(true);
        P4_BackCamera.SetActive(false);
        yield return new WaitForSeconds(4f);
        P4_BackCamera.SetActive(true);
        P4_FrontCamera.SetActive(false);
        yield return new WaitForSeconds(2f);
        P1_BackCamera.SetActive(true);
        P4_BackCamera.SetActive(false);
    }
}
