using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MG5_FishScoreControl : MonoBehaviour
{
    public static float s;

    void FixedUpdate()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "SmallFish")
        {
            s++;
            Destroy(other.gameObject);
        }
    }
}
