using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DontDestroyOnLoadControl : MonoBehaviour
{
    void Start()
    {
        DontDestroyOnLoad(this.gameObject);
    }
}
