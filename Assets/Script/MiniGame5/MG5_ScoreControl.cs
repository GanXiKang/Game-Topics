using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MG5_ScoreControl : MonoBehaviour
{
    public static float score = 0;


    void FixedUpdate()
    {
        print(score);
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "SmallFish")
        {
            score++;
        }
    }
}
