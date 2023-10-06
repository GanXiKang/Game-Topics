using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MG3_Cup1Control : MonoBehaviour
{
    public Transform targetA, targetB, targetC; 

    bool isNewRound = true;
    float elapsedTime; 
    Vector3 startPosition;

    void Update()
    {
        //if (ObjectMoveControl.isMove && isNewRound)
        //{
        //    StartCoroutine(MoveSemiCircleRound1());
        //}
    }
    //private IEnumerator MoveSemiCircleRound1()
    //{
    //    isNewRound = false;

    //    startPosition = transform.position;
    //    elapsedTime = 0;
    //    while (elapsedTime < ObjectMoveControl.duration)
    //    {
    //        float t = elapsedTime / ObjectMoveControl.duration;

    //        float sinValue = Mathf.Sin(t * Mathf.PI);
    //        float y = Mathf.Lerp(0, 2, (sinValue + 1) / 2);

    //        transform.position = Vector3.Lerp(startPosition, targetB.position, t) + new Vector3(0, 0, -2) * y;

    //        elapsedTime += Time.deltaTime;
    //        yield return null;
    //    }
    //    transform.position = targetB.position;

    //    startPosition = transform.position;
    //    elapsedTime = 0;
    //    while (elapsedTime < ObjectMoveControl.duration)
    //    {
    //        float t = elapsedTime / ObjectMoveControl.duration;

    //        float sinValue = Mathf.Sin(t * Mathf.PI);
    //        float y = Mathf.Lerp(0, 2, (sinValue + 1) / 2);

    //        transform.position = Vector3.Lerp(startPosition, targetC.position, t) + new Vector3(0, 0, -2) * y;

    //        elapsedTime += Time.deltaTime;
    //        yield return null;
    //    }
    //    transform.position = targetC.position;

    //    yield return new WaitForSeconds(ObjectMoveControl.duration);

    //    isNewRound = true;
    //}
}
