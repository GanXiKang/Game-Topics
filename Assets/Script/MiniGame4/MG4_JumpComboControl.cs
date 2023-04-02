using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MG4_JumpComboControl : MonoBehaviour
{
    public static float combo = 0;

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "RecordJump")
        {
            combo++;
            print(combo);
        }
    }
}
