using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MG2_InstantiateControl : MonoBehaviour
{
    public GameObject apple;
    public GameObject boom;

    float appleTimer = 0;
    float appleTimePeriod;

    float boomTimer = 0;
    float boomTimePeriod;

    float x;

    void Update()
    {
        appleTimer += Time.deltaTime;
        boomTimer += Time.deltaTime;

        appleTimePeriod = Random.Range(0.8f, 2f);
        boomTimePeriod = Random.Range(1.8f, 4f);

        if (appleTimer > appleTimePeriod)
        {
            x = Random.Range(-60, 60);
            Instantiate(apple, new Vector3(x, 33.8f, 0), transform.rotation);

            appleTimer = 0;
        }
        if (boomTimer > boomTimePeriod)
        {
            x = Random.Range(-60, 60);
            Instantiate(boom, new Vector3(x, 33.8f, 0), transform.rotation);

            boomTimer = 0;
        }
    }
}
