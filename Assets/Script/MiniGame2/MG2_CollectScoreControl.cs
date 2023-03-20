using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MG2_CollectScoreControl : MonoBehaviour
{
    public static float score = 0;

    void Update()
    {
        if (score <= 0)
        {
            score = 0;
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Apple")
        {
            score++;
        }
        if (other.tag == "Boom")
        {
            score -= 5;
        }
    }
}
