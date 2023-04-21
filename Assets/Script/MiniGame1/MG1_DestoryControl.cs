using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MG1_DestoryControl : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Destory")
        {
            Destroy(this.gameObject, 3f);
        }
    }
}
