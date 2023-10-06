using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MG3_Cup3Control : MonoBehaviour
{
    public Transform targetA, targetB, targetC; 

    float elapsedTime; 
    Vector3 startPosition;

    void Update()
    {
        if (MG3_GameControl.DownCup)
        {
            transform.position = targetC.position;
        }
        if (MG3_GameControl.isCupMove)
        {
            StartCoroutine(MoveSemiCircleRound1());
        }
    }

    private IEnumerator MoveSemiCircleRound1()
    {
        yield return new WaitForSeconds(MG3_GameControl.duration);

        startPosition = transform.position;
        elapsedTime = 0;
        while (elapsedTime < MG3_GameControl.duration)
        {
            float t = elapsedTime / MG3_GameControl.duration;

            float sinValue = Mathf.Sin(t * Mathf.PI);
            float y = Mathf.Lerp(0, 2, (sinValue + 1) / 2);

            transform.position = Vector3.Lerp(startPosition, targetB.position, t) + new Vector3(0, 0, 2) * y;

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

            transform.position = Vector3.Lerp(startPosition, targetA.position, t) + new Vector3(0, 0, 2) * y;

            elapsedTime += Time.deltaTime;
            yield return null;
        }
        transform.position = targetA.position;
    }
}
