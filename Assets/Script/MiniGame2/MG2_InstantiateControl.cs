using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MG2_InstantiateControl : MonoBehaviour
{
    public GameObject apple, boom;

    float appleTimer = 0, appleTimePeriod, boomTimer = 0, boomTimePeriod, x;

    void Update()
    {
        if (MG2_StartButtonControl.isStart == true)
        {
            if (MG2_UIControl.gameTime > 0)
            {
                appleTimer += Time.deltaTime;
                boomTimer += Time.deltaTime;

                appleTimePeriod = Random.Range(0.5f, 1f);
                boomTimePeriod = Random.Range(1.8f, 4f);

                if (appleTimer > appleTimePeriod)
                {
                    x = Random.Range(-30, 30);
                    Instantiate(apple, new Vector3(x, 27f, 0), transform.rotation);

                    appleTimer = 0;
                }
                if (boomTimer > boomTimePeriod)
                {
                    x = Random.Range(-30, 30);
                    Instantiate(boom, new Vector3(x, 27f, 0), transform.rotation);

                    boomTimer = 0;
                }
            }
        }
    }
}
