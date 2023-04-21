using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MG1_DestoryControl : MonoBehaviour
{
    void Start()
    {
        Destroy(this.gameObject, 3f);
    }
}
