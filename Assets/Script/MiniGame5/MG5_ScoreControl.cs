using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MG5_ScoreControl : MonoBehaviour
{
    float score = 0;

    private void OnTriggerStay(Collider other)
    {
        if (other.tag == "SmallFish")
        {
            score += 3;
        }
    }
}
