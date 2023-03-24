using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MG3_DestoryControl : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Star")
        {
            print("DestoryStar");
            Destroy(other.gameObject);
        }
    }
}
