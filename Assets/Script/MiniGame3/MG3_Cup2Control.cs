using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MG3_Cup2Control : MonoBehaviour
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
                    transform.position = targetB.position;
                    break;

                case 2:
                    transform.position = targetB.position;
                    break;

                case 3:
                    transform.position = targetC.position;
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
                MG3_ButtonControl.isOpenCup = false;
                MG3_FoxControl.isLose = true;
                GameRound();
            }
            else
            {
                MG3_GameControl.isWin = false;
                MG3_ButtonControl.isOpenCup = false;
                MG3_FoxControl.isWin = true;
                Invoke("OpenStarCup", 1f);
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

        MG3_ButtonControl.isGuess = true;
        isNewRound = true;
    }
    private IEnumerator MoveSemiCircleRound2()
    {
        isNewRound = false;

        yield return new WaitForSeconds(MG3_GameControl.duration);

        startPosition = transform.position;
        elapsedTime = 0;
        while (elapsedTime < MG3_GameControl.duration)
        {
            float t = elapsedTime / MG3_GameControl.duration;

            float sinValue = Mathf.Sin(t * Mathf.PI);
            float y = Mathf.Lerp(0, 2, (sinValue + 1) / 2);

            transform.position = Vector3.Lerp(startPosition, targetC.position, t) + new Vector3(0, 0, 2) * y;

            elapsedTime += Time.deltaTime;
            yield return null;
        }
        transform.position = targetC.position;

        startPosition = transform.position;
        elapsedTime = 0;
        while (elapsedTime < MG3_GameControl.duration)
        {
            float t = elapsedTime / MG3_GameControl.duration;

            float sinValue = Mathf.Sin(t * Mathf.PI);
            float y = Mathf.Lerp(0, 2, (sinValue + 1) / 2);

            transform.position = Vector3.Lerp(startPosition, targetA.position, t) + new Vector3(0, 0, -2) * y;

            elapsedTime += Time.deltaTime;
            yield return null;
        }
        transform.position = targetA.position;

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

            transform.position = Vector3.Lerp(startPosition, targetA.position, t) + new Vector3(0, 0, -2) * y;

            elapsedTime += Time.deltaTime;
            yield return null;
        }
        transform.position = targetA.position;

        startPosition = transform.position;
        elapsedTime = 0;
        while (elapsedTime < MG3_GameControl.duration)
        {
            float t = elapsedTime / MG3_GameControl.duration;

            float sinValue = Mathf.Sin(t * Mathf.PI);
            float y = Mathf.Lerp(0, 2, (sinValue + 1) / 2);

            transform.position = Vector3.Lerp(startPosition, targetC.position, t) + new Vector3(0, 0, 2) * y;

            elapsedTime += Time.deltaTime;
            yield return null;
        }
        transform.position = targetC.position;

        MG3_ButtonControl.isGuess = true;
        isNewRound = true;
    }
    private IEnumerator MoveSemiCircleRound3()
    {
        isNewRound = false;

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

        startPosition = transform.position;
        elapsedTime = 0;
        while (elapsedTime < MG3_GameControl.duration)
        {
            float t = elapsedTime / MG3_GameControl.duration;

            float sinValue = Mathf.Sin(t * Mathf.PI);
            float y = Mathf.Lerp(0, 2, (sinValue + 1) / 2);

            transform.position = Vector3.Lerp(startPosition, targetA.position, t) + new Vector3(0, 0, -2) * y;

            elapsedTime += Time.deltaTime;
            yield return null;
        }
        transform.position = targetA.position;

        startPosition = transform.position;
        elapsedTime = 0;
        while (elapsedTime < MG3_GameControl.duration)
        {
            float t = elapsedTime / MG3_GameControl.duration;

            float sinValue = Mathf.Sin(t * Mathf.PI);
            float y = Mathf.Lerp(0, 2, (sinValue + 1) / 2);

            transform.position = Vector3.Lerp(startPosition, targetC.position, t) + new Vector3(0, 0, 2) * y;

            elapsedTime += Time.deltaTime;
            yield return null;
        }
        transform.position = targetC.position;

        MG3_ButtonControl.isGuess = true;
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

    void OpenStarCup()
    {
        transform.position += Vector3.up * 3f;
        GameRound();
    }
    void GameRound()
    {
        if (MG3_GameControl.round < 3)
        {
            MG3_ButtonControl.isNextRound = true;
        }
        else
        {
            MG3_GameControl.isEnd = true;
        }
    }
}
