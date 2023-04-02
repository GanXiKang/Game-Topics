using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MG4_RoadBlockControl : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "RoadBlock")
        {
            MG4_JumpComboControl.combo = 0;
            print(MG4_JumpComboControl.combo);
        }
    }
}
