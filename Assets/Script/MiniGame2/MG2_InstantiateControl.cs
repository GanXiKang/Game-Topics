using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MG2_InstantiateControl : MonoBehaviour
{
    public GameObject apple;

    float timer = 0;
    float timePeriod = 0.5f;
    float x;
    void Start()
    {
        
    }
    void Update()
    {
        timer += Time.deltaTime;

        if (timer > timePeriod)
        {
            x = Random.Range(-60, 60);
            Instantiate(apple, new Vector3(x, 33.8f, 0), transform.rotation);

            timer = 0;
        }
    }
}
