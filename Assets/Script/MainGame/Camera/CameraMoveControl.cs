using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMoveControl : MonoBehaviour
{
    Transform originalLocation, originalRotation;

    void Start()
    {
        originalLocation.position = transform.position;
        originalRotation.rotation = transform.rotation;
    }

    void Update()
    {
        
    }
}
