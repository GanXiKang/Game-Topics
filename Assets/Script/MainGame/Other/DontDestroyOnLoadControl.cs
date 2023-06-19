using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DontDestroyOnLoadControl : MonoBehaviour
{
    static DontDestroyOnLoadControl instance;
    void Start()
    {
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(this.gameObject);
        }
        else if (this != instance)
        {
            Destroy(gameObject);
        }
    }
}
