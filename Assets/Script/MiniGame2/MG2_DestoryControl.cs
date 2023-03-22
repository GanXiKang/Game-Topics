using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MG2_DestoryControl : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Apple")
        {
            Destroy(other.gameObject, 0.2f);
        }
        if (other.tag == "Boom")
        {
            Destroy(other.gameObject, 0.2f);
        }
    }

}
