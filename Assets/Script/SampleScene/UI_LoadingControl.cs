using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UI_LoadingControl : MonoBehaviour
{
    public float timePeriod = 5;
    float timer;
    void Update()
    {
        timer += 1 * Time.deltaTime;

        if (timer > timePeriod)
        {
            Destroy(this.gameObject);
        }
    }
}
