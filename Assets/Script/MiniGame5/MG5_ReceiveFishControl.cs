using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MG5_ReceiveFishControl : MonoBehaviour
{
    public static float score = 0;

    private void OnTriggerEnter(Collider other)
    {
        if (MG5_UIControl.timer < 45)
        {
            if (other.tag == "SmallFish")
            {
                score += 1;
            }
            else if (other.tag == "MidFish")
            {
                score += 3;
            }
            else if (other.tag == "BigFish")
            {
                score += 5;
            }
            else if (other.tag == "Rubbish")
            {
                score -= 3;
            }
        }
        Destroy(other.gameObject);
    }
}
