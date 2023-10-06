using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MG3_Cup2Control : MonoBehaviour
{
    public Transform targetA, targetB, targetC;

    bool isNewRound = true;
    float elapsedTime; 
    Vector3 startPosition;

    void Update()
    {
        if (MG3_ButtonControl.DownCup)
        {
            transform.position = targetB.position;
        }
        if (MG3_GameControl.isMove && isNewRound)
        {
            StartCoroutine(MoveSemiCircleRound1());
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

            transform.position = Vector3.Lerp(startPosition, targetA.position, t) + new Vector3(0, 0, 2) * y;

            elapsedTime += Time.deltaTime;
            yield return null;
        }
        transform.position = targetA.position;

        yield return new WaitForSeconds(MG3_GameControl.duration);

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

        isNewRound = true;
    }
}
