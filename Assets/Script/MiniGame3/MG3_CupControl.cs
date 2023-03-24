using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MG3_CupControl : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Star")
        {
            print("aaaa");
            Destroy(other.gameObject);
        }
    }
}
