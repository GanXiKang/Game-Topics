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
                Destroy(other.gameObject);
            }
            else if (other.tag == "MidFish")
            {
                score += 3;
                Destroy(other.gameObject);
            }
            else if (other.tag == "BigFish")
            {
                score += 5;
                Destroy(other.gameObject);
            }
            else if (other.tag == "Rubbish")
            {
                MG5_UIControl.timer += 3;
                Destroy(other.gameObject);
            }
        }
    }
}
