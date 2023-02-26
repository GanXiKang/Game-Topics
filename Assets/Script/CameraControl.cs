using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraControl : MonoBehaviour
{
    public GameObject Camera1, Camera2;

    void Update()
    {
        if (Input.GetKeyDown("c"))
        {
            StartCoroutine(ChangeCamera());
        }
    }
    IEnumerator ChangeCamera()
    {
        Camera1.SetActive(false);
        Camera2.SetActive(true);
        yield return new WaitForSeconds(2f);
        Camera1.SetActive(true);
        Camera2.SetActive(false);
    }
}
