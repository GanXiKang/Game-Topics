using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UI_LoadingControl : MonoBehaviour
{
    float timer, timePeriod = 5;

    void Update()
    {
        timer += 1 * Time.deltaTime;

        if (timer > timePeriod)
        {
            Destroy(this.gameObject);
        }
    }
}
