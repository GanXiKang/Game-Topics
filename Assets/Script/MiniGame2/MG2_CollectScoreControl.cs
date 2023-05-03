using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MG2_CollectScoreControl : MonoBehaviour
{
    public static float score = 0;
    public static bool goodA, badA;

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
            goodA = true;
            Destroy(other.gameObject);
        }
        if (other.tag == "Boom")
        {
            score -= 5;
            badA = true;
            Destroy(other.gameObject);
        }
    }
}
