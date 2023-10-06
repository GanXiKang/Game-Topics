using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MG3_Cup1Control : MonoBehaviour
{
    public Transform targetA, targetB, targetC;

    int nowPosition;
    bool isNewRound = true;
    float elapsedTime;
    Vector3 startPosition;

    void Update()
    {
        if (MG3_GameControl.isDownCup)
        {
            switch (MG3_GameControl.round)
            {
                case 1:
                    transform.position = targetA.position;
                    break;

                case 2:
                    transform.position = targetC.position;
                    break;

                case 3:
                    //transform.position = targetA.position;
                    break;
            }
        }
        if (MG3_GameControl.isCupMove && isNewRound)
        {
            switch (MG3_GameControl.round)
            {
                case 1:
                    StartCoroutine(MoveSemiCircleRound1());
                    break;

                case 2:
                    StartCoroutine(MoveSemiCircleRound2());
                    break;

                case 3:
                    StartCoroutine(MoveSemiCircleRound3());
                    break;
            }
        }
        if (MG3_ButtonControl.isOpenCup)
        {
            if (nowPosition == MG3_ButtonControl.openWhyCup)
            {
                transform.position += Vector3.up * 3f;
            }
        }
    }

    private IEnumerator MoveSemiCircleRound1()
    {
        isNewRound = false;

        startPosition = transform.position;
        elapsedTime = 0;
        while (elapsedTime < MG3_GameControl.duration)
        {
            float t = elapsedTime / MG3_GameControl.duration;

            float sinValue = Mathf.Sin(t * Mathf.PI);
            float y = Mathf.Lerp(0, 2, (sinValue + 1) / 2);

            transform.position = Vector3.Lerp(startPosition, targetB.position, t) + new Vector3(0, 0, -2) * y;

            elapsedTime += Time.deltaTime;
            yield return null;
        }
        transform.position = targetB.position;

        startPosition = transform.position;
        elapsedTime = 0;
        while (elapsedTime < MG3_GameControl.duration)
        {
            float t = elapsedTime / MG3_GameControl.duration;

            float sinValue = Mathf.Sin(t * Mathf.PI);
            float y = Mathf.Lerp(0, 2, (sinValue + 1) / 2);

            transform.position = Vector3.Lerp(startPosition, targetC.position, t) + new Vector3(0, 0, -2) * y;

            elapsedTime += Time.deltaTime;
            yield return null;
        }
        transform.position = targetC.position;

        yield return new WaitForSeconds(MG3_GameControl.duration);

        isNewRound = true;
    }
    private IEnumerator MoveSemiCircleRound2()
    {
        isNewRound = false;

        yield return null;

        isNewRound = true;
    }
    private IEnumerator MoveSemiCircleRound3()
    {
        isNewRound = false;

        yield return null;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "CupPointA")
        {
            nowPosition = 1;
        }
        else if (other.tag == "CupPointB")
        {
            nowPosition = 2;
        }
        else if (other.tag == "CupPointC")
        {
            nowPosition = 3;
        }
    }
}
