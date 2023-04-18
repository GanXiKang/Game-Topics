using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MG5_ScoreControl : MonoBehaviour
{
    public static float score;


    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "SmallFish")
        {
            score++;
            print(score);
        }
        if (other.tag == "MidFish")
        {
            score += 3;
            Destroy(other.gameObject);
        }
        if (other.tag == "BigFish")
        {
            score += 5;
            Destroy(other.gameObject);
        }
        if (other.tag == "Rubbish")
        {
            score -= 5;
            Destroy(other.gameObject);
        }
    }
}
